using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();

            // Form Load Event
            this.Load += AttendanceForm_Load;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupControls();

                LoadMembers();

                LoadStatuses();

                LoadAttendance();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Attendance form could not be loaded.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SETUP CONTROLS
        // =========================================================
        private void SetupControls()
        {
            // -----------------------------------------------------
            // Attendance Date
            // -----------------------------------------------------
            dtpAttendanceDate.Format =
                DateTimePickerFormat.Short;

            dtpAttendanceDate.Value =
                DateTime.Today;


            // -----------------------------------------------------
            // Check-In Time
            // -----------------------------------------------------
            dtpCheckInTime.Format =
                DateTimePickerFormat.Time;

            dtpCheckInTime.ShowUpDown = true;


            // -----------------------------------------------------
            // Check-Out Time
            // -----------------------------------------------------
            dtpCheckOutTime.Format =
                DateTimePickerFormat.Time;

            dtpCheckOutTime.ShowUpDown = true;


            // -----------------------------------------------------
            // Member ComboBox
            // -----------------------------------------------------
            cmbMemberId.DropDownStyle =
                ComboBoxStyle.DropDownList;


            // -----------------------------------------------------
            // Status ComboBox
            // -----------------------------------------------------
            cmbAttendanceStatus.DropDownStyle =
                ComboBoxStyle.DropDownList;


            // -----------------------------------------------------
            // DataGridView
            // -----------------------------------------------------
            dgvAttendance.ReadOnly = true;

            dgvAttendance.AllowUserToAddRows = false;

            dgvAttendance.AllowUserToDeleteRows = false;

            dgvAttendance.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAttendance.MultiSelect = false;

            dgvAttendance.AutoGenerateColumns = true;

            dgvAttendance.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAttendance.RowHeadersVisible = true;

            dgvAttendance.AllowUserToResizeRows = false;
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
                        MemberId,
                        FullName
                    FROM Members
                    ORDER BY MemberId ASC";


                DataTable dt =
                    DbHelper.ExecuteQuery(query);


                cmbMemberId.DataSource = dt;

                cmbMemberId.DisplayMember =
                    "FullName";

                cmbMemberId.ValueMember =
                    "MemberId";

                cmbMemberId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load members.\n\n" +
                    ex.Message,
                    "Member Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LOAD STATUS
        // =========================================================
        private void LoadStatuses()
        {
            cmbAttendanceStatus.Items.Clear();

            cmbAttendanceStatus.Items.Add("Present");

            cmbAttendanceStatus.Items.Add("Absent");

            cmbAttendanceStatus.Items.Add("Late");

            cmbAttendanceStatus.SelectedIndex = -1;
        }


        // =========================================================
        // LOAD ATTENDANCE
        // =========================================================
        private void LoadAttendance()
        {
            try
            {
                string query = @"
                    SELECT
                        A.AttendanceId,
                        A.MemberId,
                        M.FullName AS MemberName,
                        A.AttendanceDate,
                        A.CheckInTime,
                        A.CheckOutTime,
                        A.Status,
                        A.Notes
                    FROM Attendance A
                    INNER JOIN Members M
                        ON A.MemberId = M.MemberId
                    ORDER BY A.AttendanceId DESC";


                DataTable dt =
                    DbHelper.ExecuteQuery(query);


                dgvAttendance.DataSource = null;

                dgvAttendance.DataSource = dt;


                SetGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load attendance records.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SET GRID HEADERS
        // =========================================================
        private void SetGridHeaders()
        {
            if (dgvAttendance.Columns.Contains("AttendanceId"))
            {
                dgvAttendance.Columns["AttendanceId"]
                    .HeaderText =
                    "Attendance ID";
            }


            if (dgvAttendance.Columns.Contains("MemberId"))
            {
                dgvAttendance.Columns["MemberId"]
                    .HeaderText =
                    "Member ID";
            }


            if (dgvAttendance.Columns.Contains("MemberName"))
            {
                dgvAttendance.Columns["MemberName"]
                    .HeaderText =
                    "Member Name";
            }


            if (dgvAttendance.Columns.Contains("AttendanceDate"))
            {
                dgvAttendance.Columns["AttendanceDate"]
                    .HeaderText =
                    "Attendance Date";

                dgvAttendance.Columns["AttendanceDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }


            if (dgvAttendance.Columns.Contains("CheckInTime"))
            {
                dgvAttendance.Columns["CheckInTime"]
                    .HeaderText =
                    "Check-In Time";
            }


            if (dgvAttendance.Columns.Contains("CheckOutTime"))
            {
                dgvAttendance.Columns["CheckOutTime"]
                    .HeaderText =
                    "Check-Out Time";
            }


            if (dgvAttendance.Columns.Contains("Status"))
            {
                dgvAttendance.Columns["Status"]
                    .HeaderText =
                    "Status";
            }


            if (dgvAttendance.Columns.Contains("Notes"))
            {
                dgvAttendance.Columns["Notes"]
                    .HeaderText =
                    "Notes";
            }


            dgvAttendance.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


        // =========================================================
        // SAVE ATTENDANCE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // VALIDATION
                // -------------------------------------------------
                if (!ValidateAttendanceInput())
                    return;


                // -------------------------------------------------
                // GET FORM VALUES
                // -------------------------------------------------
                int memberId =
                    Convert.ToInt32(
                        cmbMemberId.SelectedValue);


                DateTime attendanceDate =
                    dtpAttendanceDate.Value.Date;


                TimeSpan checkInTime =
                    dtpCheckInTime.Value.TimeOfDay;


                TimeSpan checkOutTime =
                    dtpCheckOutTime.Value.TimeOfDay;


                string status =
                    cmbAttendanceStatus.Text.Trim();


                // -------------------------------------------------
                // CHECK DUPLICATE
                // One member = one attendance per day
                // -------------------------------------------------
                string duplicateQuery = @"
                    SELECT COUNT(*)
                    FROM Attendance
                    WHERE MemberId = @MemberId
                    AND AttendanceDate = @AttendanceDate";


                object duplicateResult =
                    DbHelper.ExecuteScalar(
                        duplicateQuery,

                        new SqlParameter(
                            "@MemberId",
                            memberId
                        ),

                        new SqlParameter(
                            "@AttendanceDate",
                            attendanceDate
                        )
                    );


                int duplicateCount =
                    Convert.ToInt32(
                        duplicateResult);


                if (duplicateCount > 0)
                {
                    MessageBox.Show(
                        "Attendance for this member on this date already exists.",
                        "Duplicate Attendance",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -------------------------------------------------
                // CHECK-IN / CHECK-OUT VALUES
                // -------------------------------------------------
                object checkInValue =
                    DBNull.Value;

                object checkOutValue =
                    DBNull.Value;


                // Absent হলে time save হবে না
                if (status != "Absent")
                {
                    checkInValue =
                        checkInTime;

                    checkOutValue =
                        checkOutTime;
                }


                // -------------------------------------------------
                // INSERT ATTENDANCE
                // -------------------------------------------------
                string query = @"
                    INSERT INTO Attendance
                    (
                        MemberId,
                        AttendanceDate,
                        CheckInTime,
                        CheckOutTime,
                        Status,
                        Notes
                    )
                    VALUES
                    (
                        @MemberId,
                        @AttendanceDate,
                        @CheckInTime,
                        @CheckOutTime,
                        @Status,
                        @Notes
                    )";


                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            memberId
                        ),

                        new SqlParameter(
                            "@AttendanceDate",
                            attendanceDate
                        ),

                        new SqlParameter(
                            "@CheckInTime",
                            checkInValue
                        ),

                        new SqlParameter(
                            "@CheckOutTime",
                            checkOutValue
                        ),

                        new SqlParameter(
                            "@Status",
                            status
                        ),

                        new SqlParameter(
                            "@Notes",
                            DBNull.Value
                        )
                    );


                // -------------------------------------------------
                // SUCCESS
                // -------------------------------------------------
                if (result > 0)
                {
                    MessageBox.Show(
                        "Attendance saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );


                    // Refresh Grid
                    LoadAttendance();


                    // Clear Input
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Attendance could not be saved.",
                        "Save",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save attendance.\n\n" +
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // VALIDATION
        // =========================================================
        private bool ValidateAttendanceInput()
        {
            // -----------------------------------------------------
            // MEMBER
            // -----------------------------------------------------
            if (cmbMemberId.SelectedIndex == -1 ||
                cmbMemberId.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a member.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbMemberId.Focus();

                return false;
            }


            // -----------------------------------------------------
            // STATUS
            // -----------------------------------------------------
            if (cmbAttendanceStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select attendance status.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbAttendanceStatus.Focus();

                return false;
            }


            // -----------------------------------------------------
            // TIME VALIDATION
            // -----------------------------------------------------
            if (cmbAttendanceStatus.Text != "Absent")
            {
                if (dtpCheckOutTime.Value.TimeOfDay <
                    dtpCheckInTime.Value.TimeOfDay)
                {
                    MessageBox.Show(
                        "Check-out time cannot be earlier than check-in time.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    dtpCheckOutTime.Focus();

                    return false;
                }
            }


            return true;
        }


        // =========================================================
        // SEARCH ATTENDANCE
        // =========================================================
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                string search =
                    txtSearch.Text.Trim();


                string query = @"
                    SELECT
                        A.AttendanceId,
                        A.MemberId,
                        M.FullName AS MemberName,
                        A.AttendanceDate,
                        A.CheckInTime,
                        A.CheckOutTime,
                        A.Status,
                        A.Notes
                    FROM Attendance A
                    INNER JOIN Members M
                        ON A.MemberId = M.MemberId
                    WHERE
                        CAST(A.AttendanceId AS NVARCHAR(50))
                            LIKE @Search
                        OR
                        CAST(A.MemberId AS NVARCHAR(50))
                            LIKE @Search
                        OR
                        M.FullName LIKE @Search
                        OR
                        A.Status LIKE @Search
                        OR
                        CONVERT(
                            NVARCHAR(10),
                            A.AttendanceDate,
                            23
                        ) LIKE @Search
                    ORDER BY A.AttendanceId DESC";


                DataTable dt =
                    DbHelper.ExecuteQuery(
                        query,

                        new SqlParameter(
                            "@Search",
                            "%" + search + "%"
                        )
                    );


                dgvAttendance.DataSource = null;

                dgvAttendance.DataSource = dt;


                SetGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" +
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // GRID ROW CLICK
        // =========================================================
        private void dgvAttendance_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;


                DataGridViewRow row =
                    dgvAttendance.Rows[e.RowIndex];


                // -------------------------------------------------
                // MEMBER ID
                // -------------------------------------------------
                if (dgvAttendance.Columns.Contains("MemberId"))
                {
                    object memberValue =
                        row.Cells["MemberId"].Value;


                    if (memberValue != null &&
                        memberValue != DBNull.Value)
                    {
                        int memberId =
                            Convert.ToInt32(
                                memberValue);


                        cmbMemberId.SelectedValue =
                            memberId;
                    }
                }


                // -------------------------------------------------
                // ATTENDANCE DATE
                // -------------------------------------------------
                if (dgvAttendance.Columns.Contains(
                    "AttendanceDate"))
                {
                    object dateValue =
                        row.Cells[
                            "AttendanceDate"
                        ].Value;


                    if (dateValue != null &&
                        dateValue != DBNull.Value)
                    {
                        dtpAttendanceDate.Value =
                            Convert.ToDateTime(
                                dateValue);
                    }
                }


                // -------------------------------------------------
                // CHECK-IN TIME
                // -------------------------------------------------
                if (dgvAttendance.Columns.Contains(
                    "CheckInTime"))
                {
                    object checkInValue =
                        row.Cells[
                            "CheckInTime"
                        ].Value;


                    if (checkInValue != null &&
                        checkInValue != DBNull.Value)
                    {
                        TimeSpan checkIn;


                        if (checkInValue is TimeSpan)
                        {
                            checkIn =
                                (TimeSpan)checkInValue;
                        }
                        else
                        {
                            checkIn =
                                TimeSpan.Parse(
                                    checkInValue.ToString()
                                );
                        }


                        dtpCheckInTime.Value =
                            DateTime.Today.Add(
                                checkIn);
                    }
                }


                // -------------------------------------------------
                // CHECK-OUT TIME
                // -------------------------------------------------
                if (dgvAttendance.Columns.Contains(
                    "CheckOutTime"))
                {
                    object checkOutValue =
                        row.Cells[
                            "CheckOutTime"
                        ].Value;


                    if (checkOutValue != null &&
                        checkOutValue != DBNull.Value)
                    {
                        TimeSpan checkOut;


                        if (checkOutValue is TimeSpan)
                        {
                            checkOut =
                                (TimeSpan)checkOutValue;
                        }
                        else
                        {
                            checkOut =
                                TimeSpan.Parse(
                                    checkOutValue.ToString()
                                );
                        }


                        dtpCheckOutTime.Value =
                            DateTime.Today.Add(
                                checkOut);
                    }
                }


                // -------------------------------------------------
                // STATUS
                // -------------------------------------------------
                if (dgvAttendance.Columns.Contains(
                    "Status"))
                {
                    object statusValue =
                        row.Cells[
                            "Status"
                        ].Value;


                    if (statusValue != null &&
                        statusValue != DBNull.Value)
                    {
                        string status =
                            Convert.ToString(
                                statusValue);


                        cmbAttendanceStatus
                            .SelectedItem =
                            status;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not select attendance record.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CLEAR FIELDS
        // =========================================================
        private void ClearFields()
        {
            cmbMemberId.SelectedIndex = -1;

            cmbAttendanceStatus.SelectedIndex = -1;

            dtpAttendanceDate.Value =
                DateTime.Today;

            dtpCheckInTime.Value =
                DateTime.Now;

            dtpCheckOutTime.Value =
                DateTime.Now;
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
        // OPTIONAL EVENTS
        // =========================================================

        private void lblAttendanceManagement_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblMemberId_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblAttendanceDate_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblCheckInTime_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblCheckOutTime_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblStatus_Click(
            object sender,
            EventArgs e)
        {
        }


        private void cmbMemberId_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void dtpAttendanceDate_ValueChanged(
            object sender,
            EventArgs e)
        {
        }


        private void dtpCheckInTime_ValueChanged(
            object sender,
            EventArgs e)
        {
        }


        private void dtpCheckOutTime_ValueChanged(
            object sender,
            EventArgs e)
        {
        }


        private void cmbStatus_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void pnlAttendanceSearch_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}