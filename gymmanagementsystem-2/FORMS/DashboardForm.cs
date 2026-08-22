using GymManagementSystem.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using gymmanagementsystem_2;

namespace gymmanagementsystem_2.FORMS
{
    public partial class DashboardForm : Form
    {
        private readonly string currentUserRole;

        public DashboardForm(string role)
        {
            InitializeComponent();

            currentUserRole = role?.Trim() ?? "";

            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (currentUserRole != "Admin" &&
                currentUserRole != "Super Admin")
            {
                MessageBox.Show(
                    "Access denied. This dashboard is only for Admin and Super Admin.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                object memberResult =
                    DbHelper.ExecuteScalar("SELECT COUNT(*) FROM Members");
                lblTotalMembers.Text = Convert.ToString(memberResult);

                object trainerResult =
                    DbHelper.ExecuteScalar("SELECT COUNT(*) FROM Trainers");
                lblTotalTrainers.Text = Convert.ToString(trainerResult);

                object attendanceResult =
                    DbHelper.ExecuteScalar(@"
                        SELECT COUNT(*)
                        FROM Attendance
                        WHERE AttendanceDate = CAST(GETDATE() AS DATE)");
                lblAttendanceToday.Text = Convert.ToString(attendanceResult);

                object paymentResult =
                    DbHelper.ExecuteScalar(@"
                        SELECT COALESCE(SUM(Amount), 0)
                        FROM Payments");

                decimal totalPayment = Convert.ToDecimal(paymentResult);
                IblTotalPayment.Text = totalPayment.ToString("0.00");

                string query = @"
                    SELECT TOP 10
                        m.MemberId,
                        m.FullName,
                        m.Gender,
                        m.DateOfBirth,
                        m.Phone,
                        m.Email,
                        m.Address,
                        m.JoinDate,
                        m.PlanId,
                        m.ExpiryDate,
                        m.Status
                    FROM Members m
                    ORDER BY m.MemberId DESC";

                DataTable dt = DbHelper.ExecuteQuery(query);
                dgvRecentMembers.DataSource = dt;

                SetHeader("MemberId", "Member ID");
                SetHeader("FullName", "Member Name");
                SetHeader("Gender", "Gender");
                SetHeader("DateOfBirth", "Date of Birth");
                SetHeader("Phone", "Phone");
                SetHeader("Email", "Email");
                SetHeader("Address", "Address");
                SetHeader("JoinDate", "Join Date");
                SetHeader("PlanId", "Membership Plan");
                SetHeader("ExpiryDate", "Expiry Date");
                SetHeader("Status", "Status");

                if (dgvRecentMembers.Columns.Contains("DateOfBirth"))
                    dgvRecentMembers.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                if (dgvRecentMembers.Columns.Contains("JoinDate"))
                    dgvRecentMembers.Columns["JoinDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                if (dgvRecentMembers.Columns.Contains("ExpiryDate"))
                    dgvRecentMembers.Columns["ExpiryDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                dgvRecentMembers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvRecentMembers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvRecentMembers.MultiSelect = false;
                dgvRecentMembers.ReadOnly = true;
                dgvRecentMembers.AllowUserToAddRows = false;
                dgvRecentMembers.AllowUserToDeleteRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Dashboard data load failed.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetHeader(string columnName, string headerText)
        {
            if (dgvRecentMembers.Columns.Contains(columnName))
                dgvRecentMembers.Columns[columnName].HeaderText = headerText;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (currentUserRole != "Admin" &&
                currentUserRole != "Super Admin")
            {
                MessageBox.Show(
                    "You do not have permission to access Member Management.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MemberForm memberForm = new MemberForm(currentUserRole);

                this.Hide();

                memberForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                memberForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Member Management.\n\n" + ex.Message,
                    "Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            try
            {
                TrainerForm trainerForm = new TrainerForm();
                this.Hide();

                trainerForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                trainerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Trainer Management.\n\n" + ex.Message,
                    "Trainer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceForm attendanceForm = new AttendanceForm();
                this.Hide();

                attendanceForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                attendanceForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Attendance Management.\n\n" + ex.Message,
                    "Attendance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentForm paymentForm = new PaymentForm();
                this.Hide();

                paymentForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                paymentForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Payment Management.\n\n" + ex.Message,
                    "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceForm invoiceForm = new InvoiceForm();
                this.Hide();

                invoiceForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                invoiceForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Invoice Management.\n\n" + ex.Message,
                    "Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                WorkoutForm workoutForm = new WorkoutForm();
                this.Hide();

                workoutForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                workoutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Workout Management.\n\n" + ex.Message,
                    "Workout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            try
            {
                HealthForm healthForm = new HealthForm();
                this.Hide();

                healthForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                healthForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Health Management.\n\n" + ex.Message,
                    "Health Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                ReportForm reportForm = new ReportForm();
                this.Hide();

                reportForm.FormClosed += (s, args) =>
                {
                    this.Show();
                    LoadDashboardData();
                };

                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open Report Management.\n\n" + ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnReports_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void lblGymName_Click(object sender, EventArgs e)
        {
        }
    }
}
