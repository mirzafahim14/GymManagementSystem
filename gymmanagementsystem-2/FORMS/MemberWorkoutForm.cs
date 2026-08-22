using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberWorkoutForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================
        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberWorkoutForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            // Form Load event
            this.Load += MemberWorkoutForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberWorkoutForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadWorkoutPlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load workout information.\n\n" +
                    ex.Message,
                    "Workout Error",
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
                "Member ID: " + GetString(row["MemberId"]);

            lblMemberName.Text =
                "Member Name: " + GetString(row["FullName"]);
        }


        // =========================================================
        // LOAD WORKOUT PLAN
        // =========================================================
        private void LoadWorkoutPlan()
        {
            string query = @"
                SELECT TOP 1
                    wp.WorkoutPlanId,
                    wp.MemberId,
                    wp.TrainerId,
                    wp.PlanName,
                    wp.Goal,
                    wp.Description,
                    wp.StartDate,
                    wp.EndDate,
                    wp.Status,
                    wp.CreatedAt,

                    t.FullName AS TrainerName

                FROM WorkoutPlans wp

                LEFT JOIN Trainers t
                    ON wp.TrainerId = t.TrainerId

                WHERE wp.MemberId = @MemberId

                ORDER BY wp.CreatedAt DESC, wp.WorkoutPlanId DESC;
            ";


            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );


            // =====================================================
            // NO WORKOUT PLAN
            // =====================================================

            if (table.Rows.Count == 0)
            {
                ClearWorkoutInformation();

                MessageBox.Show(
                    "No workout plan has been assigned to you yet.",
                    "Workout Plan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }


            // =====================================================
            // GET FIRST / LATEST WORKOUT PLAN
            // =====================================================

            DataRow row = table.Rows[0];


            // =====================================================
            // PLAN NAME
            // =====================================================

            lblPlanNameValue.Text =
                GetString(row["PlanName"]);


            // =====================================================
            // GOAL
            // =====================================================

            lblGoalTitle.Text =
                "Goal: " + GetString(row["Goal"]);


            // =====================================================
            // DESCRIPTION
            // =====================================================

            lblDescription.Text =
                "Description: " + GetString(row["Description"]);


            // =====================================================
            // TRAINER
            // =====================================================

            string trainerName = GetString(row["TrainerName"]);

            if (trainerName == "—")
            {
                trainerName = "Not Assigned";
            }

            lblTrainerValue.Text =
                "Trainer: " + trainerName;


            // =====================================================
            // STATUS
            // =====================================================

            string status = GetString(row["Status"]);

            lblStatusValue.Text =
                "Status: " + status;


            // =====================================================
            // START DATE
            // =====================================================

            lblStartDate.Text =
                "Start Date: " +
                FormatDate(row["StartDate"]);


            // =====================================================
            // END DATE
            // =====================================================

            lblEndDate.Text =
                "End Date: " +
                FormatDate(row["EndDate"]);
        }


        // =========================================================
        // CLEAR WORKOUT INFORMATION
        // =========================================================
        private void ClearWorkoutInformation()
        {
            lblPlanNameValue.Text = "—";

            lblGoalTitle.Text =
                "Goal: —";

            lblDescription.Text =
                "Description: —";

            lblTrainerValue.Text =
                "Trainer: —";

            lblStatusValue.Text =
                "Status: —";

            lblStartDate.Text =
                "Start Date: —";

            lblEndDate.Text =
                "End Date: —";
        }


        // =========================================================
        // REFRESH BUTTON
        // =========================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadWorkoutPlan();

                MessageBox.Show(
                    "Workout information refreshed successfully.",
                    "Refresh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to refresh workout information.\n\n" +
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
            {
                return "—";
            }

            string text = value.ToString();

            if (string.IsNullOrWhiteSpace(text))
            {
                return "—";
            }

            return text;
        }


        // =========================================================
        // DATE FORMAT
        // =========================================================
        private string FormatDate(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "—";
            }

            if (DateTime.TryParse(
                value.ToString(),
                out DateTime date))
            {
                return date.ToString("dd MMM yyyy");
            }

            return "—";
        }
    }
}