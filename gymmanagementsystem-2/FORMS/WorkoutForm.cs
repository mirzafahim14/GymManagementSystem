using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class WorkoutForm : Form
    {
        // =========================================================
        // DATABASE CONNECTION
        // =========================================================
        private readonly string connectionString =
            @"Server=localhost;Database=GymManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;";

        // =========================================================
        // SELECTED WORKOUT ID
        // =========================================================
        private int selectedWorkoutId = 0;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public WorkoutForm()
        {
            InitializeComponent();

            // Form Load
            this.Load += WorkoutForm_Load;

            // Buttons
            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            // DataGridView
            dgvWorkouts.CellClick += dgvWorkouts_CellClick;

            // Workout Goal
            cmbWorkoutGoal.SelectedIndexChanged +=
                cmbWorkoutGoal_SelectedIndexChanged;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void WorkoutForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMembers();
                LoadWorkoutTypes();
                LoadWorkoutGoals();
                LoadWorkouts();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading Workout Form.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD MEMBERS
        // =========================================================
        private void LoadMembers()
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT MemberId, FullName
                    FROM Members
                    ORDER BY FullName";

                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    con.Open();

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    cmbMember.DataSource = dt;
                    cmbMember.DisplayMember = "FullName";
                    cmbMember.ValueMember = "MemberId";
                    cmbMember.SelectedIndex = -1;
                }
            }
        }

        // =========================================================
        // LOAD WORKOUT TYPES
        // =========================================================
        private void LoadWorkoutTypes()
        {
            cmbWorkoutType.Items.Clear();

            cmbWorkoutType.Items.Add("Strength Training");
            cmbWorkoutType.Items.Add("Cardio");
            cmbWorkoutType.Items.Add("Weight Training");
            cmbWorkoutType.Items.Add("HIIT");
            cmbWorkoutType.Items.Add("Yoga");
            cmbWorkoutType.Items.Add("CrossFit");
            cmbWorkoutType.Items.Add("Circuit Training");
            cmbWorkoutType.Items.Add("Flexibility Training");
            cmbWorkoutType.Items.Add("Rehabilitation");
            cmbWorkoutType.Items.Add("General Fitness");

            cmbWorkoutType.SelectedIndex = -1;
        }

        // =========================================================
        // LOAD WORKOUT GOALS
        // =========================================================
        private void LoadWorkoutGoals()
        {
            cmbWorkoutGoal.Items.Clear();

            cmbWorkoutGoal.Items.Add("Muscle Gain");
            cmbWorkoutGoal.Items.Add("Weight Loss");
            cmbWorkoutGoal.Items.Add("Fat Loss");
            cmbWorkoutGoal.Items.Add("Strength");
            cmbWorkoutGoal.Items.Add("Endurance");
            cmbWorkoutGoal.Items.Add("General Fitness");
            cmbWorkoutGoal.Items.Add("Bodybuilding");
            cmbWorkoutGoal.Items.Add("Rehabilitation");
            cmbWorkoutGoal.Items.Add("Flexibility");

            cmbWorkoutGoal.SelectedIndex = -1;
        }

        // =========================================================
        // WORKOUT GOAL → AUTOMATIC EXERCISES
        // =========================================================
        private void cmbWorkoutGoal_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            clbExercises.Items.Clear();

            if (cmbWorkoutGoal.SelectedItem == null)
                return;

            string goal =
                cmbWorkoutGoal.SelectedItem.ToString();

            switch (goal)
            {
                // -------------------------------------------------
                // MUSCLE GAIN
                // -------------------------------------------------
                case "Muscle Gain":

                    clbExercises.Items.Add("Bench Press");
                    clbExercises.Items.Add("Squat");
                    clbExercises.Items.Add("Deadlift");
                    clbExercises.Items.Add("Shoulder Press");
                    clbExercises.Items.Add("Barbell Row");

                    break;

                // -------------------------------------------------
                // WEIGHT LOSS
                // -------------------------------------------------
                case "Weight Loss":

                    clbExercises.Items.Add("Treadmill Running");
                    clbExercises.Items.Add("Jump Rope");
                    clbExercises.Items.Add("Cycling");
                    clbExercises.Items.Add("Burpees");
                    clbExercises.Items.Add("Mountain Climbers");

                    break;

                // -------------------------------------------------
                // FAT LOSS
                // -------------------------------------------------
                case "Fat Loss":

                    clbExercises.Items.Add("HIIT");
                    clbExercises.Items.Add("Jump Rope");
                    clbExercises.Items.Add("Burpees");
                    clbExercises.Items.Add("Running");
                    clbExercises.Items.Add("Mountain Climbers");

                    break;

                // -------------------------------------------------
                // STRENGTH
                // -------------------------------------------------
                case "Strength":

                    clbExercises.Items.Add("Squat");
                    clbExercises.Items.Add("Deadlift");
                    clbExercises.Items.Add("Bench Press");
                    clbExercises.Items.Add("Overhead Press");
                    clbExercises.Items.Add("Pull-Up");

                    break;

                // -------------------------------------------------
                // ENDURANCE
                // -------------------------------------------------
                case "Endurance":

                    clbExercises.Items.Add("Running");
                    clbExercises.Items.Add("Cycling");
                    clbExercises.Items.Add("Rowing");
                    clbExercises.Items.Add("Jump Rope");
                    clbExercises.Items.Add("Swimming");

                    break;

                // -------------------------------------------------
                // GENERAL FITNESS
                // -------------------------------------------------
                case "General Fitness":

                    clbExercises.Items.Add("Squat");
                    clbExercises.Items.Add("Push-Up");
                    clbExercises.Items.Add("Plank");
                    clbExercises.Items.Add("Jogging");
                    clbExercises.Items.Add("Lunges");

                    break;

                // -------------------------------------------------
                // BODYBUILDING
                // -------------------------------------------------
                case "Bodybuilding":

                    clbExercises.Items.Add("Bench Press");
                    clbExercises.Items.Add("Bicep Curl");
                    clbExercises.Items.Add("Tricep Extension");
                    clbExercises.Items.Add("Leg Press");
                    clbExercises.Items.Add("Lat Pulldown");

                    break;

                // -------------------------------------------------
                // REHABILITATION
                // -------------------------------------------------
                case "Rehabilitation":

                    clbExercises.Items.Add("Walking");
                    clbExercises.Items.Add("Light Cycling");
                    clbExercises.Items.Add("Stretching");
                    clbExercises.Items.Add("Mobility Exercise");
                    clbExercises.Items.Add("Balance Exercise");

                    break;

                // -------------------------------------------------
                // FLEXIBILITY
                // -------------------------------------------------
                case "Flexibility":

                    clbExercises.Items.Add("Hamstring Stretch");
                    clbExercises.Items.Add("Quad Stretch");
                    clbExercises.Items.Add("Shoulder Stretch");
                    clbExercises.Items.Add("Hip Stretch");
                    clbExercises.Items.Add("Cat-Cow Stretch");

                    break;
            }
        }

        // =========================================================
        // GET SELECTED EXERCISES
        // =========================================================
        private string GetSelectedExercises()
        {
            if (clbExercises.CheckedItems.Count == 0)
                return "";

            return string.Join(
                ", ",
                clbExercises.CheckedItems
                    .Cast<object>()
                    .Select(x => x.ToString())
            );
        }

        // =========================================================
        // SAVE
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                int memberId =
                    Convert.ToInt32(cmbMember.SelectedValue);

                string workoutType =
                    cmbWorkoutType.Text.Trim();

                string goal =
                    cmbWorkoutGoal.Text.Trim();

                int duration =
                    Convert.ToInt32(txtDuration.Text.Trim());

                string exercises =
                    GetSelectedExercises();

                string sets =
                    txtSets.Text.Trim();

                string reps =
                    txtReps.Text.Trim();

                DateTime startDate =
                    DateTime.Today;

                DateTime endDate =
                    startDate.AddDays(duration - 1);

                string description =
                    "Exercises: " + exercises +
                    Environment.NewLine +
                    "Sets: " + sets +
                    Environment.NewLine +
                    "Reps: " + reps;

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        INSERT INTO WorkoutPlans
                        (
                            MemberId,
                            TrainerId,
                            PlanName,
                            Goal,
                            Description,
                            StartDate,
                            EndDate
                        )
                        VALUES
                        (
                            @MemberId,
                            NULL,
                            @PlanName,
                            @Goal,
                            @Description,
                            @StartDate,
                            @EndDate
                        )";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@MemberId",
                            memberId
                        );

                        cmd.Parameters.AddWithValue(
                            "@PlanName",
                            workoutType
                        );

                        cmd.Parameters.AddWithValue(
                            "@Goal",
                            goal
                        );

                        cmd.Parameters.AddWithValue(
                            "@Description",
                            description
                        );

                        cmd.Parameters.AddWithValue(
                            "@StartDate",
                            startDate
                        );

                        cmd.Parameters.AddWithValue(
                            "@EndDate",
                            endDate
                        );

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Workout plan saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadWorkouts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving workout.\n\n" + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // UPDATE
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedWorkoutId <= 0)
                {
                    MessageBox.Show(
                        "Please select a workout from the list first.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (!ValidateInput())
                    return;

                int memberId =
                    Convert.ToInt32(cmbMember.SelectedValue);

                string workoutType =
                    cmbWorkoutType.Text.Trim();

                string goal =
                    cmbWorkoutGoal.Text.Trim();

                int duration =
                    Convert.ToInt32(txtDuration.Text.Trim());

                string exercises =
                    GetSelectedExercises();

                string sets =
                    txtSets.Text.Trim();

                string reps =
                    txtReps.Text.Trim();

                DateTime startDate =
                    DateTime.Today;

                DateTime endDate =
                    startDate.AddDays(duration - 1);

                string description =
                    "Exercises: " + exercises +
                    Environment.NewLine +
                    "Sets: " + sets +
                    Environment.NewLine +
                    "Reps: " + reps;

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE WorkoutPlans
                        SET
                            MemberId = @MemberId,
                            PlanName = @PlanName,
                            Goal = @Goal,
                            Description = @Description,
                            StartDate = @StartDate,
                            EndDate = @EndDate
                        WHERE WorkoutPlanId = @WorkoutPlanId";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@WorkoutPlanId",
                            selectedWorkoutId
                        );

                        cmd.Parameters.AddWithValue(
                            "@MemberId",
                            memberId
                        );

                        cmd.Parameters.AddWithValue(
                            "@PlanName",
                            workoutType
                        );

                        cmd.Parameters.AddWithValue(
                            "@Goal",
                            goal
                        );

                        cmd.Parameters.AddWithValue(
                            "@Description",
                            description
                        );

                        cmd.Parameters.AddWithValue(
                            "@StartDate",
                            startDate
                        );

                        cmd.Parameters.AddWithValue(
                            "@EndDate",
                            endDate
                        );

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Workout updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadWorkouts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating workout.\n\n" + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // DELETE
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedWorkoutId <= 0)
                {
                    MessageBox.Show(
                        "Please select a workout first.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete this workout?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result != DialogResult.Yes)
                    return;

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        DELETE FROM WorkoutPlans
                        WHERE WorkoutPlanId = @WorkoutPlanId";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@WorkoutPlanId",
                            selectedWorkoutId
                        );

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Workout deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadWorkouts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting workout.\n\n" + ex.Message,
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
            selectedWorkoutId = 0;

            cmbMember.SelectedIndex = -1;

            cmbWorkoutType.SelectedIndex = -1;

            cmbWorkoutGoal.SelectedIndex = -1;

            txtDuration.Clear();

            txtSets.Clear();

            txtReps.Clear();

            clbExercises.Items.Clear();

            for (int i = 0; i < clbExercises.Items.Count; i++)
            {
                clbExercises.SetItemChecked(i, false);
            }

            if (dgvWorkouts.Rows.Count > 0)
            {
                dgvWorkouts.ClearSelection();
            }

            cmbMember.Focus();
        }

        // =========================================================
        // VALIDATION
        // =========================================================
        private bool ValidateInput()
        {
            if (cmbMember.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a member.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbMember.Focus();

                return false;
            }

            if (cmbWorkoutType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select workout type.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbWorkoutType.Focus();

                return false;
            }

            if (cmbWorkoutGoal.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select workout goal.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbWorkoutGoal.Focus();

                return false;
            }

            if (clbExercises.CheckedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one exercise.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                clbExercises.Focus();

                return false;
            }

            if (!int.TryParse(
                txtDuration.Text.Trim(),
                out int duration))
            {
                MessageBox.Show(
                    "Duration must be a valid number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDuration.Focus();

                return false;
            }

            if (duration <= 0)
            {
                MessageBox.Show(
                    "Duration must be greater than 0.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDuration.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSets.Text))
            {
                MessageBox.Show(
                    "Please enter sets.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSets.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtReps.Text))
            {
                MessageBox.Show(
                    "Please enter repetitions.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtReps.Focus();

                return false;
            }

            return true;
        }

        // =========================================================
        // LOAD WORKOUTS INTO DATAGRIDVIEW
        // =========================================================
        private void LoadWorkouts()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT
                            W.WorkoutPlanId,
                            W.MemberId,
                            M.FullName AS MemberName,
                            W.PlanName,
                            W.Goal,
                            W.Description,
                            W.StartDate,
                            W.EndDate
                        FROM WorkoutPlans W
                        INNER JOIN Members M
                            ON W.MemberId = M.MemberId
                        ORDER BY W.WorkoutPlanId DESC";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        SqlDataAdapter da =
                            new SqlDataAdapter(cmd);

                        DataTable dt =
                            new DataTable();

                        da.Fill(dt);

                        dgvWorkouts.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            int duration = 0;

                            if (row["StartDate"] != DBNull.Value &&
                                row["EndDate"] != DBNull.Value)
                            {
                                DateTime start =
                                    Convert.ToDateTime(
                                        row["StartDate"]);

                                DateTime end =
                                    Convert.ToDateTime(
                                        row["EndDate"]);

                                duration =
                                    (end - start).Days + 1;
                            }

                            string description =
                                row["Description"] == DBNull.Value
                                    ? ""
                                    : row["Description"].ToString();

                            ParseDescription(
                                description,
                                out string exercises,
                                out string sets,
                                out string reps
                            );

                            dgvWorkouts.Rows.Add(
                                row["WorkoutPlanId"],
                                row["MemberId"],
                                row["PlanName"],
                                row["Goal"],
                                duration,
                                exercises,
                                sets,
                                reps
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading workouts.\n\n" + ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // PARSE DESCRIPTION
        // =========================================================
        private void ParseDescription(
            string description,
            out string exercises,
            out string sets,
            out string reps)
        {
            exercises = "";
            sets = "";
            reps = "";

            if (string.IsNullOrWhiteSpace(description))
                return;

            string[] lines =
                description.Split(
                    new[]
                    {
                        Environment.NewLine
                    },
                    StringSplitOptions.None
                );

            foreach (string line in lines)
            {
                if (line.StartsWith("Exercises:"))
                {
                    exercises =
                        line.Substring(
                            "Exercises:".Length
                        ).Trim();
                }
                else if (line.StartsWith("Sets:"))
                {
                    sets =
                        line.Substring(
                            "Sets:".Length
                        ).Trim();
                }
                else if (line.StartsWith("Reps:"))
                {
                    reps =
                        line.Substring(
                            "Reps:".Length
                        ).Trim();
                }
            }
        }

        // =========================================================
        // DATAGRIDVIEW ROW CLICK
        // =========================================================
        private void dgvWorkouts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvWorkouts.Rows[e.RowIndex];

                // Workout ID
                if (row.Cells["WorkoutId"].Value != null)
                {
                    selectedWorkoutId =
                        Convert.ToInt32(
                            row.Cells["WorkoutId"].Value
                        );
                }

                // Member
                if (row.Cells["MemberId"].Value != null)
                {
                    cmbMember.SelectedValue =
                        Convert.ToInt32(
                            row.Cells["MemberId"].Value
                        );
                }

                // Workout Type
                cmbWorkoutType.Text =
                    row.Cells["WorkoutType"]
                        .Value?.ToString();

                // Goal
                cmbWorkoutGoal.Text =
                    row.Cells["WorkoutGoal"]
                        .Value?.ToString();

                // Duration
                txtDuration.Text =
                    row.Cells["Duration"]
                        .Value?.ToString();

                // Sets
                txtSets.Text =
                    row.Cells["Sets"]
                        .Value?.ToString();

                // Reps
                txtReps.Text =
                    row.Cells["Reps"]
                        .Value?.ToString();

                // -------------------------------------------------
                // CHECK SAVED EXERCISES
                // -------------------------------------------------
                string savedExercises =
                    row.Cells["Exercises"]
                        .Value?.ToString() ?? "";

                // Goal change হলে 5 exercises automatically load হবে.
                // তারপর saved exercise-গুলো check করব.
                LoadExercisesForGoal(
                    cmbWorkoutGoal.Text.Trim()
                );

                string[] selectedExercises =
                    savedExercises
                        .Split(
                            new[] { ',' },
                            StringSplitOptions.RemoveEmptyEntries
                        )
                        .Select(x => x.Trim())
                        .ToArray();

                for (int i = 0;
                     i < clbExercises.Items.Count;
                     i++)
                {
                    string exercise =
                        clbExercises.Items[i]
                            .ToString();

                    bool shouldCheck =
                        selectedExercises.Contains(
                            exercise,
                            StringComparer.OrdinalIgnoreCase
                        );

                    clbExercises.SetItemChecked(
                        i,
                        shouldCheck
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load selected workout.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD EXERCISES FOR A GOAL
        // =========================================================
        private void LoadExercisesForGoal(string goal)
        {
            clbExercises.Items.Clear();

            switch (goal)
            {
                case "Muscle Gain":

                    clbExercises.Items.Add("Bench Press");
                    clbExercises.Items.Add("Squat");
                    clbExercises.Items.Add("Deadlift");
                    clbExercises.Items.Add("Shoulder Press");
                    clbExercises.Items.Add("Barbell Row");

                    break;

                case "Weight Loss":

                    clbExercises.Items.Add("Treadmill Running");
                    clbExercises.Items.Add("Jump Rope");
                    clbExercises.Items.Add("Cycling");
                    clbExercises.Items.Add("Burpees");
                    clbExercises.Items.Add("Mountain Climbers");

                    break;

                case "Fat Loss":

                    clbExercises.Items.Add("HIIT");
                    clbExercises.Items.Add("Jump Rope");
                    clbExercises.Items.Add("Burpees");
                    clbExercises.Items.Add("Running");
                    clbExercises.Items.Add("Mountain Climbers");

                    break;

                case "Strength":

                    clbExercises.Items.Add("Squat");
                    clbExercises.Items.Add("Deadlift");
                    clbExercises.Items.Add("Bench Press");
                    clbExercises.Items.Add("Overhead Press");
                    clbExercises.Items.Add("Pull-Up");

                    break;

                case "Endurance":

                    clbExercises.Items.Add("Running");
                    clbExercises.Items.Add("Cycling");
                    clbExercises.Items.Add("Rowing");
                    clbExercises.Items.Add("Jump Rope");
                    clbExercises.Items.Add("Swimming");

                    break;

                case "General Fitness":

                    clbExercises.Items.Add("Squat");
                    clbExercises.Items.Add("Push-Up");
                    clbExercises.Items.Add("Plank");
                    clbExercises.Items.Add("Jogging");
                    clbExercises.Items.Add("Lunges");

                    break;

                case "Bodybuilding":

                    clbExercises.Items.Add("Bench Press");
                    clbExercises.Items.Add("Bicep Curl");
                    clbExercises.Items.Add("Tricep Extension");
                    clbExercises.Items.Add("Leg Press");
                    clbExercises.Items.Add("Lat Pulldown");

                    break;

                case "Rehabilitation":

                    clbExercises.Items.Add("Walking");
                    clbExercises.Items.Add("Light Cycling");
                    clbExercises.Items.Add("Stretching");
                    clbExercises.Items.Add("Mobility Exercise");
                    clbExercises.Items.Add("Balance Exercise");

                    break;

                case "Flexibility":

                    clbExercises.Items.Add("Hamstring Stretch");
                    clbExercises.Items.Add("Quad Stretch");
                    clbExercises.Items.Add("Shoulder Stretch");
                    clbExercises.Items.Add("Hip Stretch");
                    clbExercises.Items.Add("Cat-Cow Stretch");

                    break;
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }
    }
}