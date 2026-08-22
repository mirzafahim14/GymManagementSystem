using System;
using System.Data;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffWorkoutForm : Form
    {
        public StaffWorkoutForm()
        {
            InitializeComponent();
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffWorkoutForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadWorkoutData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load workout data.\n\n" +
                    ex.Message,
                    "Workout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD WORKOUT DATA
        // =========================================================

        private void LoadWorkoutData()
        {
            try
            {
                string query = @"
                    SELECT
                        w.WorkoutPlanId,
                        w.MemberId,
                        m.FullName AS MemberName,
                        w.TrainerId,
                        t.FullName AS TrainerName,
                        w.PlanName,
                        w.Goal,
                        w.Description,
                        w.StartDate,
                        w.EndDate,
                        w.Status,
                        w.CreatedAt
                    FROM WorkoutPlans w

                    LEFT JOIN Members m
                        ON w.MemberId = m.MemberId

                    LEFT JOIN Trainers t
                        ON w.TrainerId = t.TrainerId

                    ORDER BY
                        w.WorkoutPlanId DESC;
                ";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvWorkouts.DataSource = dt;

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load workout plans.\n\n" +
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
            dgvWorkouts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvWorkouts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvWorkouts.MultiSelect = false;

            dgvWorkouts.ReadOnly = true;

            dgvWorkouts.AllowUserToAddRows = false;

            dgvWorkouts.AllowUserToDeleteRows = false;

            dgvWorkouts.AllowUserToResizeRows = false;

            dgvWorkouts.RowHeadersVisible = false;


            // -----------------------------------------------------
            // HEADERS
            // -----------------------------------------------------

            if (dgvWorkouts.Columns.Contains("WorkoutPlanId"))
            {
                dgvWorkouts.Columns["WorkoutPlanId"]
                    .HeaderText = "Workout ID";
            }

            if (dgvWorkouts.Columns.Contains("MemberId"))
            {
                dgvWorkouts.Columns["MemberId"]
                    .HeaderText = "Member ID";
            }

            if (dgvWorkouts.Columns.Contains("MemberName"))
            {
                dgvWorkouts.Columns["MemberName"]
                    .HeaderText = "Member Name";
            }

            if (dgvWorkouts.Columns.Contains("TrainerId"))
            {
                dgvWorkouts.Columns["TrainerId"]
                    .HeaderText = "Trainer ID";
            }

            if (dgvWorkouts.Columns.Contains("TrainerName"))
            {
                dgvWorkouts.Columns["TrainerName"]
                    .HeaderText = "Trainer Name";
            }

            if (dgvWorkouts.Columns.Contains("PlanName"))
            {
                dgvWorkouts.Columns["PlanName"]
                    .HeaderText = "Plan Name";
            }

            if (dgvWorkouts.Columns.Contains("Goal"))
            {
                dgvWorkouts.Columns["Goal"]
                    .HeaderText = "Goal";
            }

            if (dgvWorkouts.Columns.Contains("Description"))
            {
                dgvWorkouts.Columns["Description"]
                    .HeaderText = "Description";
            }

            if (dgvWorkouts.Columns.Contains("StartDate"))
            {
                dgvWorkouts.Columns["StartDate"]
                    .HeaderText = "Start Date";

                dgvWorkouts.Columns["StartDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }

            if (dgvWorkouts.Columns.Contains("EndDate"))
            {
                dgvWorkouts.Columns["EndDate"]
                    .HeaderText = "End Date";

                dgvWorkouts.Columns["EndDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }

            if (dgvWorkouts.Columns.Contains("Status"))
            {
                dgvWorkouts.Columns["Status"]
                    .HeaderText = "Status";
            }

            if (dgvWorkouts.Columns.Contains("CreatedAt"))
            {
                dgvWorkouts.Columns["CreatedAt"]
                    .HeaderText = "Created At";

                dgvWorkouts.Columns["CreatedAt"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy HH:mm";
            }


            // -----------------------------------------------------
            // COLUMN WIDTH
            // -----------------------------------------------------

            if (dgvWorkouts.Columns.Contains("WorkoutPlanId"))
                dgvWorkouts.Columns["WorkoutPlanId"].FillWeight = 60;

            if (dgvWorkouts.Columns.Contains("MemberId"))
                dgvWorkouts.Columns["MemberId"].FillWeight = 60;

            if (dgvWorkouts.Columns.Contains("MemberName"))
                dgvWorkouts.Columns["MemberName"].FillWeight = 110;

            if (dgvWorkouts.Columns.Contains("TrainerId"))
                dgvWorkouts.Columns["TrainerId"].FillWeight = 60;

            if (dgvWorkouts.Columns.Contains("TrainerName"))
                dgvWorkouts.Columns["TrainerName"].FillWeight = 110;

            if (dgvWorkouts.Columns.Contains("PlanName"))
                dgvWorkouts.Columns["PlanName"].FillWeight = 110;

            if (dgvWorkouts.Columns.Contains("Goal"))
                dgvWorkouts.Columns["Goal"].FillWeight = 100;

            if (dgvWorkouts.Columns.Contains("Description"))
                dgvWorkouts.Columns["Description"].FillWeight = 160;

            if (dgvWorkouts.Columns.Contains("StartDate"))
                dgvWorkouts.Columns["StartDate"].FillWeight = 90;

            if (dgvWorkouts.Columns.Contains("EndDate"))
                dgvWorkouts.Columns["EndDate"].FillWeight = 90;

            if (dgvWorkouts.Columns.Contains("Status"))
                dgvWorkouts.Columns["Status"].FillWeight = 80;

            if (dgvWorkouts.Columns.Contains("CreatedAt"))
                dgvWorkouts.Columns["CreatedAt"].FillWeight = 110;
        }

        // =========================================================
        // SEARCH
        // =========================================================

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                string searchText =
                    txtSearch.Text.Trim();

                if (dgvWorkouts.DataSource is DataTable dt)
                {
                    if (string.IsNullOrWhiteSpace(searchText))
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                    else
                    {
                        string safeSearch =
                            searchText.Replace(
                                "'",
                                "''"
                            );

                        dt.DefaultView.RowFilter =
                            "Convert(WorkoutPlanId, 'System.String') LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "Convert(MemberId, 'System.String') LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "MemberName LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "Convert(TrainerId, 'System.String') LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "TrainerName LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "PlanName LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "Goal LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "Description LIKE '%" +
                            safeSearch +
                            "%' OR " +

                            "Status LIKE '%" +
                            safeSearch +
                            "%'";
                    }
                }
            }
            catch
            {
                // Ignore invalid search/filter input
            }
        }

        // =========================================================
        // REFRESH
        // =========================================================

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            LoadWorkoutData();
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

        // =========================================================
        // GRID SELECTION
        // =========================================================

        private void dgvWorkouts_SelectionChanged(
            object sender,
            EventArgs e)
        {
            // Staff is view-only.
            // No editing operation is performed here.
        }
    }
}