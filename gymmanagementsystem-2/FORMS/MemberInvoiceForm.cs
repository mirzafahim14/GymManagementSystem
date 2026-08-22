using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class MemberInvoiceForm : Form
    {
        // =========================================================
        // LOGGED-IN MEMBER ID
        // =========================================================

        private readonly int _memberId;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public MemberInvoiceForm(int memberId)
        {
            InitializeComponent();

            _memberId = memberId;

            // Form Load event
            this.Load += MemberInvoiceForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================

        private void MemberInvoiceForm_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                LoadMemberInformation();
                LoadInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load My Invoices.\n\n" +
                    ex.Message,
                    "Invoice Error",
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


            // =====================================================
            // MEMBER NOT FOUND
            // =====================================================

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


            // =====================================================
            // GET MEMBER ROW
            // =====================================================

            DataRow row = table.Rows[0];


            // =====================================================
            // DISPLAY MEMBER ID
            // =====================================================

            lblMemberId.Text =
                "Member ID: " +
                GetString(row["MemberId"]);


            // =====================================================
            // DISPLAY MEMBER NAME
            // =====================================================

            lblMemberName.Text =
                "Member Name: " +
                GetString(row["FullName"]);
        }


        // =========================================================
        // LOAD INVOICES
        // =========================================================

        private void LoadInvoices()
        {
            string query = @"
                SELECT
                    InvoiceId,
                    InvoiceNumber,
                    MemberId,
                    PaymentId,
                    InvoiceDate,
                    SubTotal,
                    Discount,
                    TotalAmount,
                    PaymentStatus,
                    Notes
                FROM Invoices
                WHERE MemberId = @MemberId
                ORDER BY InvoiceDate DESC, InvoiceId DESC;
            ";


            DataTable table = DbHelper.ExecuteQuery(
                query,
                new SqlParameter("@MemberId", _memberId)
            );


            // =====================================================
            // CLEAR OLD DATA
            // =====================================================

            dgvInvoices.Rows.Clear();


            // =====================================================
            // TOTAL AMOUNT
            // =====================================================

            decimal totalAmount = 0m;


            // =====================================================
            // ADD DATABASE DATA TO DATAGRIDVIEW
            // =====================================================

            foreach (DataRow row in table.Rows)
            {
                string invoiceNumber =
                    GetString(row["InvoiceNumber"]);


                string invoiceDate =
                    FormatDate(row["InvoiceDate"]);


                decimal subTotal =
                    GetDecimal(row["SubTotal"]);


                decimal discount =
                    GetDecimal(row["Discount"]);


                decimal total =
                    GetDecimal(row["TotalAmount"]);


                string paymentStatus =
                    GetString(row["PaymentStatus"]);


                // =================================================
                // ADD ROW
                // =================================================

                dgvInvoices.Rows.Add(
                    invoiceNumber,
                    invoiceDate,
                    subTotal.ToString("0.00"),
                    discount.ToString("0.00"),
                    total.ToString("0.00"),
                    paymentStatus
                );


                // =================================================
                // CALCULATE TOTAL
                // =================================================

                totalAmount += total;
            }


            // =====================================================
            // DISPLAY SUMMARY
            // =====================================================

            IbInvoiceNo.Text =
                "Total Invoices: " +
                table.Rows.Count;


            lblTotalAmount.Text =
                "Total Amount: " +
                totalAmount.ToString("0.00");
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
                LoadMemberInformation();

                LoadInvoices();

                MessageBox.Show(
                    "Invoice information refreshed successfully.",
                    "Refresh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to refresh invoices.\n\n" +
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

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }


        // =========================================================
        // SAFE STRING CONVERSION
        // =========================================================

        private string GetString(object value)
        {
            if (value == null ||
                value == DBNull.Value)
            {
                return "—";
            }


            string text =
                value.ToString();


            if (string.IsNullOrWhiteSpace(text))
            {
                return "—";
            }


            return text;
        }


        // =========================================================
        // SAFE DECIMAL CONVERSION
        // =========================================================

        private decimal GetDecimal(object value)
        {
            if (value == null ||
                value == DBNull.Value)
            {
                return 0m;
            }


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
            if (value == null ||
                value == DBNull.Value)
            {
                return "—";
            }


            if (DateTime.TryParse(
                value.ToString(),
                out DateTime date))
            {
                return date.ToString(
                    "dd MMM yyyy");
            }


            return "—";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}