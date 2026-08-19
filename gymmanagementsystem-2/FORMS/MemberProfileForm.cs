using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2
{
    public partial class MemberProfileForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================
        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberProfileForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            this.Load += MemberProfileForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberProfileForm_Load(object sender, EventArgs e)
        {
            LoadMemberProfile();
        }


        // =========================================================
        // LOAD MEMBER PROFILE FROM DATABASE
        // =========================================================
        private void LoadMemberProfile()
        {
            try
            {
                string query = @"
                    SELECT
                        m.MemberId,
                        m.FullName,
                        m.Gender,
                        m.DateOfBirth,
                        m.Email,
                        m.Phone,
                        m.Address,
                        m.JoinDate,
                        m.MembershipStartDate,
                        m.MembershipEndDate,
                        m.Status,
                        m.ExpiryDate,
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


                // =====================================================
                // MEMBER NOT FOUND
                // =====================================================
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Member information not found.",
                        "Member Profile",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                DataRow row = table.Rows[0];


                // =====================================================
                // BASIC INFORMATION
                // =====================================================

                lblMemberId.Text =
                    "Member ID: " +
                    GetString(row["MemberId"]);

                lblFullName.Text =
                    "Full Name: " +
                    GetString(row["FullName"]);

                lblGender.Text =
                    "Gender: " +
                    GetString(row["Gender"]);

                lblDateOfBirth.Text =
                    "Date of Birth: " +
                    FormatDate(row["DateOfBirth"]);

                lblEmail.Text =
                    "Email: " +
                    GetString(row["Email"]);

                lblPhone.Text =
                    "Phone: " +
                    GetString(row["Phone"]);

                lblAddress.Text =
                    "Address: " +
                    GetString(row["Address"]);

                lblJoinDate.Text =
                    "Join Date: " +
                    FormatDate(row["JoinDate"]);


                // =====================================================
                // MEMBERSHIP INFORMATION
                // =====================================================

                lblPlan.Text =
                    "Membership Plan: " +
                    GetString(row["PlanName"]);

                lblMembershipStart.Text =
                    "Membership Start: " +
                    FormatDate(row["MembershipStartDate"]);

                lblMembershipEnd.Text =
                    "Membership End: " +
                    FormatDate(row["MembershipEndDate"]);

                lblStatus.Text =
                    "Status: " +
                    GetString(row["Status"]);

                lblExpiryDate.Text =
                    "Expiry Date: " +
                    FormatDate(row["ExpiryDate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load member profile.\n\n" +
                    ex.Message,
                    "Profile Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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
        // EDIT PROFILE
        // =========================================================
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Edit Profile feature will be added next.",
                "Edit Profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // CLOSE
        // =========================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}