using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffTrainerForm : Form
    {
        // =========================================================
        // STAFF INFORMATION
        // =========================================================

        private readonly string _staffName;
        private readonly string _staffRole;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public StaffTrainerForm(string staffName, string staffRole)
        {
            InitializeComponent();

            _staffName = staffName ?? "";
            _staffRole = staffRole ?? "";

            // -----------------------------------------------------
            // Explicit event connections
            // -----------------------------------------------------

            this.Load += StaffTrainerForm_Load;

            txtSearch.TextChanged += txtSearch_TextChanged;

            btnRefresh.Click += btnRefresh_Click;

            dgvTrainers.SelectionChanged +=
                dgvTrainers_SelectionChanged;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffTrainerForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Header
                lblTitle.Text = "TRAINER INFORMATION";

                lblSubtitle.Text =
                    "Staff View - Trainer Information";

                // Load trainer data
                LoadTrainers();

                // Initial information
                lblTrainerInfo.Text =
                    "Select a trainer to view information.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load Trainer Information.\n\n" +
                    ex.Message,
                    "Trainer Error",
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
                    ORDER BY TrainerId DESC;
                ";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvTrainers.DataSource = null;

                // Let DataGridView automatically create columns.
                // This matches the current StaffTrainer Designer.
                dgvTrainers.AutoGenerateColumns = true;

                dgvTrainers.DataSource = dt;

                // -------------------------------------------------
                // GRID SETTINGS
                // -------------------------------------------------

                dgvTrainers.ReadOnly = true;

                dgvTrainers.AllowUserToAddRows = false;

                dgvTrainers.AllowUserToDeleteRows = false;

                dgvTrainers.AllowUserToResizeRows = false;

                dgvTrainers.MultiSelect = false;

                dgvTrainers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvTrainers.RowHeadersVisible = false;

                dgvTrainers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvTrainers.BackgroundColor =
                    System.Drawing.SystemColors.Window;

                dgvTrainers.ClearSelection();

                // -------------------------------------------------
                // COLUMN HEADERS
                // -------------------------------------------------

                SetColumnHeader(
                    "TrainerId",
                    "Trainer ID"
                );

                SetColumnHeader(
                    "FullName",
                    "Trainer Name"
                );

                SetColumnHeader(
                    "Phone",
                    "Phone Number"
                );

                SetColumnHeader(
                    "Email",
                    "Email"
                );

                SetColumnHeader(
                    "Gender",
                    "Gender"
                );

                SetColumnHeader(
                    "Specialization",
                    "Specialization"
                );

                SetColumnHeader(
                    "JoinDate",
                    "Join Date"
                );

                SetColumnHeader(
                    "Salary",
                    "Salary"
                );

                // -------------------------------------------------
                // DATE FORMAT
                // -------------------------------------------------

                if (dgvTrainers.Columns.Contains("JoinDate"))
                {
                    dgvTrainers.Columns["JoinDate"]
                        .DefaultCellStyle.Format =
                        "dd-MMM-yyyy";
                }

                // -------------------------------------------------
                // SALARY FORMAT
                // -------------------------------------------------

                if (dgvTrainers.Columns.Contains("Salary"))
                {
                    dgvTrainers.Columns["Salary"]
                        .DefaultCellStyle.Format =
                        "0.00";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load trainer information.\n\n" +
                    "Database Error:\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load trainer information.\n\n" +
                    ex.Message,
                    "Trainer Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SET COLUMN HEADER
        // =========================================================

        private void SetColumnHeader(
            string columnName,
            string headerText)
        {
            if (dgvTrainers.Columns.Contains(columnName))
            {
                dgvTrainers.Columns[columnName]
                    .HeaderText = headerText;
            }
        }


        // =========================================================
        // SEARCH TRAINERS
        // =========================================================

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                string search =
                    txtSearch.Text.Trim();

                // If search box is empty,
                // load all trainers again.
                if (string.IsNullOrWhiteSpace(search))
                {
                    LoadTrainers();

                    lblTrainerInfo.Text =
                        "Select a trainer to view information.";

                    return;
                }

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
                        OR Gender LIKE @Search
                        OR Specialization LIKE @Search
                    ORDER BY TrainerId DESC;
                ";

                DataTable dt =
                    DbHelper.ExecuteQuery(
                        query,
                        new SqlParameter(
                            "@Search",
                            "%" + search + "%"
                        )
                    );

                dgvTrainers.DataSource = null;

                dgvTrainers.AutoGenerateColumns = true;

                dgvTrainers.DataSource = dt;

                // Re-apply grid settings
                dgvTrainers.ReadOnly = true;

                dgvTrainers.AllowUserToAddRows =
                    false;

                dgvTrainers.AllowUserToDeleteRows =
                    false;

                dgvTrainers.AllowUserToResizeRows =
                    false;

                dgvTrainers.MultiSelect = false;

                dgvTrainers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvTrainers.RowHeadersVisible = false;

                dgvTrainers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Headers
                SetColumnHeader(
                    "TrainerId",
                    "Trainer ID"
                );

                SetColumnHeader(
                    "FullName",
                    "Trainer Name"
                );

                SetColumnHeader(
                    "Phone",
                    "Phone Number"
                );

                SetColumnHeader(
                    "Email",
                    "Email"
                );

                SetColumnHeader(
                    "Gender",
                    "Gender"
                );

                SetColumnHeader(
                    "Specialization",
                    "Specialization"
                );

                SetColumnHeader(
                    "JoinDate",
                    "Join Date"
                );

                SetColumnHeader(
                    "Salary",
                    "Salary"
                );

                // Formats
                if (dgvTrainers.Columns.Contains("JoinDate"))
                {
                    dgvTrainers.Columns["JoinDate"]
                        .DefaultCellStyle.Format =
                        "dd-MMM-yyyy";
                }

                if (dgvTrainers.Columns.Contains("Salary"))
                {
                    dgvTrainers.Columns["Salary"]
                        .DefaultCellStyle.Format =
                        "0.00";
                }

                dgvTrainers.ClearSelection();

                lblTrainerInfo.Text =
                    dt.Rows.Count +
                    " trainer(s) found.";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Trainer search failed.\n\n" +
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Trainer search failed.\n\n" +
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // REFRESH BUTTON
        // =========================================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                txtSearch.Clear();

                LoadTrainers();

                lblTrainerInfo.Text =
                    "Trainer information refreshed successfully.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not refresh trainer information.\n\n" +
                    ex.Message,
                    "Refresh Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // TRAINER SELECTION CHANGED
        // =========================================================

        private void dgvTrainers_SelectionChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvTrainers.SelectedRows.Count == 0)
                {
                    lblTrainerInfo.Text =
                        "Select a trainer to view information.";

                    return;
                }

                DataGridViewRow row =
                    dgvTrainers.SelectedRows[0];

                string trainerId =
                    GetCellValue(
                        row,
                        "TrainerId"
                    );

                string fullName =
                    GetCellValue(
                        row,
                        "FullName"
                    );

                string phone =
                    GetCellValue(
                        row,
                        "Phone"
                    );

                string email =
                    GetCellValue(
                        row,
                        "Email"
                    );

                string gender =
                    GetCellValue(
                        row,
                        "Gender"
                    );

                string specialization =
                    GetCellValue(
                        row,
                        "Specialization"
                    );

                string joinDate =
                    GetFormattedDate(
                        row,
                        "JoinDate"
                    );

                string salary =
                    GetCellValue(
                        row,
                        "Salary"
                    );

                // -------------------------------------------------
                // DISPLAY SELECTED TRAINER INFORMATION
                // -------------------------------------------------

                lblTrainerInfo.Text =
                    "Trainer ID: " + trainerId +
                    "    |    Name: " + fullName +
                    "    |    Phone: " + phone +
                    "    |    Email: " + email +
                    "    |    Gender: " + gender +
                    "    |    Specialization: " +
                    specialization +
                    "    |    Join Date: " + joinDate +
                    "    |    Salary: " + salary;
            }
            catch (Exception ex)
            {
                lblTrainerInfo.Text =
                    "Unable to display trainer information.";

                // Don't show popup every time selection changes.
                System.Diagnostics.Debug.WriteLine(
                    "Trainer selection error: " +
                    ex.Message
                );
            }
        }


        // =========================================================
        // GET CELL VALUE
        // =========================================================

        private string GetCellValue(
            DataGridViewRow row,
            string columnName)
        {
            try
            {
                if (!dgvTrainers.Columns.Contains(
                    columnName))
                {
                    return "";
                }

                object value =
                    row.Cells[columnName].Value;

                if (value == null ||
                    value == DBNull.Value)
                {
                    return "";
                }

                return Convert.ToString(value) ?? "";
            }
            catch
            {
                return "";
            }
        }


        // =========================================================
        // GET FORMATTED DATE
        // =========================================================

        private string GetFormattedDate(
            DataGridViewRow row,
            string columnName)
        {
            try
            {
                if (!dgvTrainers.Columns.Contains(
                    columnName))
                {
                    return "";
                }

                object value =
                    row.Cells[columnName].Value;

                if (value == null ||
                    value == DBNull.Value)
                {
                    return "";
                }

                if (DateTime.TryParse(
                    value.ToString(),
                    out DateTime date))
                {
                    return date.ToString(
                        "dd-MMM-yyyy"
                    );
                }

                return value.ToString() ?? "";
            }
            catch
            {
                return "";
            }
        }
    }
}