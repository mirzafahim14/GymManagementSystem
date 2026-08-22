using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffHealthForm : Form
    {
        private readonly string _staffName;
        private readonly string _staffRole;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public StaffHealthForm(string staffName, string staffRole)
        {
            InitializeComponent();

            _staffName = staffName;
            _staffRole = staffRole;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffHealthForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = "HEALTH RECORDS";

                lblStaffInfo.Text =
                    "Staff: " + _staffName +
                    " | Role: " + _staffRole;

                LoadHealthRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load Health Records.\n\n" +
                    ex.Message,
                    "Health Records",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD HEALTH RECORDS
        // =========================================================

        private void LoadHealthRecords()
        {
            try
            {
                string searchText =
                    txtSearch.Text.Trim();

                string query = @"
                    SELECT
                        h.HealthRecordId,
                        h.MemberId,
                        m.FullName AS MemberName,
                        h.RecordDate,
                        h.HeightCm,
                        h.WeightKg,
                        h.BloodGroup,
                        h.BMI,
                        h.MedicalConditions,
                        h.Allergies,
                        h.EmergencyContact,
                        h.EmergencyPhone,
                        h.Notes,
                        h.CreatedAt
                    FROM HealthRecords h
                    INNER JOIN Members m
                        ON h.MemberId = m.MemberId
                    WHERE
                        m.FullName LIKE @Search
                        OR CAST(h.MemberId AS NVARCHAR(50))
                            LIKE @Search
                    ORDER BY
                        h.HealthRecordId DESC;
                ";

                SqlParameter[] parameters =
                {
                    new SqlParameter(
                        "@Search",
                        "%" + searchText + "%"
                    )
                };

                DataTable dt =
                    DbHelper.ExecuteQuery(
                        query,
                        parameters
                    );

                dgvHealthRecords.DataSource = dt;

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load health records.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // CONFIGURE GRID
        // =========================================================

        private void ConfigureGrid()
        {
            dgvHealthRecords.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHealthRecords.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHealthRecords.MultiSelect = false;

            dgvHealthRecords.ReadOnly = true;

            dgvHealthRecords.AllowUserToAddRows = false;

            dgvHealthRecords.AllowUserToDeleteRows = false;

            dgvHealthRecords.AllowUserToResizeRows = false;

            dgvHealthRecords.RowHeadersVisible = false;

            // -----------------------------------------------------
            // HEADERS
            // -----------------------------------------------------

            if (dgvHealthRecords.Columns.Contains(
                "HealthRecordId"))
            {
                dgvHealthRecords.Columns[
                    "HealthRecordId"
                ].HeaderText = "Record ID";
            }

            if (dgvHealthRecords.Columns.Contains(
                "MemberId"))
            {
                dgvHealthRecords.Columns[
                    "MemberId"
                ].HeaderText = "Member ID";
            }

            if (dgvHealthRecords.Columns.Contains(
                "MemberName"))
            {
                dgvHealthRecords.Columns[
                    "MemberName"
                ].HeaderText = "Member Name";
            }

            if (dgvHealthRecords.Columns.Contains(
                "RecordDate"))
            {
                dgvHealthRecords.Columns[
                    "RecordDate"
                ].HeaderText = "Record Date";

                dgvHealthRecords.Columns[
                    "RecordDate"
                ].DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }

            if (dgvHealthRecords.Columns.Contains(
                "HeightCm"))
            {
                dgvHealthRecords.Columns[
                    "HeightCm"
                ].HeaderText = "Height (cm)";
            }

            if (dgvHealthRecords.Columns.Contains(
                "WeightKg"))
            {
                dgvHealthRecords.Columns[
                    "WeightKg"
                ].HeaderText = "Weight (kg)";
            }

            if (dgvHealthRecords.Columns.Contains(
                "BloodGroup"))
            {
                dgvHealthRecords.Columns[
                    "BloodGroup"
                ].HeaderText = "Blood Group";
            }

            if (dgvHealthRecords.Columns.Contains(
                "BMI"))
            {
                dgvHealthRecords.Columns[
                    "BMI"
                ].HeaderText = "BMI";

                dgvHealthRecords.Columns[
                    "BMI"
                ].DefaultCellStyle.Format =
                    "0.00";
            }

            if (dgvHealthRecords.Columns.Contains(
                "MedicalConditions"))
            {
                dgvHealthRecords.Columns[
                    "MedicalConditions"
                ].HeaderText =
                    "Medical Conditions";
            }

            if (dgvHealthRecords.Columns.Contains(
                "Allergies"))
            {
                dgvHealthRecords.Columns[
                    "Allergies"
                ].HeaderText = "Allergies";
            }

            if (dgvHealthRecords.Columns.Contains(
                "EmergencyContact"))
            {
                dgvHealthRecords.Columns[
                    "EmergencyContact"
                ].HeaderText =
                    "Emergency Contact";
            }

            if (dgvHealthRecords.Columns.Contains(
                "EmergencyPhone"))
            {
                dgvHealthRecords.Columns[
                    "EmergencyPhone"
                ].HeaderText =
                    "Emergency Phone";
            }

            if (dgvHealthRecords.Columns.Contains(
                "Notes"))
            {
                dgvHealthRecords.Columns[
                    "Notes"
                ].HeaderText = "Notes";
            }

            if (dgvHealthRecords.Columns.Contains(
                "CreatedAt"))
            {
                dgvHealthRecords.Columns[
                    "CreatedAt"
                ].HeaderText = "Created At";

                dgvHealthRecords.Columns[
                    "CreatedAt"
                ].DefaultCellStyle.Format =
                    "dd-MMM-yyyy HH:mm";
            }

            // -----------------------------------------------------
            // WIDTHS
            // -----------------------------------------------------

            if (dgvHealthRecords.Columns.Contains(
                "HealthRecordId"))
            {
                dgvHealthRecords.Columns[
                    "HealthRecordId"
                ].FillWeight = 60;
            }

            if (dgvHealthRecords.Columns.Contains(
                "MemberId"))
            {
                dgvHealthRecords.Columns[
                    "MemberId"
                ].FillWeight = 60;
            }

            if (dgvHealthRecords.Columns.Contains(
                "MemberName"))
            {
                dgvHealthRecords.Columns[
                    "MemberName"
                ].FillWeight = 130;
            }

            if (dgvHealthRecords.Columns.Contains(
                "HeightCm"))
            {
                dgvHealthRecords.Columns[
                    "HeightCm"
                ].FillWeight = 75;
            }

            if (dgvHealthRecords.Columns.Contains(
                "WeightKg"))
            {
                dgvHealthRecords.Columns[
                    "WeightKg"
                ].FillWeight = 75;
            }

            if (dgvHealthRecords.Columns.Contains(
                "BloodGroup"))
            {
                dgvHealthRecords.Columns[
                    "BloodGroup"
                ].FillWeight = 80;
            }

            if (dgvHealthRecords.Columns.Contains(
                "BMI"))
            {
                dgvHealthRecords.Columns[
                    "BMI"
                ].FillWeight = 60;
            }
        }

        // =========================================================
        // SEARCH BUTTON
        // =========================================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            LoadHealthRecords();
        }

        // =========================================================
        // SEARCH TEXT CHANGE
        // =========================================================

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            LoadHealthRecords();
        }

        // =========================================================
        // REFRESH
        // =========================================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            LoadHealthRecords();
        }

        // =========================================================
        // GRID CLICK
        // =========================================================

        private void dgvHealthRecords_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvHealthRecords.Rows[e.RowIndex];

                string memberName =
                    row.Cells["MemberName"]
                        .Value?.ToString() ?? "";

                string memberId =
                    row.Cells["MemberId"]
                        .Value?.ToString() ?? "";

                string recordDate =
                    row.Cells["RecordDate"]
                        .Value?.ToString() ?? "";

                string height =
                    row.Cells["HeightCm"]
                        .Value?.ToString() ?? "";

                string weight =
                    row.Cells["WeightKg"]
                        .Value?.ToString() ?? "";

                string bloodGroup =
                    row.Cells["BloodGroup"]
                        .Value?.ToString() ?? "";

                string bmi =
                    row.Cells["BMI"]
                        .Value?.ToString() ?? "";

                string conditions =
                    row.Cells["MedicalConditions"]
                        .Value?.ToString() ?? "";

                string allergies =
                    row.Cells["Allergies"]
                        .Value?.ToString() ?? "";

                string emergencyContact =
                    row.Cells["EmergencyContact"]
                        .Value?.ToString() ?? "";

                string emergencyPhone =
                    row.Cells["EmergencyPhone"]
                        .Value?.ToString() ?? "";

                string notes =
                    row.Cells["Notes"]
                        .Value?.ToString() ?? "";

                MessageBox.Show(
                    "Member: " + memberName +
                    "\nMember ID: " + memberId +
                    "\nRecord Date: " + recordDate +

                    "\n\nHeight: " + height + " cm" +
                    "\nWeight: " + weight + " kg" +
                    "\nBlood Group: " + bloodGroup +
                    "\nBMI: " + bmi +

                    "\n\nMedical Conditions:\n" +
                    conditions +

                    "\n\nAllergies:\n" +
                    allergies +

                    "\n\nEmergency Contact: " +
                    emergencyContact +

                    "\nEmergency Phone: " +
                    emergencyPhone +

                    "\n\nNotes:\n" +
                    notes,

                    "Health Record Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not display health record details.\n\n" +
                    ex.Message,
                    "Health Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // CLOSE
        // =========================================================

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}