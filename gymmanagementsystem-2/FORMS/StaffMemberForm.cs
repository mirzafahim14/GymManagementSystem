
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffMemberForm : Form
    {
        // =========================================================
        // SELECTED MEMBER
        // =========================================================

        private int selectedMemberId = 0;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public StaffMemberForm()
        {
            InitializeComponent();

            // -----------------------------------------------------
            // STAFF PERMISSION
            // -----------------------------------------------------

            // Staff CAN:
            // Add Member
            // View Member
            // Update Member

            // Staff CANNOT:
            // Delete Member

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;


            // -----------------------------------------------------
            // GRID SETTINGS
            // -----------------------------------------------------

            dgvMembers.ReadOnly = true;

            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;

            dgvMembers.MultiSelect = false;

            dgvMembers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvMembers.AutoGenerateColumns = true;

            dgvMembers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMembers.RowHeadersVisible = false;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffMemberForm_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                LoadGender();

                LoadMembershipPlans();

                LoadMembers();

                ClearFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while loading Staff Member Form.\n\n" +
                    ex.Message,
                    "Staff Member Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LOAD GENDER
        // =========================================================

        private void LoadGender()
        {
            cmbGender.Items.Clear();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

            cmbGender.SelectedIndex = -1;

            cmbGender.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }


        // =========================================================
        // LOAD MEMBERSHIP PLANS
        // =========================================================

        private void LoadMembershipPlans()
        {
            try
            {
                string query = @"
                    SELECT
                        PlanId,
                        PlanName
                    FROM MembershipPlans
                    WHERE IsActive = 1
                    ORDER BY PlanName ASC;
                ";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                cmbMembershipType.DataSource = null;

                cmbMembershipType.DisplayMember =
                    "PlanName";

                cmbMembershipType.ValueMember =
                    "PlanId";

                cmbMembershipType.DataSource = dt;

                cmbMembershipType.SelectedIndex = -1;

                cmbMembershipType.DropDownStyle =
                    ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load membership plans.\n\n" +
                    ex.Message,
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
                        m.Phone,
                        m.Email,
                        m.Gender,
                        m.PlanId,
                        p.PlanName,
                        m.JoinDate,
                        m.ExpiryDate
                    FROM Members m
                    LEFT JOIN MembershipPlans p
                        ON m.PlanId = p.PlanId
                    ORDER BY
                        m.MemberId DESC;
                ";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvMembers.DataSource = null;

                dgvMembers.AutoGenerateColumns = true;

                dgvMembers.DataSource = dt;

                ConfigureMemberGrid();

                dgvMembers.ClearSelection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while loading members.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load members.\n\n" +
                    ex.Message,
                    "Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CONFIGURE MEMBER GRID
        // =========================================================

        private void ConfigureMemberGrid()
        {
            dgvMembers.ReadOnly = true;

            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;

            dgvMembers.MultiSelect = false;

            dgvMembers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvMembers.RowHeadersVisible = false;

            dgvMembers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            // -----------------------------------------------------
            // MEMBER ID
            // -----------------------------------------------------

            SetColumnHeader(
                "MemberId",
                "Member ID"
            );


            // -----------------------------------------------------
            // MEMBER NAME
            // -----------------------------------------------------

            SetColumnHeader(
                "FullName",
                "Member Name"
            );


            // -----------------------------------------------------
            // PHONE
            // -----------------------------------------------------

            SetColumnHeader(
                "Phone",
                "Phone"
            );


            // -----------------------------------------------------
            // EMAIL
            // -----------------------------------------------------

            SetColumnHeader(
                "Email",
                "Email"
            );


            // -----------------------------------------------------
            // GENDER
            // -----------------------------------------------------

            SetColumnHeader(
                "Gender",
                "Gender"
            );


            // -----------------------------------------------------
            // PLAN ID
            // -----------------------------------------------------

            if (dgvMembers.Columns.Contains("PlanId"))
            {
                dgvMembers.Columns["PlanId"].Visible = false;
            }


            // -----------------------------------------------------
            // PLAN NAME
            // -----------------------------------------------------

            SetColumnHeader(
                "PlanName",
                "Membership Plan"
            );


            // -----------------------------------------------------
            // JOIN DATE
            // -----------------------------------------------------

            SetColumnHeader(
                "JoinDate",
                "Join Date"
            );

            if (dgvMembers.Columns.Contains("JoinDate"))
            {
                dgvMembers.Columns["JoinDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }


            // -----------------------------------------------------
            // EXPIRY DATE
            // -----------------------------------------------------

            SetColumnHeader(
                "ExpiryDate",
                "Expiry Date"
            );

            if (dgvMembers.Columns.Contains("ExpiryDate"))
            {
                dgvMembers.Columns["ExpiryDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }
        }


        // =========================================================
        // SET COLUMN HEADER
        // =========================================================

        private void SetColumnHeader(
            string columnName,
            string headerText)
        {
            if (dgvMembers.Columns.Contains(columnName))
            {
                dgvMembers.Columns[columnName]
                    .HeaderText = headerText;
            }
        }


        // =========================================================
        // SAVE MEMBER
        // =========================================================

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateMemberInput())
                return;

            try
            {
                if (MemberAlreadyExists())
                    return;


                string query = @"
                    INSERT INTO Members
                    (
                        FullName,
                        Phone,
                        Email,
                        Gender,
                        PlanId,
                        JoinDate,
                        ExpiryDate
                    )
                    VALUES
                    (
                        @FullName,
                        @Phone,
                        @Email,
                        @Gender,
                        @PlanId,
                        @JoinDate,
                        @ExpiryDate
                    );
                ";


                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@FullName",
                            txtMemberName.Text.Trim()
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
                            "@Gender",
                            cmbGender.Text.Trim()
                        ),

                        new SqlParameter(
                            "@PlanId",
                            Convert.ToInt32(
                                cmbMembershipType.SelectedValue
                            )
                        ),

                        new SqlParameter(
                            "@JoinDate",
                            dtpJoinDate.Value.Date
                        ),

                        new SqlParameter(
                            "@ExpiryDate",
                            dtpExpiryDate.Value.Date
                        )
                    );


                if (result > 0)
                {
                    MessageBox.Show(
                        "Member added successfully!",
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
                        "Member could not be added.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while adding member.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while adding member.\n\n" +
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // UPDATE MEMBER
        // =========================================================

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (selectedMemberId <= 0)
            {
                MessageBox.Show(
                    "Please select a member from the list first.",
                    "Select Member",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            if (!ValidateMemberInput())
                return;


            try
            {
                if (MemberAlreadyExists(selectedMemberId))
                    return;


                string query = @"
                    UPDATE Members
                    SET
                        FullName = @FullName,
                        Phone = @Phone,
                        Email = @Email,
                        Gender = @Gender,
                        PlanId = @PlanId,
                        JoinDate = @JoinDate,
                        ExpiryDate = @ExpiryDate
                    WHERE
                        MemberId = @MemberId;
                ";


                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            selectedMemberId
                        ),

                        new SqlParameter(
                            "@FullName",
                            txtMemberName.Text.Trim()
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
                            "@Gender",
                            cmbGender.Text.Trim()
                        ),

                        new SqlParameter(
                            "@PlanId",
                            Convert.ToInt32(
                                cmbMembershipType.SelectedValue
                            )
                        ),

                        new SqlParameter(
                            "@JoinDate",
                            dtpJoinDate.Value.Date
                        ),

                        new SqlParameter(
                            "@ExpiryDate",
                            dtpExpiryDate.Value.Date
                        )
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
                        "Member could not be updated.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while updating member.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while updating member.\n\n" +
                    ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CHECK DUPLICATE MEMBER
        // =========================================================

        private bool MemberAlreadyExists(
            int excludeMemberId = 0)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Members
                    WHERE
                        (
                            Phone = @Phone
                            OR Email = @Email
                        )
                        AND MemberId <> @MemberId;
                ";


                object result =
                    DbHelper.ExecuteScalar(
                        query,

                        new SqlParameter(
                            "@Phone",
                            txtPhone.Text.Trim()
                        ),

                        new SqlParameter(
                            "@Email",
                            txtEmail.Text.Trim()
                        ),

                        new SqlParameter(
                            "@MemberId",
                            excludeMemberId
                        )
                    );


                int count = 0;


                if (result != null &&
                    result != DBNull.Value)
                {
                    count =
                        Convert.ToInt32(result);
                }


                if (count > 0)
                {
                    MessageBox.Show(
                        "A member with the same phone number " +
                        "or email already exists.",
                        "Duplicate Member",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to check duplicate member.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return true;
            }


            return false;
        }


        // =========================================================
        // DELETE
        // =========================================================

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            // -----------------------------------------------------
            // STAFF DOES NOT HAVE DELETE ACCESS
            // -----------------------------------------------------

            MessageBox.Show(
                "Staff users are not allowed to delete members.\n\n" +
                "Only Admin and Super Admin can delete members.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }


        // =========================================================
        // CLEAR BUTTON
        // =========================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }


        // =========================================================
        // CLEAR FIELDS
        // =========================================================

        private void ClearFields(
            bool focusName = true)
        {
            selectedMemberId = 0;

            txtMemberName.Clear();

            txtPhone.Clear();

            txtEmail.Clear();


            cmbGender.SelectedIndex = -1;


            if (cmbMembershipType.Items.Count > 0)
            {
                cmbMembershipType.SelectedIndex = -1;
            }


            dtpJoinDate.Value =
                DateTime.Today;


            dtpExpiryDate.Value =
                DateTime.Today.AddMonths(1);


            // -----------------------------------------------------
            // STAFF ACCESS
            // -----------------------------------------------------

            btnDelete.Enabled = false;

            btnUpdate.Enabled = false;


            dgvMembers.ClearSelection();


            if (focusName)
            {
                txtMemberName.Focus();
            }
        }


        // =========================================================
        // GRID CELL CLICK
        // =========================================================

        private void dgvMembers_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                if (e.RowIndex >= dgvMembers.Rows.Count)
                    return;


                DataGridViewRow row =
                    dgvMembers.Rows[e.RowIndex];


                // -------------------------------------------------
                // MEMBER ID
                // -------------------------------------------------

                if (!dgvMembers.Columns.Contains(
                    "MemberId"))
                {
                    return;
                }


                object memberIdValue =
                    row.Cells["MemberId"].Value;


                if (memberIdValue == null ||
                    memberIdValue == DBNull.Value)
                {
                    return;
                }


                selectedMemberId =
                    Convert.ToInt32(
                        memberIdValue
                    );


                // -------------------------------------------------
                // MEMBER NAME
                // -------------------------------------------------

                txtMemberName.Text =
                    GetCellString(
                        row,
                        "FullName"
                    );


                // -------------------------------------------------
                // PHONE
                // -------------------------------------------------

                txtPhone.Text =
                    GetCellString(
                        row,
                        "Phone"
                    );


                // -------------------------------------------------
                // EMAIL
                // -------------------------------------------------

                txtEmail.Text =
                    GetCellString(
                        row,
                        "Email"
                    );


                // -------------------------------------------------
                // GENDER
                // -------------------------------------------------

                string gender =
                    GetCellString(
                        row,
                        "Gender"
                    );


                if (!string.IsNullOrWhiteSpace(
                    gender))
                {
                    cmbGender.Text =
                        gender;
                }
                else
                {
                    cmbGender.SelectedIndex = -1;
                }


                // -------------------------------------------------
                // MEMBERSHIP PLAN
                // -------------------------------------------------

                if (dgvMembers.Columns.Contains(
                    "PlanId"))
                {
                    object planId =
                        row.Cells["PlanId"].Value;


                    if (planId != null &&
                        planId != DBNull.Value)
                    {
                        cmbMembershipType.SelectedValue =
                            Convert.ToInt32(
                                planId
                            );
                    }
                    else
                    {
                        cmbMembershipType.SelectedIndex =
                            -1;
                    }
                }


                // -------------------------------------------------
                // JOIN DATE
                // -------------------------------------------------

                if (dgvMembers.Columns.Contains(
                    "JoinDate"))
                {
                    object joinDate =
                        row.Cells["JoinDate"].Value;


                    if (joinDate != null &&
                        joinDate != DBNull.Value)
                    {
                        DateTime date =
                            Convert.ToDateTime(
                                joinDate
                            );


                        if (date >=
                                dtpJoinDate.MinDate &&
                            date <=
                                dtpJoinDate.MaxDate)
                        {
                            dtpJoinDate.Value =
                                date;
                        }
                    }
                }


                // -------------------------------------------------
                // EXPIRY DATE
                // -------------------------------------------------

                if (dgvMembers.Columns.Contains(
                    "ExpiryDate"))
                {
                    object expiryDate =
                        row.Cells["ExpiryDate"].Value;


                    if (expiryDate != null &&
                        expiryDate != DBNull.Value)
                    {
                        DateTime date =
                            Convert.ToDateTime(
                                expiryDate
                            );


                        if (date >=
                                dtpExpiryDate.MinDate &&
                            date <=
                                dtpExpiryDate.MaxDate)
                        {
                            dtpExpiryDate.Value =
                                date;
                        }
                    }
                }


                // -------------------------------------------------
                // STAFF CAN UPDATE
                // -------------------------------------------------

                btnUpdate.Enabled = true;


                // -------------------------------------------------
                // STAFF CAN NEVER DELETE
                // -------------------------------------------------

                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to select member.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // GET CELL STRING
        // =========================================================

        private string GetCellString(
            DataGridViewRow row,
            string columnName)
        {
            try
            {
                if (!dgvMembers.Columns.Contains(
                    columnName))
                {
                    return "";
                }


                object value =
                    row.Cells[columnName].Value;


                if (value == null ||
                    value == DBNull.Value)
                {
                    return "";
                }


                return Convert.ToString(value);
            }
            catch
            {
                return "";
            }
        }


        // =========================================================
        // VALIDATE MEMBER INPUT
        // =========================================================

        private bool ValidateMemberInput()
        {
            // -----------------------------------------------------
            // MEMBER NAME
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                txtMemberName.Text))
            {
                MessageBox.Show(
                    "Please enter member name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMemberName.Focus();

                return false;
            }


            // -----------------------------------------------------
            // PHONE
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter phone number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPhone.Focus();

                return false;
            }


            // -----------------------------------------------------
            // EMAIL
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(
                txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter email address.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();

                return false;
            }


            // -----------------------------------------------------
            // GENDER
            // -----------------------------------------------------

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select gender.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbGender.Focus();

                return false;
            }


            // -----------------------------------------------------
            // MEMBERSHIP PLAN
            // -----------------------------------------------------

            if (cmbMembershipType.SelectedIndex == -1 ||
                cmbMembershipType.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select membership plan.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbMembershipType.Focus();

                return false;
            }


            // -----------------------------------------------------
            // DATE VALIDATION
            // -----------------------------------------------------

            if (dtpExpiryDate.Value.Date <
                dtpJoinDate.Value.Date)
            {
                MessageBox.Show(
                    "Expiry date cannot be before join date.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtpExpiryDate.Focus();

                return false;
            }


            return true;
        }
    }
}
