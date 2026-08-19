using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();

            // =====================================================
            // EVENTS
            // =====================================================

            // Member select করলে Payment ID + Amount automatic load হবে
            cmbMember.SelectedIndexChanged += cmbMember_SelectedIndexChanged;

            // Grid row click
            dgvInvoices.CellClick += dgvInvoices_CellClick;

            // Form Load
            this.Load += InvoiceForm_Load;
        }


        // =====================================================
        // FORM LOAD
        // =====================================================

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupControls();

                LoadMembers();

                LoadInvoices();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Invoice form could not be loaded.\n\n" +
                    ex.Message,
                    "Invoice Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // SETUP CONTROLS
        // =====================================================

        private void SetupControls()
        {
            // Invoice ID automatic
            txtInvoiceId.ReadOnly = true;

            // Payment ID automatic
            txtPaymentId.ReadOnly = true;

            // Amount automatic
            txtAmount.ReadOnly = true;

            // Member ComboBox
            cmbMember.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Invoice Date
            dtpInvoiceDate.Format =
                DateTimePickerFormat.Short;

            dtpInvoiceDate.Value =
                DateTime.Today;

            // DataGridView
            dgvInvoices.ReadOnly = true;

            dgvInvoices.AllowUserToAddRows = false;

            dgvInvoices.AllowUserToDeleteRows = false;

            dgvInvoices.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvInvoices.MultiSelect = false;

            // Designer-এর columns ব্যবহার করছি
            dgvInvoices.AutoGenerateColumns = false;

            ConfigureGridColumns();
        }


        // =====================================================
        // CONFIGURE GRID COLUMNS
        // =====================================================

        private void ConfigureGridColumns()
        {
            // -------------------------------------------------
            // Invoice ID
            // -------------------------------------------------

            if (dgvInvoices.Columns.Contains("InvoiceId"))
            {
                dgvInvoices.Columns["InvoiceId"].DataPropertyName =
                    "InvoiceId";

                dgvInvoices.Columns["InvoiceId"].HeaderText =
                    "Invoice ID";
            }


            // -------------------------------------------------
            // Member ID
            // -------------------------------------------------

            if (dgvInvoices.Columns.Contains("MemberId"))
            {
                dgvInvoices.Columns["MemberId"].DataPropertyName =
                    "MemberId";

                dgvInvoices.Columns["MemberId"].HeaderText =
                    "Member ID";
            }


            // -------------------------------------------------
            // Invoice Date
            // -------------------------------------------------

            if (dgvInvoices.Columns.Contains("InvoiceDate"))
            {
                dgvInvoices.Columns["InvoiceDate"].DataPropertyName =
                    "InvoiceDate";

                dgvInvoices.Columns["InvoiceDate"].HeaderText =
                    "Invoice Date";

                dgvInvoices.Columns["InvoiceDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }


            // -------------------------------------------------
            // Payment ID
            // -------------------------------------------------

            if (dgvInvoices.Columns.Contains("PaymentId"))
            {
                dgvInvoices.Columns["PaymentId"].DataPropertyName =
                    "PaymentId";

                dgvInvoices.Columns["PaymentId"].HeaderText =
                    "Payment ID";
            }


            // -------------------------------------------------
            // Amount
            // -------------------------------------------------

            if (dgvInvoices.Columns.Contains("Amount"))
            {
                // Database-এর computed TotalAmount
                dgvInvoices.Columns["Amount"].DataPropertyName =
                    "TotalAmount";

                dgvInvoices.Columns["Amount"].HeaderText =
                    "Amount";

                dgvInvoices.Columns["Amount"]
                    .DefaultCellStyle.Format =
                    "0.00";
            }


            // -------------------------------------------------
            // Status
            // -------------------------------------------------

            if (dgvInvoices.Columns.Contains("Status"))
            {
                dgvInvoices.Columns["Status"].DataPropertyName =
                    "PaymentStatus";

                dgvInvoices.Columns["Status"].HeaderText =
                    "Status";
            }


            dgvInvoices.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


        // =====================================================
        // LOAD MEMBERS
        // =====================================================

        private void LoadMembers()
        {
            try
            {
                string query = @"
                    SELECT
                        MemberId,
                        FullName
                    FROM Members
                    ORDER BY MemberId ASC";

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


        // =====================================================
        // MEMBER SELECTED
        // =====================================================

        private void cmbMember_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                // Nothing selected
                if (cmbMember.SelectedIndex == -1)
                {
                    txtPaymentId.Clear();
                    txtAmount.Clear();

                    return;
                }

                // ComboBox loading stage
                if (cmbMember.SelectedValue == null)
                {
                    return;
                }

                // DataRowView during initialization
                if (cmbMember.SelectedValue is DataRowView)
                {
                    return;
                }

                int memberId =
                    Convert.ToInt32(
                        cmbMember.SelectedValue
                    );

                LoadLatestPayment(memberId);
            }
            catch (Exception ex)
            {
                // Initialization-এর সময় unnecessary error দেখাবো না
                if (cmbMember.SelectedIndex != -1)
                {
                    MessageBox.Show(
                        "Could not load payment information.\n\n" +
                        ex.Message,
                        "Payment Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        // =====================================================
        // LOAD LATEST PAYMENT
        // =====================================================

        private void LoadLatestPayment(int memberId)
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


                // -------------------------------------------------
                // NO PAYMENT FOUND
                // -------------------------------------------------

                if (dt.Rows.Count == 0)
                {
                    txtPaymentId.Clear();
                    txtAmount.Clear();

                    MessageBox.Show(
                        "No payment record found for this member.",
                        "Invoice",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }


                // -------------------------------------------------
                // GET PAYMENT ROW
                // -------------------------------------------------

                DataRow row =
                    dt.Rows[0];


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
                else
                {
                    txtAmount.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load payment information.\n\n" +
                    ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // GENERATE INVOICE NUMBER
        // =====================================================

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


        // =====================================================
        // LOAD INVOICES
        // =====================================================

        private void LoadInvoices()
        {
            try
            {
                string query = @"
                    SELECT
                        InvoiceId,
                        MemberId,
                        PaymentId,
                        InvoiceDate,
                        TotalAmount,
                        PaymentStatus
                    FROM Invoices
                    ORDER BY InvoiceId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvInvoices.DataSource = dt;

                ConfigureGridColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load invoice records.\n\n" +
                    ex.Message,
                    "Invoice Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // SAVE INVOICE
        // =====================================================

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // =================================================
                // 1. MEMBER VALIDATION
                // =================================================

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


                // =================================================
                // 2. PAYMENT ID VALIDATION
                // =================================================

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


                // =================================================
                // 3. AMOUNT VALIDATION
                // =================================================

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


                // =================================================
                // 4. GET VALUES
                // =================================================

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


                // =================================================
                // 5. GET PAYMENT STATUS
                // =================================================

                string paymentStatus =
                    "Paid";

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


                // =================================================
                // 6. CHECK DUPLICATE PAYMENT
                // =================================================

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


                // =================================================
                // 7. GENERATE INVOICE NUMBER
                // =================================================

                string invoiceNumber =
                    GenerateInvoiceNumber();


                // =================================================
                // 8. INSERT INVOICE
                //
                // IMPORTANT:
                // TotalAmount এখানে দেওয়া হয়নি।
                //
                // কারণ SQL Server-এ TotalAmount
                // COMPUTED COLUMN।
                //
                // Database নিজেই:
                // TotalAmount = SubTotal - Discount
                // calculate করবে.
                // =================================================

                string query = @"
                    INSERT INTO Invoices
                    (
                        InvoiceNumber,
                        MemberId,
                        PaymentId,
                        InvoiceDate,
                        SubTotal,
                        Discount,
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
                            "@PaymentStatus",
                            paymentStatus
                        ),

                        new SqlParameter(
                            "@Notes",
                            DBNull.Value
                        )
                    );


                // =================================================
                // 9. SUCCESS
                // =================================================

                if (result > 0)
                {
                    MessageBox.Show(
                        "Invoice saved successfully.\n\n" +
                        "Invoice Number: " +
                        invoiceNumber,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );


                    // Refresh grid
                    LoadInvoices();

                    // Clear input fields
                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Invoice could not be saved.",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save invoice.\n\n" +
                    ex.Message,
                    "Invoice Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // CLEAR FIELDS
        // =====================================================

        private void ClearFields()
        {
            txtInvoiceId.Clear();

            cmbMember.SelectedIndex = -1;

            dtpInvoiceDate.Value =
                DateTime.Today;

            txtPaymentId.Clear();

            txtAmount.Clear();
        }


        // =====================================================
        // CLEAR BUTTON
        // =====================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }


        // =====================================================
        // DATAGRIDVIEW ROW CLICK
        // =====================================================

        private void dgvInvoices_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                DataGridViewRow row =
                    dgvInvoices.Rows[e.RowIndex];


                // -------------------------------------------------
                // INVOICE ID
                // -------------------------------------------------

                if (row.Cells["InvoiceId"].Value != null &&
                    row.Cells["InvoiceId"].Value != DBNull.Value)
                {
                    txtInvoiceId.Text =
                        Convert.ToString(
                            row.Cells["InvoiceId"].Value
                        );
                }


                // -------------------------------------------------
                // MEMBER
                // -------------------------------------------------

                if (row.Cells["MemberId"].Value != null &&
                    row.Cells["MemberId"].Value != DBNull.Value)
                {
                    int memberId =
                        Convert.ToInt32(
                            row.Cells["MemberId"].Value
                        );

                    cmbMember.SelectedValue =
                        memberId;
                }


                // -------------------------------------------------
                // INVOICE DATE
                // -------------------------------------------------

                if (row.Cells["InvoiceDate"].Value != null &&
                    row.Cells["InvoiceDate"].Value != DBNull.Value)
                {
                    dtpInvoiceDate.Value =
                        Convert.ToDateTime(
                            row.Cells["InvoiceDate"].Value
                        );
                }


                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------

                if (row.Cells["PaymentId"].Value != null &&
                    row.Cells["PaymentId"].Value != DBNull.Value)
                {
                    txtPaymentId.Text =
                        Convert.ToString(
                            row.Cells["PaymentId"].Value
                        );
                }


                // -------------------------------------------------
                // AMOUNT
                // -------------------------------------------------

                if (row.Cells["Amount"].Value != null &&
                    row.Cells["Amount"].Value != DBNull.Value)
                {
                    decimal amount =
                        Convert.ToDecimal(
                            row.Cells["Amount"].Value
                        );

                    txtAmount.Text =
                        amount.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not select invoice record.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // LABEL EVENTS
        // =====================================================

        private void lblInvoiceId_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblMember_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblInvoiceDate_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblPaymentId_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblAmount_Click(
            object sender,
            EventArgs e)
        {
        }

        private void pnlInvoiceInput_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}