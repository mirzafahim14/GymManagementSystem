using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffInvoiceForm : Form
    {
        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public StaffInvoiceForm()
        {
            InitializeComponent();

            this.Load += StaffInvoiceForm_Load;

            cmbMember.SelectedIndexChanged +=
                cmbMember_SelectedIndexChanged;

            dgvMemberInvoices.CellClick +=
                dgvMemberInvoices_CellClick;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffInvoiceForm_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                SetupControls();

                LoadMembers();

                LoadMemberInvoices();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Member Invoice form could not be loaded.\n\n" +
                    ex.Message,
                    "Invoice Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // SETUP CONTROLS
        // =========================================================

        private void SetupControls()
        {
            txtInvoiceId.ReadOnly = true;
            txtMemberId.ReadOnly = true;
            txtMemberName.ReadOnly = true;
            txtPaymentId.ReadOnly = true;
            txtAmount.ReadOnly = true;

            cmbMember.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dtpInvoiceDate.Format =
                DateTimePickerFormat.Short;

            dtpInvoiceDate.Value =
                DateTime.Today;

            dgvMemberInvoices.ReadOnly = true;

            dgvMemberInvoices.AllowUserToAddRows =
                false;

            dgvMemberInvoices.AllowUserToDeleteRows =
                false;

            dgvMemberInvoices.AllowUserToResizeRows =
                false;

            dgvMemberInvoices.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvMemberInvoices.MultiSelect =
                false;

            dgvMemberInvoices.AutoGenerateColumns =
                true;

            dgvMemberInvoices.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMemberInvoices.RowHeadersVisible =
                false;
        }

        // =========================================================
        // LOAD MEMBERS
        // =========================================================

        private void LoadMembers()
        {
            try
            {
                string query = @"
                    SELECT
                        MemberId,
                        FullName
                    FROM Members
                    WHERE Status = 'Active'
                    ORDER BY FullName ASC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                cmbMember.DataSource = dt;

                cmbMember.DisplayMember =
                    "FullName";

                cmbMember.ValueMember =
                    "MemberId";

                cmbMember.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load members.\n\n" +
                    ex.Message,
                    "Member Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // MEMBER SELECTED
        // =========================================================

        private void cmbMember_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbMember.SelectedIndex == -1)
                {
                    txtMemberId.Clear();
                    txtMemberName.Clear();
                    txtPaymentId.Clear();
                    txtAmount.Clear();

                    return;
                }

                if (cmbMember.SelectedValue == null)
                    return;

                if (cmbMember.SelectedValue is DataRowView)
                    return;

                int memberId =
                    Convert.ToInt32(
                        cmbMember.SelectedValue
                    );

                txtMemberId.Text =
                    memberId.ToString();

                txtMemberName.Text =
                    cmbMember.Text.Trim();

                LoadLatestMemberPayment(memberId);
            }
            catch (Exception ex)
            {
                if (cmbMember.SelectedIndex != -1)
                {
                    MessageBox.Show(
                        "Could not load member payment information.\n\n" +
                        ex.Message,
                        "Payment Loading Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // =========================================================
        // LOAD LATEST MEMBER PAYMENT
        // =========================================================

        private void LoadLatestMemberPayment(
            int memberId)
        {
            try
            {
                string query = @"
                    SELECT TOP 1
                        PaymentId,
                        Amount,
                        PaymentDate,
                        Status
                    FROM Payments
                    WHERE MemberId = @MemberId
                    ORDER BY PaymentId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(
                        query,
                        new SqlParameter(
                            "@MemberId",
                            memberId
                        )
                    );

                if (dt.Rows.Count == 0)
                {
                    txtPaymentId.Clear();
                    txtAmount.Clear();

                    MessageBox.Show(
                        "No payment record found for this member.",
                        "Member Invoice",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                DataRow row = dt.Rows[0];

                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------

                if (row["PaymentId"] != DBNull.Value)
                {
                    txtPaymentId.Text =
                        Convert.ToString(
                            row["PaymentId"]
                        );
                }

                // -------------------------------------------------
                // AMOUNT
                // -------------------------------------------------

                if (row["Amount"] != DBNull.Value)
                {
                    decimal amount =
                        Convert.ToDecimal(
                            row["Amount"]
                        );

                    txtAmount.Text =
                        amount.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load member payment information.\n\n" +
                    ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // LOAD MEMBER INVOICES
        // =========================================================

        private void LoadMemberInvoices()
        {
            try
            {
                string query = @"
                    SELECT
                        i.InvoiceId,
                        i.MemberId,
                        m.FullName AS MemberName,
                        i.InvoiceDate,
                        i.PaymentId,
                        i.SubTotal,
                        i.Discount,
                        i.TotalAmount,
                        i.PaymentStatus,
                        i.Notes
                    FROM Invoices i
                    INNER JOIN Members m
                        ON i.MemberId = m.MemberId
                    ORDER BY
                        i.InvoiceId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvMemberInvoices.DataSource = dt;

                SetGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load member invoice records.\n\n" +
                    ex.Message,
                    "Invoice Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // GRID HEADERS
        // =========================================================

        private void SetGridHeaders()
        {
            if (dgvMemberInvoices.Columns.Contains(
                "InvoiceId"))
            {
                dgvMemberInvoices.Columns[
                    "InvoiceId"
                ].HeaderText = "Invoice ID";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "MemberId"))
            {
                dgvMemberInvoices.Columns[
                    "MemberId"
                ].HeaderText = "Member ID";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "MemberName"))
            {
                dgvMemberInvoices.Columns[
                    "MemberName"
                ].HeaderText = "Member Name";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "InvoiceDate"))
            {
                dgvMemberInvoices.Columns[
                    "InvoiceDate"
                ].HeaderText = "Invoice Date";

                dgvMemberInvoices.Columns[
                    "InvoiceDate"
                ].DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "PaymentId"))
            {
                dgvMemberInvoices.Columns[
                    "PaymentId"
                ].HeaderText = "Payment ID";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "SubTotal"))
            {
                dgvMemberInvoices.Columns[
                    "SubTotal"
                ].HeaderText = "Sub Total";

                dgvMemberInvoices.Columns[
                    "SubTotal"
                ].DefaultCellStyle.Format =
                    "0.00";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "Discount"))
            {
                dgvMemberInvoices.Columns[
                    "Discount"
                ].HeaderText = "Discount";

                dgvMemberInvoices.Columns[
                    "Discount"
                ].DefaultCellStyle.Format =
                    "0.00";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "TotalAmount"))
            {
                dgvMemberInvoices.Columns[
                    "TotalAmount"
                ].HeaderText = "Amount";

                dgvMemberInvoices.Columns[
                    "TotalAmount"
                ].DefaultCellStyle.Format =
                    "0.00";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "PaymentStatus"))
            {
                dgvMemberInvoices.Columns[
                    "PaymentStatus"
                ].HeaderText = "Status";
            }

            if (dgvMemberInvoices.Columns.Contains(
                "Notes"))
            {
                dgvMemberInvoices.Columns[
                    "Notes"
                ].HeaderText = "Notes";
            }

            dgvMemberInvoices.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =========================================================
        // SAVE
        // =========================================================

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // MEMBER VALIDATION
                // -------------------------------------------------

                if (cmbMember.SelectedIndex == -1 ||
                    cmbMember.SelectedValue == null ||
                    cmbMember.SelectedValue is DataRowView)
                {
                    MessageBox.Show(
                        "Please select a member.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbMember.Focus();

                    return;
                }

                // -------------------------------------------------
                // PAYMENT VALIDATION
                // -------------------------------------------------

                if (string.IsNullOrWhiteSpace(
                    txtPaymentId.Text))
                {
                    MessageBox.Show(
                        "No payment record found for this member.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // -------------------------------------------------
                // AMOUNT VALIDATION
                // -------------------------------------------------

                decimal amount;

                if (!decimal.TryParse(
                    txtAmount.Text.Trim(),
                    out amount))
                {
                    MessageBox.Show(
                        "Invalid payment amount.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show(
                        "Payment amount must be greater than 0.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // -------------------------------------------------
                // VALUES
                // -------------------------------------------------

                int memberId =
                    Convert.ToInt32(
                        cmbMember.SelectedValue
                    );

                int paymentId =
                    Convert.ToInt32(
                        txtPaymentId.Text
                    );

                DateTime invoiceDate =
                    dtpInvoiceDate.Value.Date;

                decimal subTotal =
                    amount;

                decimal discount =
                    0;

                decimal totalAmount =
                    subTotal - discount;

                string paymentStatus =
                    "Paid";

                // -------------------------------------------------
                // GET PAYMENT STATUS
                // -------------------------------------------------

                string statusQuery = @"
                    SELECT Status
                    FROM Payments
                    WHERE PaymentId = @PaymentId";

                object statusResult =
                    DbHelper.ExecuteScalar(
                        statusQuery,
                        new SqlParameter(
                            "@PaymentId",
                            paymentId
                        )
                    );

                if (statusResult != null &&
                    statusResult != DBNull.Value)
                {
                    paymentStatus =
                        Convert.ToString(
                            statusResult
                        );
                }

                // -------------------------------------------------
                // DUPLICATE CHECK
                // -------------------------------------------------

                string duplicateQuery = @"
                    SELECT COUNT(*)
                    FROM Invoices
                    WHERE PaymentId = @PaymentId";

                object duplicateResult =
                    DbHelper.ExecuteScalar(
                        duplicateQuery,
                        new SqlParameter(
                            "@PaymentId",
                            paymentId
                        )
                    );

                int duplicateCount =
                    Convert.ToInt32(
                        duplicateResult
                    );

                if (duplicateCount > 0)
                {
                    MessageBox.Show(
                        "An invoice already exists for this payment.",
                        "Duplicate Invoice",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // -------------------------------------------------
                // GENERATE INVOICE NUMBER
                // -------------------------------------------------

                string invoiceNumber =
                    GenerateInvoiceNumber();

                // -------------------------------------------------
                // INSERT
                // -------------------------------------------------

                string query = @"
                    INSERT INTO Invoices
                    (
                        InvoiceNumber,
                        MemberId,
                        PaymentId,
                        InvoiceDate,
                        SubTotal,
                        Discount,
                        TotalAmount,
                        PaymentStatus,
                        Notes
                    )
                    VALUES
                    (
                        @InvoiceNumber,
                        @MemberId,
                        @PaymentId,
                        @InvoiceDate,
                        @SubTotal,
                        @Discount,
                        @TotalAmount,
                        @PaymentStatus,
                        @Notes
                    )";

                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@InvoiceNumber",
                            invoiceNumber
                        ),

                        new SqlParameter(
                            "@MemberId",
                            memberId
                        ),

                        new SqlParameter(
                            "@PaymentId",
                            paymentId
                        ),

                        new SqlParameter(
                            "@InvoiceDate",
                            invoiceDate
                        ),

                        new SqlParameter(
                            "@SubTotal",
                            subTotal
                        ),

                        new SqlParameter(
                            "@Discount",
                            discount
                        ),

                        new SqlParameter(
                            "@TotalAmount",
                            totalAmount
                        ),

                        new SqlParameter(
                            "@PaymentStatus",
                            paymentStatus
                        ),

                        new SqlParameter(
                            "@Notes",
                            DBNull.Value
                        )
                    );

                if (result > 0)
                {
                    MessageBox.Show(
                        "Member invoice saved successfully.\n\n" +
                        "Invoice Number: " +
                        invoiceNumber,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadMemberInvoices();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Member invoice could not be saved.",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save member invoice.\n\n" +
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================================================
        // GENERATE INVOICE NUMBER
        // =========================================================

        private string GenerateInvoiceNumber()
        {
            try
            {
                string query = @"
                    SELECT ISNULL(MAX(InvoiceId), 0) + 1
                    FROM Invoices";

                object result =
                    DbHelper.ExecuteScalar(query);

                int nextId =
                    Convert.ToInt32(result);

                return "INV-" +
                       nextId.ToString("D6");
            }
            catch
            {
                return "INV-" +
                       DateTime.Now.ToString(
                           "yyyyMMddHHmmss"
                       );
            }
        }

        // =========================================================
        // CLEAR
        // =========================================================

        private void ClearFields()
        {
            txtInvoiceId.Clear();

            cmbMember.SelectedIndex = -1;

            txtMemberId.Clear();

            txtMemberName.Clear();

            dtpInvoiceDate.Value =
                DateTime.Today;

            txtPaymentId.Clear();

            txtAmount.Clear();

            dgvMemberInvoices.ClearSelection();
        }

        // =========================================================
        // CLEAR BUTTON
        // =========================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        // =========================================================
        // GRID CLICK
        // =========================================================

        private void dgvMemberInvoices_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvMemberInvoices.Rows[
                        e.RowIndex
                    ];

                // -------------------------------------------------
                // INVOICE ID
                // -------------------------------------------------

                if (row.Cells["InvoiceId"].Value != null &&
                    row.Cells["InvoiceId"].Value != DBNull.Value)
                {
                    txtInvoiceId.Text =
                        row.Cells[
                            "InvoiceId"
                        ].Value.ToString();
                }

                // -------------------------------------------------
                // MEMBER
                // -------------------------------------------------

                if (row.Cells["MemberId"].Value != null &&
                    row.Cells["MemberId"].Value != DBNull.Value)
                {
                    int memberId =
                        Convert.ToInt32(
                            row.Cells[
                                "MemberId"
                            ].Value
                        );

                    cmbMember.SelectedValue =
                        memberId;

                    txtMemberId.Text =
                        memberId.ToString();
                }

                // -------------------------------------------------
                // MEMBER NAME
                // -------------------------------------------------

                if (row.Cells["MemberName"].Value != null)
                {
                    txtMemberName.Text =
                        row.Cells[
                            "MemberName"
                        ].Value.ToString();
                }

                // -------------------------------------------------
                // INVOICE DATE
                // -------------------------------------------------

                if (row.Cells["InvoiceDate"].Value != null &&
                    row.Cells["InvoiceDate"].Value != DBNull.Value)
                {
                    dtpInvoiceDate.Value =
                        Convert.ToDateTime(
                            row.Cells[
                                "InvoiceDate"
                            ].Value
                        );
                }

                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------

                if (row.Cells["PaymentId"].Value != null &&
                    row.Cells["PaymentId"].Value != DBNull.Value)
                {
                    txtPaymentId.Text =
                        row.Cells[
                            "PaymentId"
                        ].Value.ToString();
                }

                // -------------------------------------------------
                // AMOUNT
                // -------------------------------------------------

                if (row.Cells["TotalAmount"].Value != null &&
                    row.Cells["TotalAmount"].Value != DBNull.Value)
                {
                    decimal amount =
                        Convert.ToDecimal(
                            row.Cells[
                                "TotalAmount"
                            ].Value
                        );

                    txtAmount.Text =
                        amount.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not select member invoice record.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}