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
                LoadPaymentSummary();
                LoadPaymentHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load payment information.\n\n" +
                    ex.Message,
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
        // LOAD PAYMENT SUMMARY
        // =========================================================
        private void LoadPaymentSummary()
        {
            string query = @"
                SELECT
                    COUNT(*) AS TotalPayments,
                    ISNULL(SUM(Amount), 0) AS TotalAmount
                FROM Payments
                WHERE MemberId = @MemberId;
            ";

            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );

            if (table.Rows.Count == 0)
            {
                lblTotalPayments.Text =
                    "Total Payments: 0";

                lblTotalAmount.Text =
                    "Total Amount Paid: ৳0.00";

                return;
            }

            DataRow row = table.Rows[0];

            int totalPayments = 0;
            decimal totalAmount = 0m;

            if (row["TotalPayments"] != DBNull.Value)
            {
                totalPayments =
                    Convert.ToInt32(row["TotalPayments"]);
            }

            if (row["TotalAmount"] != DBNull.Value)
            {
                totalAmount =
                    Convert.ToDecimal(row["TotalAmount"]);
            }

            lblTotalPayments.Text =
                "Total Payments: " + totalPayments;

            lblTotalAmount.Text =
                "Total Amount Paid: ৳" +
                totalAmount.ToString("N2");
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

            // Clear previous data
            dgvPayments.Rows.Clear();

            // =====================================================
            // ADD DATA TO DATAGRIDVIEW
            // =====================================================

            foreach (DataRow row in table.Rows)
            {
                int rowIndex = dgvPayments.Rows.Add();

                dgvPayments.Rows[rowIndex].Cells[
                    "colPaymentDate"
                ].Value = FormatDate(row["PaymentDate"]);

                dgvPayments.Rows[rowIndex].Cells[
                    "colAmount"
                ].Value = FormatAmount(row["Amount"]);

                dgvPayments.Rows[rowIndex].Cells[
                    "colPaymentMethod"
                ].Value = GetString(row["PaymentMethod"]);

                dgvPayments.Rows[rowIndex].Cells[
                    "colTransactionReference"
                ].Value = GetString(
                    row["TransactionReference"]
                );

                dgvPayments.Rows[rowIndex].Cells[
                    "colStatus"
                ].Value = GetString(row["Status"]);

                dgvPayments.Rows[rowIndex].Cells[
                    "colNotes"
                ].Value = GetString(row["Notes"]);

                dgvPayments.Rows[rowIndex].Cells[
                    "colPaymentId"
                ].Value = GetString(row["PaymentId"]);
            }

            // =====================================================
            // NO PAYMENT MESSAGE
            // =====================================================

            if (table.Rows.Count == 0)
            {
                // Keep DataGridView empty.
                // Summary will show 0.
            }
        }


        // =========================================================
        // REFRESH BUTTON
        // =========================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadPaymentSummary();
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
                    "Failed to refresh payment information.\n\n" +
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


        // =========================================================
        // AMOUNT FORMAT
        // =========================================================
        private string FormatAmount(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "৳0.00";
            }

            if (decimal.TryParse(
                value.ToString(),
                out decimal amount))
            {
                return "৳" + amount.ToString("N2");
            }

            return "৳0.00";
        }
    }
}