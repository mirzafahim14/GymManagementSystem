using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberPaymentForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================
        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================
        public MemberPaymentForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            // Form Load
            this.Load += MemberPaymentForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void MemberPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadPaymentHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load payment information.\n\n" + ex.Message,
                    "Payment Error",
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
                    "Member information not found.",
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
        // LOAD PAYMENT HISTORY
        // =========================================================
        private void LoadPaymentHistory()
        {
            string query = @"
                SELECT
                    PaymentId,
                    PaymentDate,
                    Amount,
                    PaymentMethod,
                    TransactionReference,
                    Status,
                    Notes
                FROM Payments
                WHERE MemberId = @MemberId
                ORDER BY PaymentDate DESC, PaymentId DESC;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );

            // =====================================================
            // CLEAR OLD DATA
            // =====================================================

            dgvPayments.Rows.Clear();


            // =====================================================
            // VARIABLES FOR SUMMARY
            // =====================================================

            int totalPayments = 0;
            decimal totalAmount = 0;


            // =====================================================
            // ADD PAYMENT RECORDS
            // =====================================================

            foreach (DataRow row in table.Rows)
            {
                totalPayments++;

                decimal amount = GetDecimal(row["Amount"]);

                totalAmount += amount;

                dgvPayments.Rows.Add(
                    FormatDate(row["PaymentDate"]),
                    amount.ToString("N2"),
                    GetString(row["PaymentMethod"]),
                    GetString(row["TransactionReference"]),
                    GetString(row["Status"]),
                    GetString(row["Notes"]),
                    GetString(row["PaymentId"])
                );
            }


            // =====================================================
            // UPDATE SUMMARY
            // =====================================================

            lblTotalPayments.Text =
                "Total Payments: " + totalPayments;

            lblTotalAmount.Text =
                "Total Amount Paid: " + totalAmount.ToString("N2");
        }


        // =========================================================
        // REFRESH BUTTON
        // =========================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadPaymentHistory();

                MessageBox.Show(
                    "Payment information refreshed successfully.",
                    "Refresh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to refresh payment information.\n\n" + ex.Message,
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
                return "—";

            string text = value.ToString();

            if (string.IsNullOrWhiteSpace(text))
                return "—";

            return text;
        }


        // =========================================================
        // SAFE DECIMAL CONVERSION
        // =========================================================
        private decimal GetDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
                return 0m;

            if (decimal.TryParse(
                value.ToString(),
                out decimal result))
            {
                return result;
            }

            return 0m;
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }
    }
}