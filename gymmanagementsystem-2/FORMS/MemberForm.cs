using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberForm : Form
    {
        private readonly string userRole;

        public MemberForm(string role)
        {
            InitializeComponent();
            userRole = role?.Trim() ?? "";
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            if (!CheckAdminPermission())
            {
                BeginInvoke(new Action(() => Close()));
                return;
            }

            try
            {
                txtMemberId.ReadOnly = true;
                SetupGenderComboBox();
                LoadMembershipTypes();
                LoadMembers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load Member Form.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetupGenderComboBox()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = -1;
        }

        private void LoadMembershipTypes()
        {
            try
            {
                string query = @"
                    SELECT PlanId, PlanName
                    FROM MembershipPlans
                    WHERE IsActive = 1
                    ORDER BY PlanId;";

                DataTable dt = DbHelper.ExecuteQuery(query);
                cmbMembershipType.DataSource = null;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No active membership plans found.\n\nPlease add a membership plan first.",
                        "Membership Plans",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                cmbMembershipType.DataSource = dt;
                cmbMembershipType.DisplayMember = "PlanName";
                cmbMembershipType.ValueMember = "PlanId";
                cmbMembershipType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load membership plans.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadMembers()
        {
            try
            {
                string query = @"
                    SELECT
                        m.MemberId,
                        m.FullName,
                        m.Gender,
                        m.DateOfBirth,
                        m.Phone,
                        m.Email,
                        m.Address,
                        m.JoinDate,
                        m.PlanId,
                        p.PlanName AS MembershipType,
                        m.MembershipStartDate,
                        m.MembershipEndDate,
                        m.Status
                    FROM Members m
                    LEFT JOIN MembershipPlans p ON m.PlanId = p.PlanId
                    ORDER BY m.MemberId DESC;";

                DataTable dt = DbHelper.ExecuteQuery(query);
                dgvMembers.DataSource = dt;

                dgvMembers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMembers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvMembers.MultiSelect = false;
                dgvMembers.ReadOnly = true;

                if (dgvMembers.Columns.Contains("PlanId"))
                    dgvMembers.Columns["PlanId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load members.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateMemberInput()
        {
            if (string.IsNullOrWhiteSpace(txtMemberName.Text))
            {
                MessageBox.Show("Please enter member name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }

            if (cmbMembershipType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select membership type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMembershipType.Focus();
                return false;
            }

            if (dtpExpiryDate.Value.Date < dtpJoinDate.Value.Date)
            {
                MessageBox.Show(
                    "Expiry date cannot be before join date.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpExpiryDate.Focus();
                return false;
            }

            return true;
        }

        private bool CheckAdminPermission()
        {
            if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                userRole.Equals("Super Admin", StringComparison.OrdinalIgnoreCase))
                return true;

            MessageBox.Show(
                "Access denied.\n\nOnly Admin and Super Admin can access Member Management.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckAdminPermission() || !ValidateMemberInput())
                return;

            try
            {
                int planId = Convert.ToInt32(cmbMembershipType.SelectedValue);

                string query = @"
                    INSERT INTO Members
                    (
                        FullName, Gender, DateOfBirth, Phone, Email, Address,
                        JoinDate, PlanId, MembershipStartDate,
                        MembershipEndDate, Status
                    )
                    VALUES
                    (
                        @FullName, @Gender, @DateOfBirth, @Phone, @Email, @Address,
                        @JoinDate, @PlanId, @MembershipStartDate,
                        @MembershipEndDate, @Status
                    );";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@FullName", txtMemberName.Text.Trim()),
                    new SqlParameter("@Gender", cmbGender.Text),
                    new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.Date),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@Email",
                        string.IsNullOrWhiteSpace(txtEmail.Text)
                            ? (object)DBNull.Value : txtEmail.Text.Trim()),
                    new SqlParameter("@Address",
                        string.IsNullOrWhiteSpace(txtAddress.Text)
                            ? (object)DBNull.Value : txtAddress.Text.Trim()),
                    new SqlParameter("@JoinDate", dtpJoinDate.Value.Date),
                    new SqlParameter("@PlanId", planId),
                    new SqlParameter("@MembershipStartDate", dtpJoinDate.Value.Date),
                    new SqlParameter("@MembershipEndDate", dtpExpiryDate.Value.Date),
                    new SqlParameter("@Status", "Active")
                };

                int result = DbHelper.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Member saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error:\n\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckAdminPermission())
                return;

            if (string.IsNullOrWhiteSpace(txtMemberId.Text))
            {
                MessageBox.Show("Please select a member first.", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateMemberInput())
                return;

            try
            {
                int memberId = Convert.ToInt32(txtMemberId.Text);
                int planId = Convert.ToInt32(cmbMembershipType.SelectedValue);

                string query = @"
                    UPDATE Members
                    SET
                        FullName = @FullName,
                        Gender = @Gender,
                        DateOfBirth = @DateOfBirth,
                        Phone = @Phone,
                        Email = @Email,
                        Address = @Address,
                        JoinDate = @JoinDate,
                        PlanId = @PlanId,
                        MembershipStartDate = @MembershipStartDate,
                        MembershipEndDate = @MembershipEndDate
                    WHERE MemberId = @MemberId;";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@MemberId", memberId),
                    new SqlParameter("@FullName", txtMemberName.Text.Trim()),
                    new SqlParameter("@Gender", cmbGender.Text),
                    new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.Date),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@Email",
                        string.IsNullOrWhiteSpace(txtEmail.Text)
                            ? (object)DBNull.Value : txtEmail.Text.Trim()),
                    new SqlParameter("@Address",
                        string.IsNullOrWhiteSpace(txtAddress.Text)
                            ? (object)DBNull.Value : txtAddress.Text.Trim()),
                    new SqlParameter("@JoinDate", dtpJoinDate.Value.Date),
                    new SqlParameter("@PlanId", planId),
                    new SqlParameter("@MembershipStartDate", dtpJoinDate.Value.Date),
                    new SqlParameter("@MembershipEndDate", dtpExpiryDate.Value.Date)
                };

                int result = DbHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show(
                    result > 0 ? "Member updated successfully!" : "Member was not found.",
                    "Update",
                    MessageBoxButtons.OK,
                    result > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result > 0)
                {
                    LoadMembers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error:\n\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckAdminPermission())
                return;

            if (string.IsNullOrWhiteSpace(txtMemberId.Text))
            {
                MessageBox.Show("Please select a member first.", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                "Are you sure you want to delete this member?\n\n" +
                "Member ID: " + txtMemberId.Text,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string query = "DELETE FROM Members WHERE MemberId = @MemberId;";

                int result = DbHelper.ExecuteNonQuery(
                    query,
                    new SqlParameter("@MemberId", Convert.ToInt32(txtMemberId.Text)));

                if (result > 0)
                {
                    MessageBox.Show("Member deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Member was not found.", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Member could not be deleted.\n\n" +
                    "This member may have related records.\n\n" + ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error:\n\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtMemberId.Clear();
            txtMemberName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            cmbGender.SelectedIndex = -1;
            cmbMembershipType.SelectedIndex = -1;

            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);
            dtpJoinDate.Value = DateTime.Today;
            dtpExpiryDate.Value = DateTime.Today.AddMonths(1);

            txtMemberName.Focus();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];

                txtMemberId.Text = GetCellValue(row, "MemberId");
                txtMemberName.Text = GetCellValue(row, "FullName");
                cmbGender.Text = GetCellValue(row, "Gender");

                SetDateValue(dtpDateOfBirth, row, "DateOfBirth");

                txtPhone.Text = GetCellValue(row, "Phone");
                txtEmail.Text = GetCellValue(row, "Email");
                txtAddress.Text = GetCellValue(row, "Address");

                SetDateValue(dtpJoinDate, row, "JoinDate");

                if (dgvMembers.Columns.Contains("PlanId"))
                {
                    object planValue = row.Cells["PlanId"].Value;

                    if (planValue != null && planValue != DBNull.Value)
                        cmbMembershipType.SelectedValue = Convert.ToInt32(planValue);
                    else
                        cmbMembershipType.SelectedIndex = -1;
                }

                SetDateValue(dtpExpiryDate, row, "MembershipEndDate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load selected member.\n\n" + ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            if (!dgvMembers.Columns.Contains(columnName))
                return "";

            object value = row.Cells[columnName].Value;

            if (value == null || value == DBNull.Value)
                return "";

            return value.ToString();
        }

        private void SetDateValue(
            DateTimePicker picker,
            DataGridViewRow row,
            string columnName)
        {
            if (!dgvMembers.Columns.Contains(columnName))
                return;

            object value = row.Cells[columnName].Value;

            if (value == null || value == DBNull.Value)
            {
                picker.Value = DateTime.Today;
                return;
            }

            if (DateTime.TryParse(value.ToString(), out DateTime date))
                picker.Value = date;
            else
                picker.Value = DateTime.Today;
        }

        // Keep these if your Designer already has these event handlers.
        private void lblMemberId_Click(object sender, EventArgs e) { }
        private void lblAddress_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblJoinDate_Click(object sender, EventArgs e) { }
        private void dgvMembers_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        { }
    }
}
