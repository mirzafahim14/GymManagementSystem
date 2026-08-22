using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffPaymentForm : Form
    {
        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public StaffPaymentForm()
        {
            InitializeComponent();

            this.Load += StaffPaymentForm_Load;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupControls();

                LoadMembers();

                LoadPaymentMethods();

                LoadPayments();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Member Payment form could not be loaded.\n\n" +
                    ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SETUP CONTROLS
        // =========================================================

        private void SetupControls()
        {
            txtPaymentId.ReadOnly = true;
            txtMemberId.ReadOnly = true;
            txtMemberName.ReadOnly = true;

            cmbMember.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbPaymentMethod.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dtpPaymentDate.Format =
                DateTimePickerFormat.Short;

            dtpPaymentDate.Value =
                DateTime.Today;

            dgvPayments.ReadOnly = true;

            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;

            dgvPayments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPayments.MultiSelect = false;

            dgvPayments.AutoGenerateColumns = true;

            dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPayments.RowHeadersVisible = false;
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
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD PAYMENT METHODS
        // =========================================================

        private void LoadPaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();

            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");
            cmbPaymentMethod.Items.Add("bKash");
            cmbPaymentMethod.Items.Add("Nagad");
            cmbPaymentMethod.Items.Add("Bank Transfer");

            cmbPaymentMethod.SelectedIndex = -1;
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
                    return;
                }

                DataRowView row =
                    cmbMember.SelectedItem as DataRowView;

                if (row != null)
                {
                    txtMemberId.Text =
                        row["MemberId"].ToString();

                    txtMemberName.Text =
                        row["FullName"].ToString();
                }
            }
            catch
            {
                // Ignore temporary ComboBox binding errors
            }
        }

        // =========================================================
        // LOAD PAYMENTS
        // =========================================================

        private void LoadPayments()
        {
            try
            {
                string query = @"
                    SELECT
                        p.PaymentId,
                        p.MemberId,
                        m.FullName AS MemberName,
                        p.PaymentDate,
                        p.Amount,
                        p.PaymentMethod,
                        p.TransactionReference,
                        p.Status,
                        p.Notes
                    FROM Payments p
                    INNER JOIN Members m
                        ON p.MemberId = m.MemberId
                    ORDER BY
                        p.PaymentId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                dgvPayments.DataSource = dt;

                SetGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load payment records.\n\n" +
                    ex.Message,
                    "Payment Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // GRID HEADERS
        // =========================================================

        private void SetGridHeaders()
        {
            if (dgvPayments.Columns.Contains("PaymentId"))
            {
                dgvPayments.Columns["PaymentId"].HeaderText =
                    "Payment ID";
            }

            if (dgvPayments.Columns.Contains("MemberId"))
            {
                dgvPayments.Columns["MemberId"].HeaderText =
                    "Member ID";
            }

            if (dgvPayments.Columns.Contains("MemberName"))
            {
                dgvPayments.Columns["MemberName"].HeaderText =
                    "Member Name";
            }

            if (dgvPayments.Columns.Contains("PaymentDate"))
            {
                dgvPayments.Columns["PaymentDate"].HeaderText =
                    "Payment Date";

                dgvPayments.Columns["PaymentDate"]
                    .DefaultCellStyle.Format =
                    "dd-MMM-yyyy";
            }

            if (dgvPayments.Columns.Contains("Amount"))
            {
                dgvPayments.Columns["Amount"].HeaderText =
                    "Amount";

                dgvPayments.Columns["Amount"]
                    .DefaultCellStyle.Format =
                    "0.00";
            }

            if (dgvPayments.Columns.Contains("PaymentMethod"))
            {
                dgvPayments.Columns["PaymentMethod"].HeaderText =
                    "Payment Method";
            }

            if (dgvPayments.Columns.Contains("TransactionReference"))
            {
                dgvPayments.Columns["TransactionReference"].HeaderText =
                    "Transaction Reference";
            }

            if (dgvPayments.Columns.Contains("Status"))
            {
                dgvPayments.Columns["Status"].HeaderText =
                    "Status";
            }

            if (dgvPayments.Columns.Contains("Notes"))
            {
                dgvPayments.Columns["Notes"].HeaderText =
                    "Notes";
            }

            dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =========================================================
        // SAVE PAYMENT
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

                if (cmbMember.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a member.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbMember.Focus();
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
                        "Please enter a valid amount.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show(
                        "Amount must be greater than 0.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }

                // -------------------------------------------------
                // PAYMENT METHOD
                // -------------------------------------------------

                if (cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a payment method.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbPaymentMethod.Focus();
                    return;
                }

                // -------------------------------------------------
                // MEMBER ID
                // -------------------------------------------------

                int memberId =
                    Convert.ToInt32(
                        cmbMember.SelectedValue);

                DateTime paymentDate =
                    dtpPaymentDate.Value.Date;

                string paymentMethod =
                    cmbPaymentMethod.Text.Trim();

                // Status is required in database
                string status = "Paid";

                // -------------------------------------------------
                // INSERT
                // -------------------------------------------------

                string query = @"
                    INSERT INTO Payments
                    (
                        MemberId,
                        PaymentDate,
                        Amount,
                        PaymentMethod,
                        Status
                    )
                    VALUES
                    (
                        @MemberId,
                        @PaymentDate,
                        @Amount,
                        @PaymentMethod,
                        @Status
                    )";

                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            memberId),

                        new SqlParameter(
                            "@PaymentDate",
                            paymentDate),

                        new SqlParameter(
                            "@Amount",
                            amount),

                        new SqlParameter(
                            "@PaymentMethod",
                            paymentMethod),

                        new SqlParameter(
                            "@Status",
                            status)
                    );

                if (result > 0)
                {
                    MessageBox.Show(
                        "Member payment saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadPayments();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save member payment.\n\n" +
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // UPDATE PAYMENT
        // =========================================================

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------

                int paymentId;

                if (!int.TryParse(
                    txtPaymentId.Text.Trim(),
                    out paymentId))
                {
                    MessageBox.Show(
                        "Please select a payment record first.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // -------------------------------------------------
                // MEMBER
                // -------------------------------------------------

                if (cmbMember.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a member.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbMember.Focus();
                    return;
                }

                // -------------------------------------------------
                // AMOUNT
                // -------------------------------------------------

                decimal amount;

                if (!decimal.TryParse(
                    txtAmount.Text.Trim(),
                    out amount))
                {
                    MessageBox.Show(
                        "Please enter a valid amount.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show(
                        "Amount must be greater than 0.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }

                // -------------------------------------------------
                // PAYMENT METHOD
                // -------------------------------------------------

                if (cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select a payment method.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbPaymentMethod.Focus();
                    return;
                }

                int memberId =
                    Convert.ToInt32(
                        cmbMember.SelectedValue);

                DateTime paymentDate =
                    dtpPaymentDate.Value.Date;

                string paymentMethod =
                    cmbPaymentMethod.Text.Trim();

                string status = "Paid";

                // -------------------------------------------------
                // UPDATE
                // -------------------------------------------------

                string query = @"
                    UPDATE Payments
                    SET
                        MemberId = @MemberId,
                        PaymentDate = @PaymentDate,
                        Amount = @Amount,
                        PaymentMethod = @PaymentMethod,
                        Status = @Status
                    WHERE
                        PaymentId = @PaymentId";

                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            memberId),

                        new SqlParameter(
                            "@PaymentDate",
                            paymentDate),

                        new SqlParameter(
                            "@Amount",
                            amount),

                        new SqlParameter(
                            "@PaymentMethod",
                            paymentMethod),

                        new SqlParameter(
                            "@Status",
                            status),

                        new SqlParameter(
                            "@PaymentId",
                            paymentId)
                    );

                if (result > 0)
                {
                    MessageBox.Show(
                        "Member payment updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadPayments();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Payment record not found.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update member payment.\n\n" +
                    ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
        // CLEAR FIELDS
        // =========================================================

        private void ClearFields()
        {
            txtPaymentId.Clear();

            cmbMember.SelectedIndex = -1;

            txtMemberId.Clear();

            txtMemberName.Clear();

            dtpPaymentDate.Value =
                DateTime.Today;

            txtAmount.Clear();

            cmbPaymentMethod.SelectedIndex =
                -1;

            dgvPayments.ClearSelection();
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
                string search =
                    txtSearch.Text.Trim();

                string query = @"
                    SELECT
                        p.PaymentId,
                        p.MemberId,
                        m.FullName AS MemberName,
                        p.PaymentDate,
                        p.Amount,
                        p.PaymentMethod,
                        p.TransactionReference,
                        p.Status,
                        p.Notes
                    FROM Payments p
                    INNER JOIN Members m
                        ON p.MemberId = m.MemberId
                    WHERE
                        CAST(
                            p.PaymentId AS NVARCHAR(50)
                        ) LIKE @Search

                        OR CAST(
                            p.MemberId AS NVARCHAR(50)
                        ) LIKE @Search

                        OR m.FullName LIKE @Search

                        OR p.PaymentMethod LIKE @Search

                        OR p.Status LIKE @Search

                    ORDER BY
                        p.PaymentId DESC";

                DataTable dt =
                    DbHelper.ExecuteQuery(
                        query,
                        new SqlParameter(
                            "@Search",
                            "%" + search + "%")
                    );

                dgvPayments.DataSource = dt;

                SetGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" +
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // GRID CLICK
        // =========================================================

        private void dgvPayments_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvPayments.Rows[e.RowIndex];

                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------

                if (row.Cells["PaymentId"].Value != null &&
                    row.Cells["PaymentId"].Value != DBNull.Value)
                {
                    txtPaymentId.Text =
                        row.Cells["PaymentId"]
                            .Value
                            .ToString();
                }

                // -------------------------------------------------
                // MEMBER ID
                // -------------------------------------------------

                if (row.Cells["MemberId"].Value != null &&
                    row.Cells["MemberId"].Value != DBNull.Value)
                {
                    txtMemberId.Text =
                        row.Cells["MemberId"]
                            .Value
                            .ToString();

                    SelectMember(
                        row.Cells["MemberId"]
                            .Value
                            .ToString());
                }

                // -------------------------------------------------
                // MEMBER NAME
                // -------------------------------------------------

                if (row.Cells["MemberName"].Value != null &&
                    row.Cells["MemberName"].Value != DBNull.Value)
                {
                    txtMemberName.Text =
                        row.Cells["MemberName"]
                            .Value
                            .ToString();
                }

                // -------------------------------------------------
                // PAYMENT DATE
                // -------------------------------------------------

                if (row.Cells["PaymentDate"].Value != null &&
                    row.Cells["PaymentDate"].Value != DBNull.Value)
                {
                    dtpPaymentDate.Value =
                        Convert.ToDateTime(
                            row.Cells["PaymentDate"].Value);
                }

                // -------------------------------------------------
                // AMOUNT
                // -------------------------------------------------

                if (row.Cells["Amount"].Value != null &&
                    row.Cells["Amount"].Value != DBNull.Value)
                {
                    txtAmount.Text =
                        Convert.ToDecimal(
                            row.Cells["Amount"].Value)
                            .ToString("0.00");
                }

                // -------------------------------------------------
                // PAYMENT METHOD
                // -------------------------------------------------

                if (row.Cells["PaymentMethod"].Value != null &&
                    row.Cells["PaymentMethod"].Value != DBNull.Value)
                {
                    string method =
                        row.Cells["PaymentMethod"]
                            .Value
                            .ToString();

                    cmbPaymentMethod.SelectedItem =
                        method;
                }
                else
                {
                    cmbPaymentMethod.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not select payment record.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SELECT MEMBER
        // =========================================================

        private void SelectMember(string memberId)
        {
            if (cmbMember.Items.Count == 0)
                return;

            for (int i = 0;
                 i < cmbMember.Items.Count;
                 i++)
            {
                DataRowView row =
                    cmbMember.Items[i] as DataRowView;

                if (row != null)
                {
                    string id =
                        row["MemberId"].ToString();

                    if (id == memberId)
                    {
                        cmbMember.SelectedIndex = i;
                        return;
                    }
                }
            }

            cmbMember.SelectedIndex = -1;
        }
    }
}