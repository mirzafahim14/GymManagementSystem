using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using gymmanagementsystem_2;

namespace gymmanagementsystem_2.FORMS
{
    public partial class HealthForm : Form
    {
        public HealthForm()
        {
            InitializeComponent();

            this.Load += HealthForm_Load;

            // Automatic calculations
            txtWeight.TextChanged += CalculateBMI;
            cmbHeightFeet.SelectedIndexChanged += HeightChanged;
            cmbHeightInch.SelectedIndexChanged += HeightChanged;

            // Select record from table
            dgvHealthRecords.CellClick += dgvHealthRecords_CellClick;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void HealthForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadHealthRecords();

            cmbBloodGroup.SelectedIndex = -1;
            cmbHeightFeet.SelectedIndex = -1;
            cmbHeightInch.SelectedIndex = -1;

            ClearMedicalConditions();
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
                    ORDER BY FullName";

                DataTable table = DbHelper.ExecuteQuery(query);

                cmbMemberId.DataSource = null;
                cmbMemberId.DisplayMember = "FullName";
                cmbMemberId.ValueMember = "MemberId";
                cmbMemberId.DataSource = table;
                cmbMemberId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load members.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // HEIGHT CHANGED
        // =========================================================
        private void HeightChanged(object sender, EventArgs e)
        {
            CalculateHeightAndBMI();
        }

        // =========================================================
        // HEIGHT FEET + INCH TO CM
        // =========================================================
        private void CalculateHeightAndBMI()
        {
            if (cmbHeightFeet.SelectedIndex <= 0 ||
                cmbHeightInch.SelectedIndex < 0)
            {
                txtHeightCm.Clear();
                txtBMI.Clear();
                return;
            }

            decimal feet;
            decimal inch;

            if (!decimal.TryParse(
                    cmbHeightFeet.SelectedItem?.ToString(),
                    out feet))
            {
                return;
            }

            if (!decimal.TryParse(
                    cmbHeightInch.SelectedItem?.ToString(),
                    out inch))
            {
                return;
            }

            // Total inches
            decimal totalInches = (feet * 12) + inch;

            // 1 inch = 2.54 cm
            decimal heightCm = totalInches * 2.54m;

            txtHeightCm.Text =
                Math.Round(heightCm, 2).ToString("0.00");

            CalculateBMI(null, null);
        }

        // =========================================================
        // CALCULATE BMI
        // =========================================================
        private void CalculateBMI(object sender, EventArgs e)
        {
            decimal weight;

            if (!decimal.TryParse(
                    txtWeight.Text.Trim(),
                    out weight))
            {
                txtBMI.Clear();
                return;
            }

            if (weight <= 0)
            {
                txtBMI.Clear();
                return;
            }

            decimal heightCm;

            if (!decimal.TryParse(
                    txtHeightCm.Text.Trim(),
                    out heightCm))
            {
                txtBMI.Clear();
                return;
            }

            if (heightCm <= 0)
            {
                txtBMI.Clear();
                return;
            }

            decimal heightMeter = heightCm / 100m;

            decimal bmi =
                weight / (heightMeter * heightMeter);

            txtBMI.Text =
                Math.Round(bmi, 2).ToString("0.00");
        }

        // =========================================================
        // GET SELECTED MEDICAL CONDITIONS
        // =========================================================
        private string GetSelectedMedicalConditions()
        {
            string result = "";

            for (int i = 0;
                 i < clbMedicalConditions.CheckedItems.Count;
                 i++)
            {
                if (i > 0)
                {
                    result += ", ";
                }

                result += clbMedicalConditions
                    .CheckedItems[i]
                    .ToString();
            }

            return result;
        }

        // =========================================================
        // SET MEDICAL CONDITIONS
        // =========================================================
        private void SetMedicalConditions(string savedConditions)
        {
            ClearMedicalConditions();

            if (string.IsNullOrWhiteSpace(savedConditions))
                return;

            string[] conditions =
                savedConditions.Split(',');

            for (int i = 0;
                 i < clbMedicalConditions.Items.Count;
                 i++)
            {
                string item =
                    clbMedicalConditions.Items[i]
                    .ToString()
                    .Trim();

                foreach (string condition in conditions)
                {
                    if (item.Equals(
                            condition.Trim(),
                            StringComparison.OrdinalIgnoreCase))
                    {
                        clbMedicalConditions.SetItemChecked(
                            i, true);

                        break;
                    }
                }
            }
        }

        // =========================================================
        // CLEAR MEDICAL CONDITIONS
        // =========================================================
        private void ClearMedicalConditions()
        {
            for (int i = 0;
                 i < clbMedicalConditions.Items.Count;
                 i++)
            {
                clbMedicalConditions.SetItemChecked(
                    i, false);
            }
        }

        // =========================================================
        // LOAD HEALTH RECORDS
        // =========================================================
        private void LoadHealthRecords()
        {
            try
            {
                string query = @"
                    SELECT
                        MemberId,
                        BloodGroup,
                        WeightKg,
                        HeightCm,
                        BMI,
                        MedicalConditions,
                        EmergencyContact
                    FROM HealthRecords
                    ORDER BY HealthRecordId DESC";

                DataTable table =
                    DbHelper.ExecuteQuery(query);

                dgvHealthRecords.Rows.Clear();

                foreach (DataRow row in table.Rows)
                {
                    dgvHealthRecords.Rows.Add(
                        row["MemberId"],
                        row["BloodGroup"],
                        row["WeightKg"],
                        row["HeightCm"],
                        row["BMI"],
                        row["MedicalConditions"],
                        row["EmergencyContact"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load health records.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SAVE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                int memberId =
                    Convert.ToInt32(
                        cmbMemberId.SelectedValue);

                decimal weight =
                    Convert.ToDecimal(
                        txtWeight.Text.Trim());

                decimal heightCm =
                    Convert.ToDecimal(
                        txtHeightCm.Text.Trim());

                decimal bmi =
                    Convert.ToDecimal(
                        txtBMI.Text.Trim());

                string bloodGroup =
                    cmbBloodGroup.Text.Trim();

                string medicalConditions =
                    GetSelectedMedicalConditions();

                // -------------------------------------------------
                // CHECK DUPLICATE
                // -------------------------------------------------
                string checkQuery = @"
                    SELECT COUNT(*)
                    FROM HealthRecords
                    WHERE MemberId = @MemberId";

                object result =
                    DbHelper.ExecuteScalar(
                        checkQuery,
                        new SqlParameter(
                            "@MemberId",
                            memberId));

                int count =
                    Convert.ToInt32(result);

                if (count > 0)
                {
                    MessageBox.Show(
                        "This member already has a health record.\n\n" +
                        "Please use UPDATE instead.",
                        "Duplicate Record",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // -------------------------------------------------
                // INSERT
                // -------------------------------------------------
                string query = @"
                    INSERT INTO HealthRecords
                    (
                        MemberId,
                        RecordDate,
                        HeightCm,
                        WeightKg,
                        BloodGroup,
                        BMI,
                        MedicalConditions,
                        EmergencyContact
                    )
                    VALUES
                    (
                        @MemberId,
                        CAST(GETDATE() AS date),
                        @HeightCm,
                        @WeightKg,
                        @BloodGroup,
                        @BMI,
                        @MedicalConditions,
                        @EmergencyContact
                    )";

                int rows =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            memberId),

                        new SqlParameter(
                            "@HeightCm",
                            heightCm),

                        new SqlParameter(
                            "@WeightKg",
                            weight),

                        new SqlParameter(
                            "@BloodGroup",
                            GetDbValue(bloodGroup)),

                        new SqlParameter(
                            "@BMI",
                            bmi),

                        new SqlParameter(
                            "@MedicalConditions",
                            GetDbValue(
                                medicalConditions)),

                        new SqlParameter(
                            "@EmergencyContact",
                            GetDbValue(
                                txtEmergencyContact.Text))
                    );

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Health record saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadHealthRecords();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to save health record.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // UPDATE
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                if (dgvHealthRecords.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a health record first.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int memberId =
                    Convert.ToInt32(
                        cmbMemberId.SelectedValue);

                decimal weight =
                    Convert.ToDecimal(
                        txtWeight.Text.Trim());

                decimal heightCm =
                    Convert.ToDecimal(
                        txtHeightCm.Text.Trim());

                decimal bmi =
                    Convert.ToDecimal(
                        txtBMI.Text.Trim());

                string medicalConditions =
                    GetSelectedMedicalConditions();

                string query = @"
                    UPDATE HealthRecords
                    SET
                        RecordDate = CAST(GETDATE() AS date),
                        HeightCm = @HeightCm,
                        WeightKg = @WeightKg,
                        BloodGroup = @BloodGroup,
                        BMI = @BMI,
                        MedicalConditions = @MedicalConditions,
                        EmergencyContact = @EmergencyContact
                    WHERE MemberId = @MemberId";

                int rows =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@HeightCm",
                            heightCm),

                        new SqlParameter(
                            "@WeightKg",
                            weight),

                        new SqlParameter(
                            "@BloodGroup",
                            GetDbValue(
                                cmbBloodGroup.Text)),

                        new SqlParameter(
                            "@BMI",
                            bmi),

                        new SqlParameter(
                            "@MedicalConditions",
                            GetDbValue(
                                medicalConditions)),

                        new SqlParameter(
                            "@EmergencyContact",
                            GetDbValue(
                                txtEmergencyContact.Text)),

                        new SqlParameter(
                            "@MemberId",
                            memberId)
                    );

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Health record updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadHealthRecords();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Health record not found.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update health record.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DELETE
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHealthRecords.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a health record first.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (cmbMemberId.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a member.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete this health record?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                int memberId =
                    Convert.ToInt32(
                        cmbMemberId.SelectedValue);

                string query = @"
                    DELETE FROM HealthRecords
                    WHERE MemberId = @MemberId";

                int rows =
                    DbHelper.ExecuteNonQuery(
                        query,
                        new SqlParameter(
                            "@MemberId",
                            memberId));

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Health record deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadHealthRecords();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Health record not found.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete health record.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLEAR BUTTON
        // =========================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // =========================================================
        // CLEAR ALL FIELDS
        // =========================================================
        private void ClearFields()
        {
            cmbMemberId.SelectedIndex = -1;
            cmbBloodGroup.SelectedIndex = -1;
            cmbHeightFeet.SelectedIndex = -1;
            cmbHeightInch.SelectedIndex = -1;

            txtWeight.Clear();
            txtHeightCm.Clear();
            txtBMI.Clear();
            txtEmergencyContact.Clear();

            ClearMedicalConditions();

            dgvHealthRecords.ClearSelection();
        }

        // =========================================================
        // VALIDATION
        // =========================================================
        private bool ValidateFields()
        {
            // Member
            if (cmbMemberId.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a member.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbMemberId.Focus();

                return false;
            }

            // Blood Group
            if (cmbBloodGroup.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select blood group.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbBloodGroup.Focus();

                return false;
            }

            // Weight
            decimal weight;

            if (!decimal.TryParse(
                    txtWeight.Text.Trim(),
                    out weight) ||
                weight <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid weight in kg.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtWeight.Focus();

                return false;
            }

            // Height
            if (cmbHeightFeet.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Please select height in feet.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbHeightFeet.Focus();

                return false;
            }

            if (cmbHeightInch.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select height in inches.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbHeightInch.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHeightCm.Text))
            {
                MessageBox.Show(
                    "Height could not be calculated.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBMI.Text))
            {
                MessageBox.Show(
                    "BMI could not be calculated.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // =========================================================
        // NULL / EMPTY VALUE
        // =========================================================
        private object GetDbValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return DBNull.Value;

            return value.Trim();
        }

        // =========================================================
        // DATAGRIDVIEW ROW CLICK
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

                // Member ID
                if (row.Cells[0].Value != null)
                {
                    int memberId =
                        Convert.ToInt32(
                            row.Cells[0].Value);

                    cmbMemberId.SelectedValue =
                        memberId;
                }

                // Blood Group
                cmbBloodGroup.Text =
                    GetCellValue(
                        row.Cells[1].Value);

                // Weight
                txtWeight.Text =
                    GetCellValue(
                        row.Cells[2].Value);

                // Height CM
                string heightValue =
                    GetCellValue(
                        row.Cells[3].Value);

                decimal heightCm;

                if (decimal.TryParse(
                        heightValue,
                        out heightCm))
                {
                    txtHeightCm.Text =
                        Math.Round(
                            heightCm,
                            2).ToString("0.00");

                    // Convert CM to total inches
                    decimal totalInches =
                        heightCm / 2.54m;

                    int feet =
                        (int)(totalInches / 12);

                    int inches =
                        (int)Math.Round(
                            totalInches - (feet * 12));

                    if (inches == 12)
                    {
                        feet++;
                        inches = 0;
                    }

                    cmbHeightFeet.SelectedItem =
                        feet.ToString();

                    cmbHeightInch.SelectedItem =
                        inches.ToString();
                }
                else
                {
                    txtHeightCm.Clear();
                }

                // BMI
                txtBMI.Text =
                    GetCellValue(
                        row.Cells[4].Value);

                // Medical Conditions
                SetMedicalConditions(
                    GetCellValue(
                        row.Cells[5].Value));

                // Emergency Contact
                txtEmergencyContact.Text =
                    GetCellValue(
                        row.Cells[6].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load selected record.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DATAGRID CELL VALUE
        // =========================================================
        private string GetCellValue(object value)
        {
            if (value == null ||
                value == DBNull.Value)
            {
                return "";
            }

            return value.ToString();
        }

        // =========================================================
        // EXISTING EVENTS
        // =========================================================
        private void lblMedicalCondition_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblBMI_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}