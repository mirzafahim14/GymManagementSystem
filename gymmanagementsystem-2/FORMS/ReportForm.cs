
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class ReportForm : Form
    {
        // =========================================================
        // PRINTING VARIABLES
        // =========================================================

        private PrintDocument printDocument;
        private int printRowIndex = 0;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public ReportForm()
        {
            InitializeComponent();

            // IMPORTANT:
            // Designer.cs-এ Click event নেই,
            // তাই এখানে manually connect করছি.

            btnViewReport.Click += btnViewReport_Click;
            btnClear.Click += btnClear_Click;
            btnExport.Click += btnExport_Click;
            btnPrint.Click += btnPrint_Click;

            this.Load += ReportForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupForm();

                LoadReportTypes();

                LoadSummary();

                dgvReport.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Report form could not be loaded.\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SETUP FORM
        // =========================================================

        private void SetupForm()
        {
            dtpDateFrom.Value = DateTime.Today;
            dtpDateTo.Value = DateTime.Today;

            cmbReportType.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dgvReport.ReadOnly = true;

            dgvReport.AllowUserToAddRows = false;

            dgvReport.AllowUserToDeleteRows = false;

            dgvReport.AllowUserToResizeRows = false;

            dgvReport.MultiSelect = false;

            dgvReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReport.RowTemplate.Height = 30;

            lblMainReportTitle.Text = "REPORT DETAILS";
        }


        // =========================================================
        // LOAD REPORT TYPES
        // =========================================================

        private void LoadReportTypes()
        {
            cmbReportType.Items.Clear();

            cmbReportType.Items.Add("Members");
            cmbReportType.Items.Add("Trainers");
            cmbReportType.Items.Add("Payments");
            cmbReportType.Items.Add("Attendance");
            cmbReportType.Items.Add("Invoices");

            cmbReportType.SelectedIndex = -1;
        }


        // =========================================================
        // LOAD SUMMARY
        // =========================================================

        private void LoadSummary()
        {
            try
            {
                // -------------------------------------------------
                // TOTAL MEMBERS
                // -------------------------------------------------

                string memberQuery = @"
                    SELECT COUNT(*)
                    FROM Members";

                object memberResult =
                    DbHelper.ExecuteScalar(memberQuery);

                int totalMembers = 0;

                if (memberResult != null &&
                    memberResult != DBNull.Value)
                {
                    totalMembers =
                        Convert.ToInt32(memberResult);
                }


                // -------------------------------------------------
                // TOTAL TRAINERS
                // -------------------------------------------------

                string trainerQuery = @"
                    SELECT COUNT(*)
                    FROM Trainers";

                object trainerResult =
                    DbHelper.ExecuteScalar(trainerQuery);

                int totalTrainers = 0;

                if (trainerResult != null &&
                    trainerResult != DBNull.Value)
                {
                    totalTrainers =
                        Convert.ToInt32(trainerResult);
                }


                // -------------------------------------------------
                // TOTAL PAYMENTS
                // -------------------------------------------------

                string paymentQuery = @"
                    SELECT COUNT(*)
                    FROM Payments";

                object paymentResult =
                    DbHelper.ExecuteScalar(paymentQuery);

                int totalPayments = 0;

                if (paymentResult != null &&
                    paymentResult != DBNull.Value)
                {
                    totalPayments =
                        Convert.ToInt32(paymentResult);
                }


                // -------------------------------------------------
                // TODAY'S ATTENDANCE
                // -------------------------------------------------

                string attendanceQuery = @"
                    SELECT COUNT(*)
                    FROM Attendance
                    WHERE CAST(AttendanceDate AS DATE) = CAST(GETDATE() AS DATE)";

                object attendanceResult =
                    DbHelper.ExecuteScalar(attendanceQuery);

                int todayAttendance = 0;

                if (attendanceResult != null &&
                    attendanceResult != DBNull.Value)
                {
                    todayAttendance =
                        Convert.ToInt32(attendanceResult);
                }


                // -------------------------------------------------
                // UPDATE LABELS
                // -------------------------------------------------

                lblTotalMembers.Text =
                    "Total Members: " +
                    totalMembers;

                lblTotalTrainers.Text =
                    "Total Trainers: " +
                    totalTrainers;

                lblTotalPayments.Text =
                    "Total Payments: " +
                    totalPayments;

                lblTodayAttendance.Text =
                    "Today's Attendance: " +
                    todayAttendance;
            }
            catch
            {
                // Summary database error হলে
                // form পুরোপুরি crash করবে না.

                lblTotalMembers.Text =
                    "Total Members: 0";

                lblTotalTrainers.Text =
                    "Total Trainers: 0";

                lblTotalPayments.Text =
                    "Total Payments: 0";

                lblTodayAttendance.Text =
                    "Today's Attendance: 0";
            }
        }


        // =========================================================
        // VIEW REPORT BUTTON
        // =========================================================

        private void btnViewReport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // VALIDATION
                // -------------------------------------------------

                if (cmbReportType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a report type.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbReportType.Focus();

                    return;
                }


                DateTime dateFrom =
                    dtpDateFrom.Value.Date;

                DateTime dateTo =
                    dtpDateTo.Value.Date;


                if (dateFrom > dateTo)
                {
                    MessageBox.Show(
                        "Date From cannot be greater than Date To.",
                        "Invalid Date",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                string reportType =
                    cmbReportType.SelectedItem.ToString();


                // -------------------------------------------------
                // SELECT REPORT
                // -------------------------------------------------

                DataTable dt = null;


                switch (reportType)
                {
                    case "Members":
                        dt = GetMembersReport(
                            dateFrom,
                            dateTo
                        );
                        break;


                    case "Trainers":
                        dt = GetTrainersReport(
                            dateFrom,
                            dateTo
                        );
                        break;


                    case "Payments":
                        dt = GetPaymentsReport(
                            dateFrom,
                            dateTo
                        );
                        break;


                    case "Attendance":
                        dt = GetAttendanceReport(
                            dateFrom,
                            dateTo
                        );
                        break;


                    case "Invoices":
                        dt = GetInvoicesReport(
                            dateFrom,
                            dateTo
                        );
                        break;
                }


                // -------------------------------------------------
                // SHOW DATA
                // -------------------------------------------------

                dgvReport.DataSource = dt;


                if (dt != null)
                {
                    lblMainReportTitle.Text =
                        reportType.ToUpper() +
                        " REPORT (" +
                        dateFrom.ToString("dd-MMM-yyyy") +
                        " TO " +
                        dateTo.ToString("dd-MMM-yyyy") +
                        ")";


                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No records found for the selected date range.",
                            "Report",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not generate report.\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // MEMBERS REPORT
        // =========================================================

        private DataTable GetMembersReport(
            DateTime dateFrom,
            DateTime dateTo)
        {
            string query = @"
                SELECT
                    MemberId,
                    FullName,
                    Gender,
                    Phone,
                    Email,
                    JoinDate,
                    Status
                FROM Members
                WHERE CAST(JoinDate AS DATE)
                    BETWEEN @DateFrom AND @DateTo
                ORDER BY MemberId DESC";


            return DbHelper.ExecuteQuery(
                query,

                new SqlParameter(
                    "@DateFrom",
                    dateFrom
                ),

                new SqlParameter(
                    "@DateTo",
                    dateTo
                )
            );
        }


        // =========================================================
        // TRAINERS REPORT
        // =========================================================

        private DataTable GetTrainersReport(
            DateTime dateFrom,
            DateTime dateTo)
        { 
            string query = @"
    SELECT
        TrainerId,
        FullName,
        Gender,
        Phone,
        Email,
        Specialization,
        ExperienceYears,
        JoinDate,
        Salary,
        Status
    FROM Trainers
    WHERE JoinDate >= @DateFrom
      AND JoinDate <= @DateTo
    ORDER BY JoinDate DESC";


            return DbHelper.ExecuteQuery(
                query,

                new SqlParameter("@DateFrom", dtpDateFrom.Value.Date),

               new SqlParameter("@DateTo", dtpDateTo.Value.Date)
                
            );
        }


        // =========================================================
        // PAYMENTS REPORT
        // =========================================================

        private DataTable GetPaymentsReport(
            DateTime dateFrom,
            DateTime dateTo)
        {
            string query = @"
                SELECT
                    p.PaymentId,
                    p.MemberId,
                    m.FullName AS MemberName,
                    p.Amount,
                    p.PaymentDate,
                    p.PaymentMethod,
                    p.Status
                FROM Payments p
                LEFT JOIN Members m
                    ON p.MemberId = m.MemberId
                WHERE CAST(p.PaymentDate AS DATE)
                    BETWEEN @DateFrom AND @DateTo
                ORDER BY p.PaymentId DESC";


            return DbHelper.ExecuteQuery(
                query,

                new SqlParameter(
                    "@DateFrom",
                    dateFrom
                ),

                new SqlParameter(
                    "@DateTo",
                    dateTo
                )
            );
        }


        // =========================================================
        // ATTENDANCE REPORT
        // =========================================================

        private DataTable GetAttendanceReport(
            DateTime dateFrom,
            DateTime dateTo)
        {
            string query = @"
                SELECT
                    a.AttendanceId,
                    a.MemberId,
                    m.FullName AS MemberName,
                    a.AttendanceDate,
                    a.CheckInTime,
                    a.CheckOutTime,
                    a.Status
                FROM Attendance a
                LEFT JOIN Members m
                    ON a.MemberId = m.MemberId
                WHERE CAST(a.AttendanceDate AS DATE)
                    BETWEEN @DateFrom AND @DateTo
                ORDER BY a.AttendanceId DESC";


            return DbHelper.ExecuteQuery(
                query,

                new SqlParameter(
                    "@DateFrom",
                    dateFrom
                ),

                new SqlParameter(
                    "@DateTo",
                    dateTo
                )
            );
        }


        // =========================================================
        // INVOICES REPORT
        // =========================================================

        private DataTable GetInvoicesReport(
            DateTime dateFrom,
            DateTime dateTo)
        {
            string query = @"
                SELECT
                    i.InvoiceId,
                    i.InvoiceNumber,
                    i.MemberId,
                    m.FullName AS MemberName,
                    i.PaymentId,
                    i.InvoiceDate,
                    i.SubTotal,
                    i.Discount,
                    i.TotalAmount,
                    i.PaymentStatus
                FROM Invoices i
                LEFT JOIN Members m
                    ON i.MemberId = m.MemberId
                WHERE CAST(i.InvoiceDate AS DATE)
                    BETWEEN @DateFrom AND @DateTo
                ORDER BY i.InvoiceId DESC";


            return DbHelper.ExecuteQuery(
                query,

                new SqlParameter(
                    "@DateFrom",
                    dateFrom
                ),

                new SqlParameter(
                    "@DateTo",
                    dateTo
                )
            );
        }


        // =========================================================
        // CLEAR BUTTON
        // =========================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                dtpDateFrom.Value =
                    DateTime.Today;

                dtpDateTo.Value =
                    DateTime.Today;

                cmbReportType.SelectedIndex =
                    -1;

                dgvReport.DataSource =
                    null;

                lblMainReportTitle.Text =
                    "REPORT DETAILS";

                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not clear report.\n\n" +
                    ex.Message,
                    "Clear Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // EXPORT REPORT
        // =========================================================

        private void btnExport_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvReport.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "There is no report data to export.",
                        "Export",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                SaveFileDialog saveDialog =
                    new SaveFileDialog();

                saveDialog.Filter =
                    "CSV Files (*.csv)|*.csv";

                saveDialog.Title =
                    "Export Report";

                saveDialog.FileName =
                    "Gym_Report_" +
                    DateTime.Now.ToString(
                        "yyyyMMdd_HHmmss"
                    ) +
                    ".csv";


                if (saveDialog.ShowDialog() !=
                    DialogResult.OK)
                {
                    return;
                }


                StringBuilder csv =
                    new StringBuilder();


                // -------------------------------------------------
                // HEADERS
                // -------------------------------------------------

                for (int i = 0;
                     i < dgvReport.Columns.Count;
                     i++)
                {
                    csv.Append(
                        EscapeCsv(
                            dgvReport.Columns[i]
                                .HeaderText
                        )
                    );

                    if (i <
                        dgvReport.Columns.Count - 1)
                    {
                        csv.Append(",");
                    }
                }

                csv.AppendLine();


                // -------------------------------------------------
                // ROWS
                // -------------------------------------------------

                foreach (DataGridViewRow row
                         in dgvReport.Rows)
                {
                    if (row.IsNewRow)
                        continue;


                    for (int i = 0;
                         i < dgvReport.Columns.Count;
                         i++)
                    {
                        object value =
                            row.Cells[i].Value;

                        string text =
                            value == null
                                ? ""
                                : Convert.ToString(value);


                        csv.Append(
                            EscapeCsv(text)
                        );


                        if (i <
                            dgvReport.Columns.Count - 1)
                        {
                            csv.Append(",");
                        }
                    }

                    csv.AppendLine();
                }


                File.WriteAllText(
                    saveDialog.FileName,
                    csv.ToString(),
                    Encoding.UTF8
                );


                MessageBox.Show(
                    "Report exported successfully.\n\n" +
                    saveDialog.FileName,
                    "Export Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not export report.\n\n" +
                    ex.Message,
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CSV ESCAPE
        // =========================================================

        private string EscapeCsv(string value)
        {
            if (value == null)
                return "";


            if (value.Contains(",") ||
                value.Contains("\"") ||
                value.Contains("\n"))
            {
                value =
                    value.Replace(
                        "\"",
                        "\"\""
                    );

                return "\"" +
                       value +
                       "\"";
            }


            return value;
        }


        // =========================================================
        // PRINT REPORT
        // =========================================================

        private void btnPrint_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvReport.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "There is no report data to print.",
                        "Print",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                printDocument =
                    new PrintDocument();

                printDocument.PrintPage +=
                    PrintDocument_PrintPage;


                printRowIndex = 0;


                PrintPreviewDialog preview =
                    new PrintPreviewDialog();

                preview.Document =
                    printDocument;

                preview.Width = 1000;

                preview.Height = 700;


                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not print report.\n\n" +
                    ex.Message,
                    "Print Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // PRINT PAGE
        // =========================================================

        private void PrintDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;


                Font titleFont =
                    new Font(
                        "Segoe UI",
                        16,
                        FontStyle.Bold
                    );


                Font headerFont =
                    new Font(
                        "Segoe UI",
                        9,
                        FontStyle.Bold
                    );


                Font rowFont =
                    new Font(
                        "Segoe UI",
                        8,
                        FontStyle.Regular
                    );


                Brush brush =
                    Brushes.Black;


                float left =
                    e.MarginBounds.Left;

                float top =
                    e.MarginBounds.Top;


                // -------------------------------------------------
                // TITLE
                // -------------------------------------------------

                string title =
                    lblMainReportTitle.Text;


                g.DrawString(
                    "GYM MANAGEMENT SYSTEM",
                    titleFont,
                    brush,
                    left,
                    top
                );


                top += 35;


                g.DrawString(
                    title,
                    headerFont,
                    brush,
                    left,
                    top
                );


                top += 30;


                // -------------------------------------------------
                // COLUMN WIDTH
                // -------------------------------------------------

                int columnCount =
                    dgvReport.Columns.Count;


                float columnWidth =
                    e.MarginBounds.Width /
                    Math.Max(
                        columnCount,
                        1
                    );


                // -------------------------------------------------
                // HEADERS
                // -------------------------------------------------

                for (int i = 0;
                     i < columnCount;
                     i++)
                {
                    string header =
                        dgvReport.Columns[i]
                            .HeaderText;


                    RectangleF rect =
                        new RectangleF(
                            left +
                            (i * columnWidth),
                            top,
                            columnWidth,
                            25
                        );


                    g.DrawString(
                        header,
                        headerFont,
                        brush,
                        rect
                    );
                }


                top += 28;


                // -------------------------------------------------
                // ROWS
                // -------------------------------------------------

                while (
                    printRowIndex <
                    dgvReport.Rows.Count)
                {
                    DataGridViewRow row =
                        dgvReport.Rows[
                            printRowIndex
                        ];


                    if (row.IsNewRow)
                    {
                        printRowIndex++;
                        continue;
                    }


                    if (top + 25 >
                        e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;

                        return;
                    }


                    for (int i = 0;
                         i < columnCount;
                         i++)
                    {
                        object value =
                            row.Cells[i].Value;


                        string text =
                            value == null
                                ? ""
                                : Convert.ToString(
                                    value
                                );


                        RectangleF rect =
                            new RectangleF(
                                left +
                                (i * columnWidth),
                                top,
                                columnWidth,
                                25
                            );


                        g.DrawString(
                            text,
                            rowFont,
                            brush,
                            rect
                        );
                    }


                    top += 25;

                    printRowIndex++;
                }


                e.HasMorePages = false;
            }
            catch
            {
                e.HasMorePages = false;
            }
        }


        // =========================================================
        // EXISTING LABEL EVENT
        // =========================================================

        private void lblDateFrom_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}
