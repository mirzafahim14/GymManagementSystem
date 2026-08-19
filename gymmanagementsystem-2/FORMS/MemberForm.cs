using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberForm_Load(object sender, EventArgs e)
        {
            LoadMembershipTypes();
            LoadMembers();

            txtMemberId.ReadOnly = true;

            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

            cmbGender.SelectedIndex = -1;
        }


        // =========================================================
        // LOAD MEMBERSHIP TYPES
        // =========================================================
        private void LoadMembershipTypes()
        {
            try
            {
                string query = @"
                    SELECT PlanId, PlanName
                    FROM MembershipPlans
                    WHERE IsActive = 1
                    ORDER BY PlanId";

                DataTable dt = DbHelper.ExecuteQuery(query);

                cmbMembershipType.DataSource = null;

                if (dt.Rows.Count > 0)
                {
                    cmbMembershipType.DataSource = dt;
                    cmbMembershipType.DisplayMember = "PlanName";
                    cmbMembershipType.ValueMember = "PlanId";
                    cmbMembershipType.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(
                        "No membership plans found.\nPlease add membership plans first.",
                        "Membership",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load membership plans.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LOAD MEMBERS
        // =========================================================
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
                    LEFT JOIN MembershipPlans p
                        ON m.PlanId = p.PlanId
                    ORDER BY m.MemberId DESC";

                DataTable dt = DbHelper.ExecuteQuery(query);

                dgvMembers.DataSource = dt;

                dgvMembers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvMembers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvMembers.MultiSelect = false;

                dgvMembers.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load members.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SAVE MEMBER
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (txtMemberName.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Please enter member name.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtMemberName.Focus();
                    return;
                }

                if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Please enter phone number.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPhone.Focus();
                    return;
                }

                if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select gender.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbGender.Focus();
                    return;
                }

                if (cmbMembershipType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select membership type.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbMembershipType.Focus();
                    return;
                }


                int planId = Convert.ToInt32(
                    cmbMembershipType.SelectedValue
                );

                string query = @"
                    INSERT INTO Members
                    (
                        FullName,
                        Gender,
                        DateOfBirth,
                        Phone,
                        Email,
                        Address,
                        JoinDate,
                        PlanId,
                        MembershipStartDate,
                        MembershipEndDate,
                        Status
                    )
                    VALUES
                    (
                        @FullName,
                        @Gender,
                        @DateOfBirth,
                        @Phone,
                        @Email,
                        @Address,
                        @JoinDate,
                        @PlanId,
                        @MembershipStartDate,
                        @MembershipEndDate,
                        @Status
                    )";


                SqlParameter[] parameters =
                {
                    new SqlParameter("@FullName", txtMemberName.Text.Trim()),

                    new SqlParameter("@Gender", cmbGender.Text),

                    new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.Date),

                    new SqlParameter("@Phone", txtPhone.Text.Trim()),

                    new SqlParameter("@Email", txtEmail.Text.Trim()),

                    new SqlParameter("@Address", txtAddress.Text.Trim()),

                    new SqlParameter("@JoinDate", dtpJoinDate.Value.Date),

                    new SqlParameter("@PlanId", planId),

                    new SqlParameter(
                        "@MembershipStartDate",
                        dtpJoinDate.Value.Date
                    ),

                    new SqlParameter(
                        "@MembershipEndDate",
                        dtpExpiryDate.Value.Date
                    ),

                    new SqlParameter("@Status", "Active")
                };


                int result = DbHelper.ExecuteNonQuery(
                    query,
                    parameters
                );


                if (result > 0)
                {
                    MessageBox.Show(
                        "Member saved successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadMembers();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Member could not be saved.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Save Error:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // UPDATE MEMBER
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberId.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Please select a member first.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (cmbMembershipType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select membership type.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                int memberId =
                    Convert.ToInt32(txtMemberId.Text);

                int planId =
                    Convert.ToInt32(cmbMembershipType.SelectedValue);


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
                    WHERE MemberId = @MemberId";


                SqlParameter[] parameters =
                {
                    new SqlParameter("@MemberId", memberId),

                    new SqlParameter(
                        "@FullName",
                        txtMemberName.Text.Trim()
                    ),

                    new SqlParameter(
                        "@Gender",
                        cmbGender.Text
                    ),

                    new SqlParameter(
                        "@DateOfBirth",
                       dtpDateOfBirth.Value.Date
                    ),

                    new SqlParameter(
                        "@Phone",
                        txtPhone.Text.Trim()
                    ),

                    new SqlParameter(
                        "@Email",
                        txtEmail.Text.Trim()
                    ),

                    new SqlParameter(
                        "@Address",
                        txtAddress.Text.Trim()
                    ),

                    new SqlParameter(
                        "@JoinDate",
                        dtpJoinDate.Value.Date
                    ),

                    new SqlParameter(
                        "@PlanId",
                        planId
                    ),

                    new SqlParameter(
                        "@MembershipStartDate",
                        dtpJoinDate.Value.Date
                    ),

                    new SqlParameter(
                        "@MembershipEndDate",
                        dtpExpiryDate.Value.Date
                    )
                };


                int result =
                    DbHelper.ExecuteNonQuery(
                        query,
                        parameters
                    );


                if (result > 0)
                {
                    MessageBox.Show(
                        "Member updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadMembers();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Member not found.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Update Error:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // DELETE MEMBER
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberId.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Please select a member first.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete this member?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );


                if (result != DialogResult.Yes)
                    return;


                int memberId =
                    Convert.ToInt32(txtMemberId.Text);


                string query = @"
                    DELETE FROM Members
                    WHERE MemberId = @MemberId";


                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@MemberId",
                        memberId
                    )
                };


                int deleted =
                    DbHelper.ExecuteNonQuery(
                        query,
                        parameters
                    );


                if (deleted > 0)
                {
                    MessageBox.Show(
                        "Member deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadMembers();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete Error:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CLEAR BUTTON
        // =========================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        // =========================================================
        // CLEAR FIELDS
        // =========================================================
        private void ClearFields()
        {
            txtMemberId.Clear();

            txtMemberName.Clear();

            txtPhone.Clear();

            txtEmail.Clear();

            txtAddress.Clear();

            cmbGender.SelectedIndex = -1;

            cmbMembershipType.SelectedIndex = -1;

            dtpDateOfBirth.Value = DateTime.Today;

            dtpJoinDate.Value = DateTime.Today;

            dtpExpiryDate.Value = DateTime.Today;

            txtMemberName.Focus();
        }


        // =========================================================
        // DATAGRIDVIEW ROW CLICK
        // =========================================================
        private void dgvMembers_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvMembers.Rows[e.RowIndex];


                txtMemberId.Text =
                    row.Cells["MemberId"].Value?.ToString();

                txtMemberName.Text =
                    row.Cells["FullName"].Value?.ToString();

                cmbGender.Text =
                    row.Cells["Gender"].Value?.ToString();

                if (row.Cells["DateOfBirth"].Value != null)
                {
                    dtpDateOfBirth.Value =
                        Convert.ToDateTime(
                            row.Cells["DateOfBirth"].Value
                        );
                }

                txtPhone.Text =
                    row.Cells["Phone"].Value?.ToString();

                txtEmail.Text =
                    row.Cells["Email"].Value?.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value?.ToString();


                if (row.Cells["JoinDate"].Value != null)
                {
                    dtpJoinDate.Value =
                        Convert.ToDateTime(
                            row.Cells["JoinDate"].Value
                        );
                }


                // IMPORTANT:
                // PlanId column থেকে membership select হবে
                if (row.Cells["PlanId"].Value != null)
                {
                    cmbMembershipType.SelectedValue =
                        Convert.ToInt32(
                            row.Cells["PlanId"].Value
                        );
                }


                if (row.Cells["MembershipEndDate"].Value != null)
                {
                    dtpExpiryDate.Value =
                        Convert.ToDateTime(
                            row.Cells["MembershipEndDate"].Value
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load selected member.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // EMPTY EVENTS
        // =========================================================

        private void lblMemberId_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblAddress_Click(
            object sender,
            EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void lblJoinDate_Click(
            object sender,
            EventArgs e)
        {
        }

        private void dgvMembers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}