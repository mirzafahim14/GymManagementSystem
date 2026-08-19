using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class TrainerForm : Form
    {
        public TrainerForm()
        {
            InitializeComponent();

            // Explicitly connect events
            this.Load += TrainerForm_Load;
            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvTrainers.CellClick += dgvTrainers_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void TrainerForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtTrainerId.ReadOnly = true;

                // Gender
                cmbGender.Items.Clear();

                cmbGender.Items.Add("Male");
                cmbGender.Items.Add("Female");
                cmbGender.Items.Add("Other");

                cmbGender.SelectedIndex = -1;

                // Specialization
                if (cmbSpecialization.Items.Count > 0)
                {
                    cmbSpecialization.SelectedIndex = 0;
                }

                // Load database data
                LoadTrainers();

                // Clear input fields
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Trainer form could not be loaded.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LOAD TRAINERS
        // =========================================================
        private void LoadTrainers()
        {
            try
            {
                string query = @"
            SELECT
                TrainerId,
                FullName,
                Phone,
                Email,
                Gender,
                Specialization,
                JoinDate,
                Salary
            FROM Trainers
            ORDER BY TrainerId DESC";

                DataTable dt = DbHelper.ExecuteQuery(query);

                // IMPORTANT:
                // Designer-এ তৈরি করা columns ব্যবহার করব
                dgvTrainers.AutoGenerateColumns = false;

                // Database field -> Designer column mapping
                colTrainerId.DataPropertyName = "TrainerId";
                colTrainerName.DataPropertyName = "FullName";
                colPhone.DataPropertyName = "Phone";
                colEmail.DataPropertyName = "Email";
                colGender.DataPropertyName = "Gender";
                colSpecialization.DataPropertyName = "Specialization";
                colJoinDate.DataPropertyName = "JoinDate";
                colSalary.DataPropertyName = "Salary";

                // Header names
                colTrainerId.HeaderText = "Trainer ID";
                colTrainerName.HeaderText = "Trainer Name";
                colPhone.HeaderText = "Phone Number";
                colEmail.HeaderText = "Email";
                colGender.HeaderText = "Gender";
                colSpecialization.HeaderText = "Specialization";
                colJoinDate.HeaderText = "Join Date";
                colSalary.HeaderText = "Salary";

                // Bind data
                dgvTrainers.DataSource = dt;

                // Grid settings
                dgvTrainers.ReadOnly = true;
                dgvTrainers.AllowUserToAddRows = false;
                dgvTrainers.AllowUserToDeleteRows = false;

                dgvTrainers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvTrainers.MultiSelect = false;

                dgvTrainers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Date format
                colJoinDate.DefaultCellStyle.Format = "dd-MMM-yyyy";

                // Salary format
                colSalary.DefaultCellStyle.Format = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load trainers.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SAVE TRAINER
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTrainerInput())
                    return;

                decimal salary;

                if (!decimal.TryParse(
                    txtSalary.Text.Trim(),
                    out salary))
                {
                    MessageBox.Show(
                        "Please enter a valid salary.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtSalary.Focus();
                    return;
                }


                string query = @"
                    INSERT INTO Trainers
                    (
                        FullName,
                        Phone,
                        Email,
                        Gender,
                        Specialization,
                        JoinDate,
                        Salary
                    )
                    VALUES
                    (
                        @FullName,
                        @Phone,
                        @Email,
                        @Gender,
                        @Specialization,
                        @JoinDate,
                        @Salary
                    )";


                int result = DbHelper.ExecuteNonQuery(
                    query,

                    new SqlParameter(
                        "@FullName",
                        txtTrainerName.Text.Trim()),

                    new SqlParameter(
                        "@Phone",
                        txtPhone.Text.Trim()),

                    new SqlParameter(
                        "@Email",
                        txtEmail.Text.Trim()),

                    new SqlParameter(
                        "@Gender",
                        cmbGender.Text.Trim()),

                    new SqlParameter(
                        "@Specialization",
                        cmbSpecialization.Text.Trim()),

                    new SqlParameter(
                        "@JoinDate",
                        dateTimePicker1.Value.Date),

                    new SqlParameter(
                        "@Salary",
                        salary)
                );


                if (result > 0)
                {
                    MessageBox.Show(
                        "Trainer saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadTrainers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Trainer could not be saved.",
                        "Save",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save trainer.\n\n" + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // UPDATE TRAINER
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTrainerId.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Please select a trainer from the list first.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                if (!ValidateTrainerInput())
                    return;


                int trainerId;

                if (!int.TryParse(
                    txtTrainerId.Text.Trim(),
                    out trainerId))
                {
                    MessageBox.Show(
                        "Invalid Trainer ID.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                decimal salary;

                if (!decimal.TryParse(
                    txtSalary.Text.Trim(),
                    out salary))
                {
                    MessageBox.Show(
                        "Please enter a valid salary.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtSalary.Focus();
                    return;
                }


                string query = @"
                    UPDATE Trainers
                    SET
                        FullName = @FullName,
                        Phone = @Phone,
                        Email = @Email,
                        Gender = @Gender,
                        Specialization = @Specialization,
                        JoinDate = @JoinDate,
                        Salary = @Salary
                    WHERE TrainerId = @TrainerId";


                int result = DbHelper.ExecuteNonQuery(
                    query,

                    new SqlParameter(
                        "@TrainerId",
                        trainerId),

                    new SqlParameter(
                        "@FullName",
                        txtTrainerName.Text.Trim()),

                    new SqlParameter(
                        "@Phone",
                        txtPhone.Text.Trim()),

                    new SqlParameter(
                        "@Email",
                        txtEmail.Text.Trim()),

                    new SqlParameter(
                        "@Gender",
                        cmbGender.Text.Trim()),

                    new SqlParameter(
                        "@Specialization",
                        cmbSpecialization.Text.Trim()),

                    new SqlParameter(
                        "@JoinDate",
                        dateTimePicker1.Value.Date),

                    new SqlParameter(
                        "@Salary",
                        salary)
                );


                if (result > 0)
                {
                    MessageBox.Show(
                        "Trainer updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadTrainers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Trainer was not found.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update trainer.\n\n" + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // DELETE TRAINER
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTrainerId.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Please select a trainer first.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                int trainerId;

                if (!int.TryParse(
                    txtTrainerId.Text.Trim(),
                    out trainerId))
                {
                    MessageBox.Show(
                        "Invalid Trainer ID.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this trainer?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


                if (confirm != DialogResult.Yes)
                    return;


                string query = @"
                    DELETE FROM Trainers
                    WHERE TrainerId = @TrainerId";


                int deleted = DbHelper.ExecuteNonQuery(
                    query,
                    new SqlParameter(
                        "@TrainerId",
                        trainerId)
                );


                if (deleted > 0)
                {
                    MessageBox.Show(
                        "Trainer deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadTrainers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Trainer was not found.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete trainer.\n\n" + ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
        // CLEAR FIELDS
        // =========================================================
        private void ClearFields()
        {
            txtTrainerId.Clear();
            txtTrainerName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSalary.Clear();

            cmbGender.SelectedIndex = -1;

            if (cmbSpecialization.Items.Count > 0)
            {
                cmbSpecialization.SelectedIndex = 0;
            }

            dateTimePicker1.Value = DateTime.Today;

            dgvTrainers.ClearSelection();

            txtTrainerName.Focus();
        }


        // =========================================================
        // VALIDATION
        // =========================================================
        private bool ValidateTrainerInput()
        {
            if (string.IsNullOrWhiteSpace(txtTrainerName.Text))
            {
                MessageBox.Show(
                    "Please enter trainer name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTrainerName.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter phone number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPhone.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter email.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return false;
            }


            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select gender.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbGender.Focus();
                return false;
            }


            if (cmbSpecialization.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Please select specialization.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbSpecialization.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show(
                    "Please enter salary.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSalary.Focus();
                return false;
            }


            decimal salary;

            if (!decimal.TryParse(txtSalary.Text.Trim(), out salary))
            {
                MessageBox.Show(
                    "Salary must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSalary.Focus();
                return false;
            }


            if (salary < 0)
            {
                MessageBox.Show(
                    "Salary cannot be negative.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSalary.Focus();
                return false;
            }


            return true;
        }


        // =========================================================
        // DATAGRIDVIEW ROW CLICK
        // =========================================================
        private void dgvTrainers_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;


                DataGridViewRow row =
                    dgvTrainers.Rows[e.RowIndex];


                if (row.Cells["TrainerId"].Value == null)
                    return;


                txtTrainerId.Text =
                    Convert.ToString(
                        row.Cells["TrainerId"].Value);


                txtTrainerName.Text =
                    Convert.ToString(
                        row.Cells["FullName"].Value);


                txtPhone.Text =
                    Convert.ToString(
                        row.Cells["Phone"].Value);


                txtEmail.Text =
                    Convert.ToString(
                        row.Cells["Email"].Value);


                string gender =
                    Convert.ToString(
                        row.Cells["Gender"].Value);

                if (cmbGender.Items.Contains(gender))
                {
                    cmbGender.SelectedItem = gender;
                }
                else
                {
                    cmbGender.SelectedIndex = -1;
                }


                string specialization =
                    Convert.ToString(
                        row.Cells["Specialization"].Value);

                if (cmbSpecialization.Items.Contains(specialization))
                {
                    cmbSpecialization.SelectedItem =
                        specialization;
                }
                else
                {
                    cmbSpecialization.SelectedIndex = 0;
                }


                if (row.Cells["JoinDate"].Value != null &&
                    row.Cells["JoinDate"].Value != DBNull.Value)
                {
                    DateTime joinDate =
                        Convert.ToDateTime(
                            row.Cells["JoinDate"].Value);

                    if (joinDate >= dateTimePicker1.MinDate &&
                        joinDate <= dateTimePicker1.MaxDate)
                    {
                        dateTimePicker1.Value = joinDate;
                    }
                }


                txtSalary.Text =
                    Convert.ToString(
                        row.Cells["Salary"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not select trainer.\n\n" + ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SEARCH TRAINER
        // =========================================================
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                string search = txtSearch.Text.Trim();

                string query = @"
                    SELECT
                        TrainerId,
                        FullName,
                        Phone,
                        Email,
                        Gender,
                        Specialization,
                        JoinDate,
                        Salary
                    FROM Trainers
                    WHERE
                        FullName LIKE @Search
                        OR Phone LIKE @Search
                        OR Email LIKE @Search
                        OR Specialization LIKE @Search
                    ORDER BY TrainerId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(
                        query,
                        new SqlParameter(
                            "@Search",
                            "%" + search + "%")
                    );

                dgvTrainers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // OPTIONAL EVENTS
        // =========================================================
        private void lblTrainerManagement_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblTrainerId_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblTrainerName_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblPhone_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblEmail_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblSpecialization_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblGender_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblJoinDate_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblSalary_Click(
            object sender,
            EventArgs e)
        {
        }

        private void cmbGender_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}