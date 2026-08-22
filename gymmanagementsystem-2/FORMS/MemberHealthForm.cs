using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberHealthForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================
        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberHealthForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            // Form Load event
            this.Load += MemberHealthForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberHealthForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadLatestHealthInformation();
                LoadHealthRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load health information.\n\n" +
                    ex.Message,
                    "Health Error",
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
                MessageBox.Show(
                    "Member information was not found.",
                    "Member Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataRow row = table.Rows[0];

            lblMemberId.Text =
                "Member ID: " +
                GetString(row["MemberId"]);

            lblMemberName.Text =
                "Member Name: " +
                GetString(row["FullName"]);
        }


        // =========================================================
        // LOAD LATEST HEALTH INFORMATION
        // =========================================================
        private void LoadLatestHealthInformation()
        {
            string query = @"
                SELECT TOP 1
                    RecordDate,
                    HeightCm,
                    WeightKg,
                    BloodGroup,
                    BMI,
                    MedicalConditions,
                    Allergies,
                    EmergencyContact,
                    EmergencyPhone
                FROM HealthRecords
                WHERE MemberId = @MemberId
                ORDER BY RecordDate DESC, HealthRecordId DESC;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );

            // =====================================================
            // NO HEALTH RECORD
            // =====================================================

            if (table.Rows.Count == 0)
            {
                lblRecordDate.Text = "Record Date: —";
                lblHeight.Text = "Height: —";
                lblWeight.Text = "Weight: —";
                lblBMI.Text = "BMI: —";
                lblBloodGroup.Text = "Blood Group: —";
                lblMedicalConditions.Text =
                    "Medical Conditions: —";
                lblAllergies.Text = "Allergies: —";

                lblEmergencyContact.Text =
                    "Emergency Contact: —";

                lblEmergencyPhone.Text =
                    "Emergency Phone: —";

                return;
            }


            // =====================================================
            // GET LATEST RECORD
            // =====================================================

            DataRow row = table.Rows[0];


            // =====================================================
            // RECORD DATE
            // =====================================================

            lblRecordDate.Text =
                "Record Date: " +
                FormatDate(row["RecordDate"]);


            // =====================================================
            // HEIGHT
            // =====================================================

            lblHeight.Text =
                "Height: " +
                FormatNumber(row["HeightCm"]) +
                " cm";


            // =====================================================
            // WEIGHT
            // =====================================================

            lblWeight.Text =
                "Weight: " +
                FormatNumber(row["WeightKg"]) +
                " kg";


            // =====================================================
            // BMI
            // =====================================================

            lblBMI.Text =
                "BMI: " +
                FormatNumber(row["BMI"]);


            // =====================================================
            // BLOOD GROUP
            // =====================================================

            lblBloodGroup.Text =
                "Blood Group: " +
                GetString(row["BloodGroup"]);


            // =====================================================
            // MEDICAL CONDITIONS
            // =====================================================

            lblMedicalConditions.Text =
                "Medical Conditions: " +
                GetString(row["MedicalConditions"]);


            // =====================================================
            // ALLERGIES
            // =====================================================

            lblAllergies.Text =
                "Allergies: " +
                GetString(row["Allergies"]);


            // =====================================================
            // EMERGENCY CONTACT
            // =====================================================

            lblEmergencyContact.Text =
                "Emergency Contact: " +
                GetString(row["EmergencyContact"]);


            // =====================================================
            // EMERGENCY PHONE
            // =====================================================

            lblEmergencyPhone.Text =
                "Emergency Phone: " +
                GetString(row["EmergencyPhone"]);
        }


        // =========================================================
        // LOAD ALL HEALTH RECORDS
        // =========================================================
        private void LoadHealthRecords()
        {
            string query = @"
                SELECT
                    HealthRecordId,
                    RecordDate,
                    HeightCm,
                    WeightKg,
                    BloodGroup,
                    BMI,
                    MedicalConditions,
                    Allergies,
                    EmergencyContact,
                    EmergencyPhone
                FROM HealthRecords
                WHERE MemberId = @MemberId
                ORDER BY RecordDate DESC, HealthRecordId DESC;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );


            // =====================================================
            // CLEAR OLD DATA
            // =====================================================

            dgvHealthRecords.Rows.Clear();
            dgvHealthRecords.Columns.Clear();


            // =====================================================
            // CREATE COLUMNS
            // =====================================================

            dgvHealthRecords.Columns.Add(
                "HealthRecordId",
                "Record ID"
            );

            dgvHealthRecords.Columns.Add(
                "RecordDate",
                "Record Date"
            );

            dgvHealthRecords.Columns.Add(
                "HeightCm",
                "Height (cm)"
            );

            dgvHealthRecords.Columns.Add(
                "WeightKg",
                "Weight (kg)"
            );

            dgvHealthRecords.Columns.Add(
                "BloodGroup",
                "Blood Group"
            );

            dgvHealthRecords.Columns.Add(
                "BMI",
                "BMI"
            );

            dgvHealthRecords.Columns.Add(
                "MedicalConditions",
                "Medical Conditions"
            );

            dgvHealthRecords.Columns.Add(
                "Allergies",
                "Allergies"
            );

            dgvHealthRecords.Columns.Add(
                "EmergencyContact",
                "Emergency Contact"
            );

            dgvHealthRecords.Columns.Add(
                "EmergencyPhone",
                "Emergency Phone"
            );


            // =====================================================
            // ADD RECORDS
            // =====================================================

            foreach (DataRow row in table.Rows)
            {
                dgvHealthRecords.Rows.Add(

                    GetString(row["HealthRecordId"]),

                    FormatDate(row["RecordDate"]),

                    FormatNumber(row["HeightCm"]),

                    FormatNumber(row["WeightKg"]),

                    GetString(row["BloodGroup"]),

                    FormatNumber(row["BMI"]),

                    GetString(row["MedicalConditions"]),

                    GetString(row["Allergies"]),

                    GetString(row["EmergencyContact"]),

                    GetString(row["EmergencyPhone"])
                );
            }


            // =====================================================
            // GRID SETTINGS
            // =====================================================

            dgvHealthRecords.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHealthRecords.AllowUserToAddRows = false;
            dgvHealthRecords.AllowUserToDeleteRows = false;
            dgvHealthRecords.ReadOnly = true;
            dgvHealthRecords.MultiSelect = false;

            dgvHealthRecords.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHealthRecords.RowHeadersVisible = false;
        }


        // =========================================================
        // REFRESH BUTTON
        // =========================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadLatestHealthInformation();
                LoadHealthRecords();

                MessageBox.Show(
                    "Health information refreshed successfully.",
                    "Refresh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to refresh health information.\n\n" +
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
        // BMI LABEL CLICK
        // =========================================================
        private void lblBlood_Click(object sender, EventArgs e)
        {
            // Nothing required here.
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


        // =========================================================
        // DATE FORMAT
        // =========================================================
        private string FormatDate(object value)
        {
            if (value == null || value == DBNull.Value)
                return "—";

            if (DateTime.TryParse(
                value.ToString(),
                out DateTime date))
            {
                return date.ToString("dd MMM yyyy");
            }

            return "—";
        }


        // =========================================================
        // NUMBER FORMAT
        // =========================================================
        private string FormatNumber(object value)
        {
            if (value == null || value == DBNull.Value)
                return "—";

            if (decimal.TryParse(
                value.ToString(),
                out decimal number))
            {
                return number.ToString("0.##");
            }

            return "—";
        }
    }
}