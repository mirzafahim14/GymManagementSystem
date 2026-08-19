using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberAttendanceForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================
        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberAttendanceForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            // Form Load
            this.Load += MemberAttendanceForm_Load;

            // Close button
            btnClose.Click += btnClose_Click;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberAttendanceForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblMemberId.Text = "Member ID: " + _memberId;

                LoadMemberInformation();
                LoadAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load attendance information.\n\n" +
                    ex.Message,
                    "Attendance Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LOAD MEMBER INFORMATION
        // =========================================================
        private void LoadMemberInformation()
        {
            string query = @"
                SELECT
                    MemberId,
                    FullName
                FROM Members
                WHERE MemberId = @MemberId;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );

            if (table.Rows.Count == 0)
            {
                lblMemberName.Text = "Member Name: —";

                MessageBox.Show(
                    "Member information was not found.",
                    "Member Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataRow row = table.Rows[0];

            lblMemberName.Text =
                "Member Name: " + GetString(row["FullName"]);
        }


        // =========================================================
        // LOAD ATTENDANCE
        // =========================================================
        private void LoadAttendance()
        {
            string query = @"
                SELECT
                    AttendanceDate,
                    CheckInTime,
                    CheckOutTime
                FROM Attendance
                WHERE MemberId = @MemberId
                ORDER BY AttendanceDate DESC;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );

            // =====================================================
            // DISPLAY DATA
            // =====================================================

            dgvAttendance.DataSource = table;

            // =====================================================
            // CHANGE COLUMN HEADERS
            // =====================================================

            if (dgvAttendance.Columns.Contains("AttendanceDate"))
            {
                dgvAttendance.Columns["AttendanceDate"].HeaderText =
                    "Date";
            }

            if (dgvAttendance.Columns.Contains("CheckInTime"))
            {
                dgvAttendance.Columns["CheckInTime"].HeaderText =
                    "Check In";
            }

            if (dgvAttendance.Columns.Contains("CheckOutTime"))
            {
                dgvAttendance.Columns["CheckOutTime"].HeaderText =
                    "Check Out";
            }

            // =====================================================
            // FORMAT COLUMNS
            // =====================================================

            if (dgvAttendance.Columns.Contains("AttendanceDate"))
            {
                dgvAttendance.Columns["AttendanceDate"].DefaultCellStyle.Format =
                    "dd MMM yyyy";
            }

            if (dgvAttendance.Columns.Contains("CheckInTime"))
            {
                dgvAttendance.Columns["CheckInTime"].DefaultCellStyle.Format =
                    "hh:mm tt";
            }

            if (dgvAttendance.Columns.Contains("CheckOutTime"))
            {
                dgvAttendance.Columns["CheckOutTime"].DefaultCellStyle.Format =
                    "hh:mm tt";
            }

            // =====================================================
            // SUMMARY
            // =====================================================

            int totalAttendance = table.Rows.Count;

            lblTotalDays.Text =
                "Total Attendance: " + totalAttendance;

            // Since Attendance table contains attendance records,
            // each record represents a recorded presence.
            lblPresentDays.Text =
                "Present: " + totalAttendance;

            // We cannot calculate true absent days without knowing
            // the expected attendance date range.
            lblAbsentDays.Text =
                "Absent: N/A";
        }


        // =========================================================
        // REFRESH BUTTON
        // =========================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadAttendance();

                MessageBox.Show(
                    "Attendance information refreshed successfully.",
                    "Refresh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to refresh attendance.\n\n" +
                    ex.Message,
                    "Refresh Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CLOSE BUTTON
        // =========================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // =========================================================
        // SAFE STRING CONVERSION
        // =========================================================
        private string GetString(object value)
        {
            if (value == null || value == DBNull.Value)
                return "—";

            string text = value.ToString();

            if (string.IsNullOrWhiteSpace(text))
                return "—";

            return text;
        }
    }
}