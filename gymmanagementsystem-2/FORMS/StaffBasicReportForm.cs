using System;
using System.Data;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffBasicReportForm : Form
    {
        public StaffBasicReportForm()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void StaffBasicReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbReportType.Items.Clear();

                cmbReportType.Items.Add("Member Report");
                cmbReportType.Items.Add("Attendance Report");
                cmbReportType.Items.Add("Payment Report");
                cmbReportType.Items.Add("Invoice Report");
                cmbReportType.Items.Add("Trainer Report");
                cmbReportType.Items.Add("Workout Report");
                cmbReportType.Items.Add("Health Report");

                cmbReportType.SelectedIndex = -1;

                dtpFrom.Value = DateTime.Today.AddMonths(-1);
                dtpTo.Value = DateTime.Today;

                dgvReport.ReadOnly = true;
                dgvReport.AllowUserToAddRows = false;
                dgvReport.AllowUserToDeleteRows = false;
                dgvReport.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvReport.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load Basic Report.\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // GENERATE REPORT
        // =========================================================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReportType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a report type.",
                        "Report",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbReportType.Focus();
                    return;
                }

                if (dtpFrom.Value.Date > dtpTo.Value.Date)
                {
                    MessageBox.Show(
                        "From date cannot be greater than To date.",
                        "Invalid Date",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string reportType = cmbReportType.Text;

                switch (reportType)
                {
                    case "Member Report":
                        LoadMemberReport();
                        break;

                    case "Attendance Report":
                        LoadAttendanceReport();
                        break;

                    case "Payment Report":
                        LoadPaymentReport();
                        break;

                    case "Invoice Report":
                        LoadInvoiceReport();
                        break;

                    case "Trainer Report":
                        LoadTrainerReport();
                        break;

                    case "Workout Report":
                        LoadWorkoutReport();
                        break;

                    case "Health Report":
                        LoadHealthReport();
                        break;

                    default:
                        MessageBox.Show(
                            "Invalid report type.",
                            "Report",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate report.\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // MEMBER REPORT
        // =========================================================
        private void LoadMemberReport()
        {
            string query = @"
                SELECT
                    m.MemberId,
                    m.FullName,
                    m.Gender,
                    m.Phone,
                    m.Email,
                    p.PlanName AS MembershipPlan,
                    m.JoinDate,
                    m.MembershipEndDate,
                    m.Status
                FROM Members m
                LEFT JOIN MembershipPlans p
                    ON m.PlanId = p.PlanId
                WHERE m.JoinDate BETWEEN @FromDate AND @ToDate
                ORDER BY m.MemberId DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(
                query,
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@FromDate", dtpFrom.Value.Date),
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@ToDate", dtpTo.Value.Date));

            ShowReport(dt);
        }

        // =========================================================
        // ATTENDANCE REPORT
        // =========================================================
        private void LoadAttendanceReport()
        {
            string query = @"
                SELECT
                    a.AttendanceId,
                    m.FullName AS MemberName,
                    a.AttendanceDate,
                    a.CheckInTime,
                    a.CheckOutTime
                FROM Attendance a
                INNER JOIN Members m
                    ON a.MemberId = m.MemberId
                WHERE a.AttendanceDate BETWEEN @FromDate AND @ToDate
                ORDER BY a.AttendanceDate DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(
                query,
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@FromDate", dtpFrom.Value.Date),
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@ToDate", dtpTo.Value.Date));

            ShowReport(dt);
        }

        // =========================================================
        // PAYMENT REPORT
        // =========================================================
        private void LoadPaymentReport()
        {
            string query = @"
                SELECT
                    p.PaymentId,
                    m.FullName AS MemberName,
                    p.Amount,
                    p.PaymentDate,
                    p.PaymentMethod,
                    p.Status
                FROM Payments p
                INNER JOIN Members m
                    ON p.MemberId = m.MemberId
                WHERE p.PaymentDate BETWEEN @FromDate AND @ToDate
                ORDER BY p.PaymentDate DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(
                query,
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@FromDate", dtpFrom.Value.Date),
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@ToDate", dtpTo.Value.Date));

            ShowReport(dt);
        }

        // =========================================================
        // INVOICE REPORT
        // =========================================================
        private void LoadInvoiceReport()
        {
            string query = @"
                SELECT
                    i.InvoiceId,
                    m.FullName AS MemberName,
                    i.InvoiceDate,
                    i.TotalAmount,
                    i.Status
                FROM Invoices i
                INNER JOIN Members m
                    ON i.MemberId = m.MemberId
                WHERE i.InvoiceDate BETWEEN @FromDate AND @ToDate
                ORDER BY i.InvoiceDate DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(
                query,
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@FromDate", dtpFrom.Value.Date),
                new Microsoft.Data.SqlClient.SqlParameter(
                    "@ToDate", dtpTo.Value.Date));

            ShowReport(dt);
        }

        // =========================================================
        // TRAINER REPORT
        // =========================================================
        private void LoadTrainerReport()
        {
            string query = @"
                SELECT
                    TrainerId,
                    FullName,
                    Gender,
                    Phone,
                    Email,
                    Specialization,
                    Status
                FROM Trainers
                ORDER BY TrainerId DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(query);

            ShowReport(dt);
        }

        // =========================================================
        // WORKOUT REPORT
        // =========================================================
        private void LoadWorkoutReport()
        {
            string query = @"
                SELECT
                    w.WorkoutPlanId,
                    m.FullName AS MemberName,
                    w.PlanName,
                    w.Goal,
                    w.StartDate,
                    w.EndDate,
                    w.Status
                FROM WorkoutPlans w
                INNER JOIN Members m
                    ON w.MemberId = m.MemberId
                ORDER BY w.WorkoutPlanId DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(query);

            ShowReport(dt);
        }

        // =========================================================
        // HEALTH REPORT
        // =========================================================
        private void LoadHealthReport()
        {
            string query = @"
                SELECT
                    h.HealthRecordId,
                    m.FullName AS MemberName,
                    h.Height,
                    h.Weight,
                    h.BMI,
                    h.BloodPressure,
                    h.MedicalCondition,
                    h.RecordDate
                FROM HealthRecords h
                INNER JOIN Members m
                    ON h.MemberId = m.MemberId
                ORDER BY h.RecordDate DESC;
            ";

            DataTable dt = DbHelper.ExecuteQuery(query);

            ShowReport(dt);
        }

        // =========================================================
        // SHOW REPORT
        // =========================================================
        private void ShowReport(DataTable dt)
        {
            dgvReport.DataSource = null;
            dgvReport.DataSource = dt;

            lblTotalRecords.Text =
                "Total Records: " + dt.Rows.Count;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No records found for the selected report.",
                    "Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // =========================================================
        // REFRESH
        // =========================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            lblTotalRecords.Text = "Total Records: 0";

            cmbReportType.SelectedIndex = -1;

            dtpFrom.Value =
                DateTime.Today.AddMonths(-1);

            dtpTo.Value =
                DateTime.Today;
        }

        // =========================================================
        // CLOSE
        // =========================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================================================
        // EMPTY EVENTS
        // =========================================================
        private void cmbReportType_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void dtpFrom_ValueChanged(
            object sender,
            EventArgs e)
        {
        }

        private void dtpTo_ValueChanged(
            object sender,
            EventArgs e)
        {
        }

        private void dgvReport_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}