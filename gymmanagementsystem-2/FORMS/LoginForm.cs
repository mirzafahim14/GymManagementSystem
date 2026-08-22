using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using gymmanagementsystem_2;
using gymmanagementsystem_2.FORMS;

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

            // -----------------------------------------------------
            // Username validation
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            // -----------------------------------------------------
            // Password validation
            // -----------------------------------------------------
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            try
            {
                // =================================================
                // GET USER FROM DATABASE
                // =================================================

                string query = @"
                    SELECT UserId,
                           FullName,
                           Username,
                           PasswordHash,
                           Role,
                           IsActive,
                           MemberId
                    FROM Users
                    WHERE Username = @Username;";

                SqlParameter parameter =
                    new SqlParameter("@Username", username);

                DataTable table =
                    DbHelper.ExecuteQuery(query, parameter);

                // =================================================
                // USER NOT FOUND
                // =================================================

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

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

                string fullName =
                    user["FullName"]?.ToString() ?? "";

                string role =
                    user["Role"]?.ToString()?.Trim() ?? "";

                bool isActive =
                    Convert.ToBoolean(user["IsActive"]);

                // =================================================
                // CHECK ACCOUNT ACTIVE
                // =================================================

                if (!isActive)
                {
                    MessageBox.Show(
                        "Your account is inactive.\n\n" +
                        "Please contact the administrator.",
                        "Account Inactive",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =================================================
                // VERIFY PASSWORD
                // =================================================

                bool passwordCorrect =
                    PasswordHasher.VerifyPassword(
                        password,
                        storedHash);

                if (!passwordCorrect)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();

                    return;
                }

                // =================================================
                // LOGIN SUCCESS
                // =================================================

                MessageBox.Show(
                    "Welcome, " + fullName +
                    "!\n\nRole: " + role,
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                OpenDashboard(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database/Login Error:\n\n" +
                    ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // OPEN DASHBOARD BASED ON ROLE
        // =========================================================
        private void OpenDashboard(DataRow user)
        {
            string role =
                user["Role"]?.ToString()?.Trim() ?? "";

            string fullName =
                user["FullName"]?.ToString()?.Trim() ?? "";

            Form dashboard = null;

            // -----------------------------------------------------
            // SUPER ADMIN
            // -----------------------------------------------------
            if (role.Equals(
                "Super Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                dashboard = new DashboardForm(role);
            }

            // -----------------------------------------------------
            // ADMIN
            // -----------------------------------------------------
            else if (role.Equals(
                "Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                dashboard = new DashboardForm(role);
            }

            // -----------------------------------------------------
            // STAFF
            // -----------------------------------------------------
            else if (role.Equals(
                "Staff",
                StringComparison.OrdinalIgnoreCase))
            {
                dashboard =
                    new StaffDashboardForm(
                        fullName,
                        role);
            }

            // -----------------------------------------------------
            // MEMBER
            // -----------------------------------------------------
            else if (role.Equals(
                "Member",
                StringComparison.OrdinalIgnoreCase))
            {
                if (user["MemberId"] == DBNull.Value ||
                    user["MemberId"] == null)
                {
                    MessageBox.Show(
                        "This Member account is not linked " +
                        "to a Member record.\n\n" +
                        "Please contact the administrator.",
                        "Member Account Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                int memberId =
                    Convert.ToInt32(user["MemberId"]);

                dashboard =
                    new MemberDashboardForm(memberId);
            }

            // -----------------------------------------------------
            // UNKNOWN ROLE
            // -----------------------------------------------------
            else
            {
                MessageBox.Show(
                    "Unknown user role: " + role,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // =====================================================
            // SHOW DASHBOARD
            // =====================================================

            if (dashboard == null)
            {
                MessageBox.Show(
                    "Unable to open dashboard.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            dashboard.FormClosed += Dashboard_FormClosed;

            dashboard.Show();

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

            chkShowPassword.Checked = false;

            txtUsername.Focus();
        }

        // =========================================================
        // EXIT BUTTON
        // =========================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =========================================================
        // SHOW / HIDE PASSWORD
        // =========================================================
        private void chkShowPassword_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';
            }
        }
    }
}