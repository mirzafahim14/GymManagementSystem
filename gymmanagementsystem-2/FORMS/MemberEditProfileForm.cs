using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using gymmanagementsystem_2;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberEditProfileForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================
        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberEditProfileForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            // Load member information when form opens
            this.Load += MemberEditProfileForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberEditProfileForm_Load(object sender, EventArgs e)
        {
            LoadMemberInformation();
        }


        // =========================================================
        // LOAD CURRENT MEMBER INFORMATION
        // =========================================================
        private void LoadMemberInformation()
        {
            try
            {
                string query = @"
                    SELECT
                        Email,
                        Phone,
                        Address
                    FROM Members
                    WHERE MemberId = @MemberId;
                ";

                DataTable table = DbHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@MemberId", _memberId)
                );

                // Member not found
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Member information not found.",
                        "Member Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    this.Close();
                    return;
                }

                DataRow row = table.Rows[0];

                // =================================================
                // LOAD DATA INTO TEXTBOXES
                // =================================================

                txtEmail.Text = GetString(row["Email"]);

                txtPhone.Text = GetString(row["Phone"]);

                textBox3.Text = GetString(row["Address"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load profile information.\n\n" +
                    ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SAVE CHANGES
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // =====================================================
            // GET INPUT
            // =====================================================

            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = textBox3.Text.Trim();


            // =====================================================
            // VALIDATION
            // =====================================================

            if (email == "")
            {
                MessageBox.Show(
                    "Please enter your email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return;
            }

            if (phone == "")
            {
                MessageBox.Show(
                    "Please enter your phone number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPhone.Focus();
                return;
            }

            if (address == "")
            {
                MessageBox.Show(
                    "Please enter your address.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textBox3.Focus();
                return;
            }


            // =====================================================
            // SIMPLE EMAIL VALIDATION
            // =====================================================

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return;
            }


            // =====================================================
            // CONFIRM UPDATE
            // =====================================================

            DialogResult result = MessageBox.Show(
                "Are you sure you want to update your profile?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }


            // =====================================================
            // UPDATE DATABASE
            // =====================================================

            try
            {
                string query = @"
                    UPDATE Members
                    SET
                        Email = @Email,
                        Phone = @Phone,
                        Address = @Address
                    WHERE MemberId = @MemberId;
                ";

                int rowsAffected = DbHelper.ExecuteNonQuery(
                    query,
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", address),
                    new SqlParameter("@MemberId", _memberId)
                );


                // =================================================
                // CHECK UPDATE RESULT
                // =================================================

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        "Profile updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Close this form and return to profile
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No changes were saved.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update profile.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CANCEL BUTTON
        // =========================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        // =========================================================
        // SAFE STRING CONVERSION
        // =========================================================
        private string GetString(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "";
            }

            return value.ToString() ?? "";
        }


        // =========================================================
        // UNUSED LABEL EVENT
        // =========================================================
        private void lblEmail_Click(object sender, EventArgs e)
        {
            // No action required.
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}