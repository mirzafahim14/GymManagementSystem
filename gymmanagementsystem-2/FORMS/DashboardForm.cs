using GymManagementSystem.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Dashboard open হলে data load হবে
            this.Load += DashboardForm_Load;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        // =========================================================
        // LOAD DASHBOARD DATA
        // =========================================================
        private void LoadDashboardData()
        {
            try
            {
                // =================================================
                // 1. TOTAL MEMBERS
                // =================================================
                object memberResult =
                    DbHelper.ExecuteScalar(
                        "SELECT COUNT(*) FROM Members"
                    );

                lblTotalMembers.Text =
                    Convert.ToString(memberResult);


                // =================================================
                // 2. TOTAL TRAINERS
                // =================================================
                object trainerResult =
                    DbHelper.ExecuteScalar(
                        "SELECT COUNT(*) FROM Trainers"
                    );

                lblTotalTrainers.Text =
                    Convert.ToString(trainerResult);


                // =================================================
                // 3. TODAY'S ATTENDANCE
                // =================================================
                object attendanceResult =
                    DbHelper.ExecuteScalar(
                        @"
                        SELECT COUNT(*)
                        FROM Attendance
                        WHERE AttendanceDate =
                              CAST(GETDATE() AS DATE)"
                    );

                lblAttendanceToday.Text =
                    Convert.ToString(attendanceResult);


                // =================================================
                // 4. TOTAL PAYMENT
                // =================================================
                object paymentResult =
                    DbHelper.ExecuteScalar(
                        @"
                        SELECT COALESCE(SUM(Amount), 0)
                        FROM Payments"
                    );

                decimal totalPayment =
                    Convert.ToDecimal(paymentResult);

                // IMPORTANT:
                // বড় label = Payment
                // ভিতরের value label = IblTotalPayment
                IblTotalPayment.Text =
                    totalPayment.ToString("0.00");


                // =================================================
                // 5. RECENT MEMBERS
                // =================================================
                string query = @"
                    SELECT TOP 10
                        MemberId,
                        FullName,
                        Gender,
                        DateOfBirth,
                        Phone,
                        Email,
                        Address,
                        JoinDate,
                        PlanId,
                        ExpiryDate,
                        Status
                    FROM Members
                    ORDER BY MemberId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvRecentMembers.DataSource = dt;


                // =================================================
                // 6. DATAGRIDVIEW SETTINGS
                // =================================================

                if (dgvRecentMembers.Columns.Contains("MemberId"))
                {
                    dgvRecentMembers.Columns["MemberId"]
                        .HeaderText = "Member ID";
                }

                if (dgvRecentMembers.Columns.Contains("FullName"))
                {
                    dgvRecentMembers.Columns["FullName"]
                        .HeaderText = "Member Name";
                }

                if (dgvRecentMembers.Columns.Contains("Gender"))
                {
                    dgvRecentMembers.Columns["Gender"]
                        .HeaderText = "Gender";
                }

                if (dgvRecentMembers.Columns.Contains("DateOfBirth"))
                {
                    dgvRecentMembers.Columns["DateOfBirth"]
                        .HeaderText = "Date of Birth";

                    dgvRecentMembers.Columns["DateOfBirth"]
                        .DefaultCellStyle.Format =
                        "dd-MMM-yyyy";
                }

                if (dgvRecentMembers.Columns.Contains("Phone"))
                {
                    dgvRecentMembers.Columns["Phone"]
                        .HeaderText = "Phone";
                }

                if (dgvRecentMembers.Columns.Contains("Email"))
                {
                    dgvRecentMembers.Columns["Email"]
                        .HeaderText = "Email";
                }

                if (dgvRecentMembers.Columns.Contains("Address"))
                {
                    dgvRecentMembers.Columns["Address"]
                        .HeaderText = "Address";
                }

                if (dgvRecentMembers.Columns.Contains("JoinDate"))
                {
                    dgvRecentMembers.Columns["JoinDate"]
                        .HeaderText = "Join Date";

                    dgvRecentMembers.Columns["JoinDate"]
                        .DefaultCellStyle.Format =
                        "dd-MMM-yyyy";
                }

                if (dgvRecentMembers.Columns.Contains("PlanId"))
                {
                    dgvRecentMembers.Columns["PlanId"]
                        .HeaderText = "Membership Plan";
                }

                if (dgvRecentMembers.Columns.Contains("ExpiryDate"))
                {
                    dgvRecentMembers.Columns["ExpiryDate"]
                        .HeaderText = "Expiry Date";

                    dgvRecentMembers.Columns["ExpiryDate"]
                        .DefaultCellStyle.Format =
                        "dd-MMM-yyyy";
                }

                if (dgvRecentMembers.Columns.Contains("Status"))
                {
                    dgvRecentMembers.Columns["Status"]
                        .HeaderText = "Status";
                }


                // =================================================
                // GRID SETTINGS
                // =================================================

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
                    "Dashboard data load failed.\n\n" +
                    ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // GYM NAME
        // =========================================================
        private void lblGymName_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================================
        // MEMBERS
        // =========================================================
        private void btnMembers_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                MemberForm memberForm =
                    new MemberForm();

                this.Hide();

                memberForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();
                        LoadDashboardData();
                    };

                memberForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Member Management.\n\n" +
                    ex.Message,
                    "Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // TRAINERS
        // =========================================================
        private void btnTrainers_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                TrainerForm trainerForm =
                    new TrainerForm();

                this.Hide();

                trainerForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();
                        LoadDashboardData();
                    };

                trainerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Trainer Management.\n\n" +
                    ex.Message,
                    "Trainer Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // ATTENDANCE
        // =========================================================
        private void btnAttendance_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                AttendanceForm attendanceForm =
                    new AttendanceForm();

                this.Hide();

                attendanceForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();

                        // Attendance save হওয়ার পর
                        // dashboard count refresh হবে
                        LoadDashboardData();
                    };

                attendanceForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Attendance Management.\n\n" +
                    ex.Message,
                    "Attendance Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // PAYMENT
        // =========================================================
        private void btnPayment_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                PaymentForm paymentForm =
                    new PaymentForm();

                this.Hide();

                paymentForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();

                        // Payment save/update/delete হওয়ার পর
                        // Dashboard total payment refresh হবে
                        LoadDashboardData();
                    };

                paymentForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Payment Management.\n\n" +
                    ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // INVOICE
        // =========================================================
        private void btnInvoice_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                InvoiceForm invoiceForm =
                    new InvoiceForm();

                this.Hide();

                invoiceForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();

                        // Invoice form বন্ধ হওয়ার পর
                        // Dashboard refresh হবে
                        LoadDashboardData();
                    };

                invoiceForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Invoice Management.\n\n" +
                    ex.Message,
                    "Invoice Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // WORKOUT
        // =========================================================
        private void btnWorkout_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                WorkoutForm workoutForm =
                    new WorkoutForm();

                this.Hide();

                workoutForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();
                        LoadDashboardData();
                    };

                workoutForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Workout Management.\n\n" +
                    ex.Message,
                    "Workout Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // HEALTH
        // =========================================================
        private void btnHealth_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                HealthForm healthForm =
                    new HealthForm();

                this.Hide();

                healthForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();
                        LoadDashboardData();
                    };

                healthForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Health Management.\n\n" +
                    ex.Message,
                    "Health Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // REPORTS
        // =========================================================
        private void btnReports_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                ReportForm reportForm =
                    new ReportForm();

                this.Hide();

                reportForm.FormClosed +=
                    (s, args) =>
                    {
                        this.Show();
                        LoadDashboardData();
                    };

                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open Report Management.\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // REPORT BUTTON
        // =========================================================
        // তোমার Designer-এ যদি btnReport থাকে,
        // সেটাকে btnReports-এর সাথে connect করা যাবে।
        private void btnReport_Click(
            object sender,
            EventArgs e)
        {
            btnReports_Click(sender, e);
        }


        // =========================================================
        // LOGOUT
        // =========================================================
        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                this.Hide();
            }
        }
    }
}