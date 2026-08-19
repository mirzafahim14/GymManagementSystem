using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberDashboardForm : Form
    {
        private readonly int _memberId;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberDashboardForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            this.Load += MemberDashboardForm_Load;

            // Quick Access buttons
            btnQuickAttendance.Click += btnMyAttendance_Click;
            btnQuickPayment.Click += btnMyPayments_Click;
            btnQuickInvoice.Click += btnMyInvoices_Click;
            btnQuickWorkout.Click += btnMyWorkout_Click;
            btnQuickHealth.Click += btnMyHealth_Click;
            btnQuickProfile.Click += btnMyProfile_Click;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblCurrentDate.Text =
                    "Date: " + DateTime.Now.ToString("dd MMMM yyyy");

                LoadMemberDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load member dashboard.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LOAD MEMBER INFORMATION
        // =========================================================
        private void LoadMemberDashboard()
        {
            string query = @"
                SELECT
                    m.MemberId,
                    m.FullName,
                    m.Gender,
                    m.Phone,
                    m.Email,
                    m.Status,
                   m.MembershipStartDate, m.MembershipEndDate,
                    mp.PlanName
                FROM Members m
                LEFT JOIN MembershipPlans mp
                    ON m.PlanId = mp.PlanId
                WHERE m.MemberId = @MemberId;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );

            if (table.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Member information not found.",
                    "Member Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataRow row = table.Rows[0];


            // =====================================================
            // BASIC INFORMATION
            // =====================================================

            lblMemberName.Text =
                "Member Name: " + GetString(row["FullName"]);

            lblMemberRole.Text =
                "Role: Member";

            lblMemberId.Text =
                "Member ID: " + GetString(row["MemberId"]);

            lblFullName.Text =
                "Full Name: " + GetString(row["FullName"]);

            lblPhone.Text =
                "Phone: " + GetString(row["Phone"]);

            lblEmail.Text =
                "Email: " + GetString(row["Email"]);

            lblGender.Text =
                "Gender: " + GetString(row["Gender"]);

            lblMembershipPlan.Text =
                "Membership Plan: " + GetString(row["PlanName"]);


            // =====================================================
            // MEMBERSHIP INFORMATION
            // =====================================================

            lblPlanName.Text =
                "Plan: " + GetString(row["PlanName"]);

            lblStartDate.Text =
                "Start Date: " + FormatDate(row["MembershipStartDate"]);

            lblExpiryDate.Text =
                "Expiry Date: " + FormatDate(row["MembershipEndDate"]);

            lblStatus.Text =
                "Status: " + GetString(row["Status"]);

            lblMembershipStatus.Text =
                "Membership Status: " + GetString(row["Status"]);


            // =====================================================
            // SYSTEM STATUS
            // =====================================================

            lblSystemStatus.Text =
                "SYSTEM STATUS\nONLINE";
        }


        // =========================================================
        // SAFE STRING
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
        // MY PROFILE
        // =========================================================
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "My Profile module will be added next.",
                "My Profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // MY ATTENDANCE
        // =========================================================
        private void btnMyAttendance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "My Attendance module will be added next.",
                "My Attendance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // MY PAYMENTS
        // =========================================================
        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "My Payments module will be added next.",
                "My Payments",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // MY INVOICES
        // =========================================================
        private void btnMyInvoices_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "My Invoices module will be added next.",
                "My Invoices",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // MY WORKOUT
        // =========================================================
        private void btnMyWorkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "My Workout module will be added next.",
                "My Workout",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // MY HEALTH
        // =========================================================
        private void btnMyHealth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "My Health module will be added next.",
                "My Health",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // LOGOUT
        // =========================================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        // =========================================================
        // DESIGNER EVENTS
        // =========================================================

        private void lblPlanName_Click(object sender, EventArgs e)
        {
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
        }

        private void lblMemberId_Click(object sender, EventArgs e)
        {
        }

        private void lblMedicalCondition_Click(object sender, EventArgs e)
        {
        }
    }
}