
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            // Form Load event
            this.Load += PaymentForm_Load;
        }


        // =========================================================
        // FORM LOAD
        // =========================================================
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupControls();

                LoadMembers();

                LoadPlans();

                LoadPaymentMethods();

                LoadPaymentStatuses();

                LoadPayments();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment form could not be loaded.\n\n" +
                    ex.Message,
                    "Payment Error",
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
            // Payment ID
            txtPaymentId.ReadOnly = true;

            // Amount will come automatically from MembershipPlans
            txtAmount.ReadOnly = true;

            // Member ComboBox
            cmbMemberId.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Plan ComboBox
            cmbPlan.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Payment Date
            dtpPaymentDate.Format =
                DateTimePickerFormat.Short;

            dtpPaymentDate.Value =
                DateTime.Today;

            // Payment Method
            cmbPaymentMethod.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Payment Status
            cmbPaymentStatus.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // DataGridView
            dgvPayments.ReadOnly = true;

            dgvPayments.AllowUserToAddRows = false;

            dgvPayments.AllowUserToDeleteRows = false;

            dgvPayments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPayments.MultiSelect = false;

            // IMPORTANT
            // Database থেকে columns automatically তৈরি হবে
            dgvPayments.AutoGenerateColumns = true;

            dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
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
                    ORDER BY MemberId ASC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                cmbMemberId.DataSource = dt;

                cmbMemberId.DisplayMember =
                    "FullName";

                cmbMemberId.ValueMember =
                    "MemberId";

                cmbMemberId.SelectedIndex = -1;
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
        // LOAD MEMBERSHIP PLANS
        // =========================================================
        private void LoadPlans()
        {
            try
            {
                string query = @"
                    SELECT
                        PlanId,
                        PlanName,
                        Price
                    FROM MembershipPlans
                    WHERE IsActive = 1
                    ORDER BY PlanId ASC";

                DataTable dt =
                    DbHelper.ExecuteQuery(query);

                cmbPlan.DataSource = dt;

                cmbPlan.DisplayMember =
                    "PlanName";

                cmbPlan.ValueMember =
                    "PlanId";

                cmbPlan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load membership plans.\n\n" +
                    ex.Message,
                    "Plan Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // PLAN SELECTED
        // Automatically show Price in Amount
        // =========================================================
        private void cmbPlan_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbPlan.SelectedIndex == -1)
                {
                    txtAmount.Clear();
                    return;
                }

                DataRowView row =
                    cmbPlan.SelectedItem as DataRowView;

                if (row != null)
                {
                    decimal price =
                        Convert.ToDecimal(row["Price"]);

                    txtAmount.Text =
                        price.ToString("0.00");
                }
            }
            catch
            {
                txtAmount.Clear();
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
        // LOAD PAYMENT STATUSES
        // =========================================================
        private void LoadPaymentStatuses()
        {
            cmbPaymentStatus.Items.Clear();

            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Cancelled");

            cmbPaymentStatus.SelectedIndex = -1;
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
                        p.PlanId,
                        mp.PlanName,
                        p.PaymentDate,
                        p.Amount,
                        p.PaymentMethod,
                        p.TransactionReference,
                        p.Status
                    FROM Payments p

                    INNER JOIN Members m
                        ON p.MemberId = m.MemberId

                    LEFT JOIN MembershipPlans mp
                        ON p.PlanId = mp.PlanId

                    ORDER BY p.PaymentId DESC";

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
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // SET GRID HEADERS
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

            if (dgvPayments.Columns.Contains("PlanId"))
            {
                dgvPayments.Columns["PlanId"].HeaderText =
                    "Plan ID";
            }

            if (dgvPayments.Columns.Contains("PlanName"))
            {
                dgvPayments.Columns["PlanName"].HeaderText =
                    "Membership Plan";
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

            if (dgvPayments.Columns.Contains(
                "TransactionReference"))
            {
                dgvPayments.Columns[
                    "TransactionReference"
                ].HeaderText =
                    "Transaction Reference";
            }

            if (dgvPayments.Columns.Contains("Status"))
            {
                dgvPayments.Columns["Status"].HeaderText =
                    "Payment Status";
            }

            dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


        // =========================================================
        // SAVE PAYMENT
        // =========================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // MEMBER VALIDATION
                // -------------------------------------------------
                if (cmbMemberId.SelectedIndex == -1 ||
                    cmbMemberId.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select a member.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbMemberId.Focus();
                    return;
                }


                // -------------------------------------------------
                // PLAN VALIDATION
                // -------------------------------------------------
                if (cmbPlan.SelectedIndex == -1 ||
                    cmbPlan.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select a membership plan.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbPlan.Focus();
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
                // PAYMENT METHOD
                // -------------------------------------------------
                if (cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select payment method.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbPaymentMethod.Focus();
                    return;
                }


                // -------------------------------------------------
                // PAYMENT STATUS
                // -------------------------------------------------
                if (cmbPaymentStatus.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select payment status.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbPaymentStatus.Focus();
                    return;
                }


                // -------------------------------------------------
                // GET VALUES
                // -------------------------------------------------
                int memberId =
                    Convert.ToInt32(
                        cmbMemberId.SelectedValue);

                int planId =
                    Convert.ToInt32(
                        cmbPlan.SelectedValue);

                DateTime paymentDate =
                    dtpPaymentDate.Value.Date;

                string paymentMethod =
                    cmbPaymentMethod.Text.Trim();

                string status =
                    cmbPaymentStatus.Text.Trim();


                // -------------------------------------------------
                // INSERT PAYMENT
                // -------------------------------------------------
                string query = @"
                    INSERT INTO Payments
                    (
                        MemberId,
                        PlanId,
                        PaymentDate,
                        Amount,
                        PaymentMethod,
                        TransactionReference,
                        Status
                    )
                    VALUES
                    (
                        @MemberId,
                        @PlanId,
                        @PaymentDate,
                        @Amount,
                        @PaymentMethod,
                        @TransactionReference,
                        @Status
                    )";


                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            memberId),

                        new SqlParameter(
                            "@PlanId",
                            planId),

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
                            "@TransactionReference",
                            DBNull.Value),

                        new SqlParameter(
                            "@Status",
                            status)
                    );


                // -------------------------------------------------
                // SUCCESS
                // -------------------------------------------------
                if (result > 0)
                {
                    MessageBox.Show(
                        "Payment saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadPayments();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Payment could not be saved.",
                        "Save",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not save payment.\n\n" +
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // UPDATE PAYMENT
        // =========================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------
                if (string.IsNullOrWhiteSpace(
                    txtPaymentId.Text))
                {
                    MessageBox.Show(
                        "Please select a payment record first.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                int paymentId;

                if (!int.TryParse(
                    txtPaymentId.Text.Trim(),
                    out paymentId))
                {
                    MessageBox.Show(
                        "Invalid Payment ID.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -------------------------------------------------
                // MEMBER
                // -------------------------------------------------
                if (cmbMemberId.SelectedIndex == -1 ||
                    cmbMemberId.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select a member.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbMemberId.Focus();
                    return;
                }


                // -------------------------------------------------
                // PLAN
                // -------------------------------------------------
                if (cmbPlan.SelectedIndex == -1 ||
                    cmbPlan.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Please select a membership plan.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbPlan.Focus();
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
                // METHOD
                // -------------------------------------------------
                if (cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select payment method.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbPaymentMethod.Focus();
                    return;
                }


                // -------------------------------------------------
                // STATUS
                // -------------------------------------------------
                if (cmbPaymentStatus.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please select payment status.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cmbPaymentStatus.Focus();
                    return;
                }


                // -------------------------------------------------
                // GET VALUES
                // -------------------------------------------------
                int memberId =
                    Convert.ToInt32(
                        cmbMemberId.SelectedValue);

                int planId =
                    Convert.ToInt32(
                        cmbPlan.SelectedValue);

                DateTime paymentDate =
                    dtpPaymentDate.Value.Date;

                string paymentMethod =
                    cmbPaymentMethod.Text.Trim();

                string status =
                    cmbPaymentStatus.Text.Trim();


                // -------------------------------------------------
                // UPDATE
                // -------------------------------------------------
                string query = @"
                    UPDATE Payments
                    SET
                        MemberId = @MemberId,
                        PlanId = @PlanId,
                        PaymentDate = @PaymentDate,
                        Amount = @Amount,
                        PaymentMethod = @PaymentMethod,
                        Status = @Status
                    WHERE PaymentId = @PaymentId";


                int result =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@MemberId",
                            memberId),

                        new SqlParameter(
                            "@PlanId",
                            planId),

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


                // -------------------------------------------------
                // SUCCESS
                // -------------------------------------------------
                if (result > 0)
                {
                    MessageBox.Show(
                        "Payment updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadPayments();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Payment record not found.",
                        "Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update payment.\n\n" +
                    ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // DELETE PAYMENT
        // =========================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // -------------------------------------------------
                // PAYMENT ID
                // -------------------------------------------------
                if (string.IsNullOrWhiteSpace(
                    txtPaymentId.Text))
                {
                    MessageBox.Show(
                        "Please select a payment record first.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                int paymentId;

                if (!int.TryParse(
                    txtPaymentId.Text.Trim(),
                    out paymentId))
                {
                    MessageBox.Show(
                        "Invalid Payment ID.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // -------------------------------------------------
                // CONFIRM DELETE
                // -------------------------------------------------
                DialogResult result =
                    MessageBox.Show(
                        "Are you sure you want to delete this payment?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );


                if (result != DialogResult.Yes)
                    return;


                // -------------------------------------------------
                // DELETE
                // -------------------------------------------------
                string query = @"
                    DELETE FROM Payments
                    WHERE PaymentId = @PaymentId";


                int rows =
                    DbHelper.ExecuteNonQuery(
                        query,

                        new SqlParameter(
                            "@PaymentId",
                            paymentId)
                    );


                // -------------------------------------------------
                // SUCCESS
                // -------------------------------------------------
                if (rows > 0)
                {
                    MessageBox.Show(
                        "Payment deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadPayments();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Payment record not found.",
                        "Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete payment.\n\n" +
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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

            cmbMemberId.SelectedIndex = -1;

            cmbPlan.SelectedIndex = -1;

            txtAmount.Clear();

            dtpPaymentDate.Value =
                DateTime.Today;

            cmbPaymentMethod.SelectedIndex = -1;

            cmbPaymentStatus.SelectedIndex = -1;
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
                        p.PlanId,
                        mp.PlanName,
                        p.PaymentDate,
                        p.Amount,
                        p.PaymentMethod,
                        p.TransactionReference,
                        p.Status
                    FROM Payments p

                    INNER JOIN Members m
                        ON p.MemberId = m.MemberId

                    LEFT JOIN MembershipPlans mp
                        ON p.PlanId = mp.PlanId

                    WHERE
                        CAST(p.PaymentId AS NVARCHAR(50))
                            LIKE @Search

                        OR

                        CAST(p.MemberId AS NVARCHAR(50))
                            LIKE @Search

                        OR

                        m.FullName LIKE @Search

                        OR

                        mp.PlanName LIKE @Search

                        OR

                        p.PaymentMethod LIKE @Search

                        OR

                        p.Status LIKE @Search

                    ORDER BY p.PaymentId DESC";


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
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // GRID ROW CLICK
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
                        row.Cells["PaymentId"].Value.ToString();
                }


                // -------------------------------------------------
                // MEMBER
                // -------------------------------------------------
                if (row.Cells["MemberId"].Value != null &&
                    row.Cells["MemberId"].Value != DBNull.Value)
                {
                    int memberId =
                        Convert.ToInt32(
                            row.Cells["MemberId"].Value);

                    cmbMemberId.SelectedValue =
                        memberId;
                }


                // -------------------------------------------------
                // PLAN
                // -------------------------------------------------
                if (row.Cells["PlanId"].Value != null &&
                    row.Cells["PlanId"].Value != DBNull.Value)
                {
                    int planId =
                        Convert.ToInt32(
                            row.Cells["PlanId"].Value);

                    cmbPlan.SelectedValue =
                        planId;
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
                    decimal amount =
                        Convert.ToDecimal(
                            row.Cells["Amount"].Value);

                    txtAmount.Text =
                        amount.ToString("0.00");
                }


                // -------------------------------------------------
                // PAYMENT METHOD
                // -------------------------------------------------
                if (row.Cells["PaymentMethod"].Value != null &&
                    row.Cells["PaymentMethod"].Value != DBNull.Value)
                {
                    cmbPaymentMethod.SelectedItem =
                        row.Cells["PaymentMethod"]
                            .Value.ToString();
                }


                // -------------------------------------------------
                // STATUS
                // -------------------------------------------------
                if (row.Cells["Status"].Value != null &&
                    row.Cells["Status"].Value != DBNull.Value)
                {
                    cmbPaymentStatus.SelectedItem =
                        row.Cells["Status"]
                            .Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not select payment record.\n\n" +
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // OPTIONAL EVENTS
        // =========================================================

        private void lblMemberId_Click(
            object sender,
            EventArgs e)
        {
        }


        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblPaymentDate_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lblAmount_Click(
            object sender,
            EventArgs e)
        {
        }


        private void pnlPaymentInput_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        private void txtAmount_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}

