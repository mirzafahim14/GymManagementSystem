using gymmanagementsystem_2;
using gymmanagementsystem_2.FORMS;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        // =========================================================
        // LOGIN BUTTON
        // =========================================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // =====================================================
            // USERNAME VALIDATION
            // =====================================================

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsername.Focus();
                return;
            }


            // =====================================================
            // PASSWORD VALIDATION
            // =====================================================

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }


            try
            {
                // =================================================
                // GET USER INFORMATION
                // =================================================

                string query = @"
                    SELECT
                        UserId,
                        FullName,
                        Username,
                        PasswordHash,
                        Role,
                        IsActive,
                        MemberId
                    FROM Users
                    WHERE Username = @Username;
                ";


                DataTable table = DbHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@Username", username)
                );


                // =================================================
                // USER NOT FOUND
                // =================================================

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtPassword.Clear();
                    txtPassword.Focus();

                    return;
                }


                // =================================================
                // USER DATA
                // =================================================

                DataRow user = table.Rows[0];

                string storedHash =
                    user["PasswordHash"]?.ToString() ?? "";

                string role =
                    user["Role"]?.ToString() ?? "";

                string fullName =
                    user["FullName"]?.ToString() ?? "";

                bool isActive =
                    Convert.ToBoolean(user["IsActive"]);


                // =================================================
                // CHECK ACCOUNT STATUS
                // =================================================

                if (!isActive)
                {
                    MessageBox.Show(
                        "Your account is inactive.\n\n" +
                        "Please contact the administrator.",
                        "Account Inactive",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // =================================================
                // VERIFY PASSWORD
                // =================================================

                bool passwordCorrect =
                    PasswordHasher.VerifyPassword(
                        password,
                        storedHash
                    );


                if (!passwordCorrect)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtPassword.Clear();
                    txtPassword.Focus();

                    return;
                }


                // =================================================
                // LOGIN SUCCESSFUL
                // =================================================

                MessageBox.Show(
                    "Welcome, " + fullName + "!\n\n" +
                    "Role: " + role,
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                // =================================================
                // OPEN DASHBOARD
                // =================================================

                OpenDashboard(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database/Login Error:\n\n" +
                    ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // OPEN DASHBOARD BASED ON ROLE
        // =========================================================
        private void OpenDashboard(DataRow user)
        {
            string role =
                user["Role"]?.ToString() ?? "";


            Form dashboard = null;


            // =====================================================
            // ADMIN
            // =====================================================

            if (role.Equals(
                "Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                dashboard = new DashboardForm();
            }


            // =====================================================
            // SUPER ADMIN
            // =====================================================

            else if (role.Equals(
                "Super Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                dashboard = new DashboardForm();
            }


            // =====================================================
            // STAFF
            // =====================================================

            else if (role.Equals(
                "Staff",
                StringComparison.OrdinalIgnoreCase))
            {
                dashboard = new StaffDashboardForm();
            }


            // =====================================================
            // MEMBER
            // =====================================================

            else if (role.Equals(
                "Member",
                StringComparison.OrdinalIgnoreCase))
            {
                // -----------------------------------------------
                // MEMBER ID MUST EXIST
                // -----------------------------------------------

                if (user["MemberId"] == DBNull.Value ||
                    user["MemberId"] == null)
                {
                    MessageBox.Show(
                        "This Member account is not linked " +
                        "to a Member record.\n\n" +
                        "Please contact the administrator.",
                        "Member Account Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }


                int memberId =
                    Convert.ToInt32(user["MemberId"]);


                // -----------------------------------------------
                // OPEN MEMBER DASHBOARD
                // -----------------------------------------------

                dashboard =
                    new MemberDashboardForm(memberId);
            }


            // =====================================================
            // UNKNOWN ROLE
            // =====================================================

            else
            {
                MessageBox.Show(
                    "Unknown user role: " + role,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            // =====================================================
            // DASHBOARD CLOSED
            // =====================================================

            dashboard.FormClosed += Dashboard_FormClosed;


            // =====================================================
            // SHOW DASHBOARD
            // =====================================================

            dashboard.Show();


            // =====================================================
            // HIDE LOGIN FORM
            // =====================================================

            this.Hide();
        }


        // =========================================================
        // DASHBOARD CLOSED
        // =========================================================
        private void Dashboard_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            this.Close();
        }


        // =========================================================
        // CLEAR BUTTON
        // =========================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }


        // =========================================================
        // EXIT BUTTON
        // =========================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}