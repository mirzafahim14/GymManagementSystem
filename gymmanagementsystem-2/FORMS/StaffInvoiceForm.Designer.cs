namespace gymmanagementsystem_2.FORMS
{
    partial class StaffInvoiceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle =
                new System.Windows.Forms.Label();

            this.pnlInput =
                new System.Windows.Forms.Panel();

            this.lblInvoiceInfo =
                new System.Windows.Forms.Label();

            this.lblInvoiceId =
                new System.Windows.Forms.Label();

            this.txtInvoiceId =
                new System.Windows.Forms.TextBox();

            this.lblMember =
                new System.Windows.Forms.Label();

            this.cmbMember =
                new System.Windows.Forms.ComboBox();

            this.lblMemberId =
                new System.Windows.Forms.Label();

            this.txtMemberId =
                new System.Windows.Forms.TextBox();

            this.lblMemberName =
                new System.Windows.Forms.Label();

            this.txtMemberName =
                new System.Windows.Forms.TextBox();

            this.lblInvoiceDate =
                new System.Windows.Forms.Label();

            this.dtpInvoiceDate =
                new System.Windows.Forms.DateTimePicker();

            this.lblPaymentId =
                new System.Windows.Forms.Label();

            this.txtPaymentId =
                new System.Windows.Forms.TextBox();

            this.lblAmount =
                new System.Windows.Forms.Label();

            this.txtAmount =
                new System.Windows.Forms.TextBox();

            this.btnSave =
                new System.Windows.Forms.Button();

            this.btnClear =
                new System.Windows.Forms.Button();

            this.lblInvoiceList =
                new System.Windows.Forms.Label();

            this.dgvMemberInvoices =
                new System.Windows.Forms.DataGridView();

            this.pnlInput.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMemberInvoices)).BeginInit();

            this.SuspendLayout();

            // =====================================================
            // TITLE
            // =====================================================

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTitle.Location =
                new System.Drawing.Point(
                    20,
                    15
                );

            this.lblTitle.Size =
                new System.Drawing.Size(
                    1200,
                    45
                );

            this.lblTitle.Text =
                "MEMBER INVOICE BY STAFF";

            this.lblTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // INPUT PANEL
            // =====================================================

            this.pnlInput.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlInput.Location =
                new System.Drawing.Point(
                    20,
                    75
                );

            this.pnlInput.Size =
                new System.Drawing.Size(
                    430,
                    600
                );

            // =====================================================
            // INVOICE INFO
            // =====================================================

            this.lblInvoiceInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblInvoiceInfo.Location =
                new System.Drawing.Point(
                    20,
                    15
                );

            this.lblInvoiceInfo.Size =
                new System.Drawing.Size(
                    380,
                    35
                );

            this.lblInvoiceInfo.Text =
                "Member Invoice Information";

            this.pnlInput.Controls.Add(
                this.lblInvoiceInfo
            );

            // =====================================================
            // INVOICE ID
            // =====================================================

            this.lblInvoiceId.Location =
                new System.Drawing.Point(
                    20,
                    65
                );

            this.lblInvoiceId.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblInvoiceId.Text =
                "Invoice ID";

            this.txtInvoiceId.Location =
                new System.Drawing.Point(
                    150,
                    65
                );

            this.txtInvoiceId.Size =
                new System.Drawing.Size(
                    250,
                    30
                );

            this.txtInvoiceId.ReadOnly = true;

            this.pnlInput.Controls.Add(
                this.lblInvoiceId
            );

            this.pnlInput.Controls.Add(
                this.txtInvoiceId
            );

            // =====================================================
            // MEMBER
            // =====================================================

            this.lblMember.Location =
                new System.Drawing.Point(
                    20,
                    115
                );

            this.lblMember.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblMember.Text =
                "Member";

            this.cmbMember.Location =
                new System.Drawing.Point(
                    150,
                    115
                );

            this.cmbMember.Size =
                new System.Drawing.Size(
                    250,
                    31
                );

            this.cmbMember.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.pnlInput.Controls.Add(
                this.lblMember
            );

            this.pnlInput.Controls.Add(
                this.cmbMember
            );

            // =====================================================
            // MEMBER ID
            // =====================================================

            this.lblMemberId.Location =
                new System.Drawing.Point(
                    20,
                    165
                );

            this.lblMemberId.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblMemberId.Text =
                "Member ID";

            this.txtMemberId.Location =
                new System.Drawing.Point(
                    150,
                    165
                );

            this.txtMemberId.Size =
                new System.Drawing.Size(
                    250,
                    30
                );

            this.txtMemberId.ReadOnly = true;

            this.pnlInput.Controls.Add(
                this.lblMemberId
            );

            this.pnlInput.Controls.Add(
                this.txtMemberId
            );

            // =====================================================
            // MEMBER NAME
            // =====================================================

            this.lblMemberName.Location =
                new System.Drawing.Point(
                    20,
                    215
                );

            this.lblMemberName.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblMemberName.Text =
                "Member Name";

            this.txtMemberName.Location =
                new System.Drawing.Point(
                    150,
                    215
                );

            this.txtMemberName.Size =
                new System.Drawing.Size(
                    250,
                    30
                );

            this.txtMemberName.ReadOnly = true;

            this.pnlInput.Controls.Add(
                this.lblMemberName
            );

            this.pnlInput.Controls.Add(
                this.txtMemberName
            );

            // =====================================================
            // INVOICE DATE
            // =====================================================

            this.lblInvoiceDate.Location =
                new System.Drawing.Point(
                    20,
                    265
                );

            this.lblInvoiceDate.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblInvoiceDate.Text =
                "Invoice Date";

            this.dtpInvoiceDate.Location =
                new System.Drawing.Point(
                    150,
                    265
                );

            this.dtpInvoiceDate.Size =
                new System.Drawing.Size(
                    250,
                    30
                );

            this.dtpInvoiceDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.pnlInput.Controls.Add(
                this.lblInvoiceDate
            );

            this.pnlInput.Controls.Add(
                this.dtpInvoiceDate
            );

            // =====================================================
            // PAYMENT ID
            // =====================================================

            this.lblPaymentId.Location =
                new System.Drawing.Point(
                    20,
                    315
                );

            this.lblPaymentId.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblPaymentId.Text =
                "Payment ID";

            this.txtPaymentId.Location =
                new System.Drawing.Point(
                    150,
                    315
                );

            this.txtPaymentId.Size =
                new System.Drawing.Size(
                    250,
                    30
                );

            this.txtPaymentId.ReadOnly = true;

            this.pnlInput.Controls.Add(
                this.lblPaymentId
            );

            this.pnlInput.Controls.Add(
                this.txtPaymentId
            );

            // =====================================================
            // AMOUNT
            // =====================================================

            this.lblAmount.Location =
                new System.Drawing.Point(
                    20,
                    365
                );

            this.lblAmount.Size =
                new System.Drawing.Size(
                    120,
                    30
                );

            this.lblAmount.Text =
                "Amount";

            this.txtAmount.Location =
                new System.Drawing.Point(
                    150,
                    365
                );

            this.txtAmount.Size =
                new System.Drawing.Size(
                    250,
                    30
                );

            this.txtAmount.ReadOnly = true;

            this.pnlInput.Controls.Add(
                this.lblAmount
            );

            this.pnlInput.Controls.Add(
                this.txtAmount
            );

            // =====================================================
            // SAVE
            // =====================================================

            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnSave.Location =
                new System.Drawing.Point(
                    40,
                    450
                );

            this.btnSave.Size =
                new System.Drawing.Size(
                    150,
                    45
                );

            this.btnSave.Text =
                "SAVE";

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click
                );

            this.pnlInput.Controls.Add(
                this.btnSave
            );

            // =====================================================
            // CLEAR
            // =====================================================

            this.btnClear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnClear.Location =
                new System.Drawing.Point(
                    220,
                    450
                );

            this.btnClear.Size =
                new System.Drawing.Size(
                    150,
                    45
                );

            this.btnClear.Text =
                "CLEAR";

            this.btnClear.Click +=
                new System.EventHandler(
                    this.btnClear_Click
                );

            this.pnlInput.Controls.Add(
                this.btnClear
            );

            // =====================================================
            // INVOICE LIST
            // =====================================================

            this.lblInvoiceList.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblInvoiceList.Location =
                new System.Drawing.Point(
                    475,
                    75
                );

            this.lblInvoiceList.Size =
                new System.Drawing.Size(
                    700,
                    35
                );

            this.lblInvoiceList.Text =
                "Member Invoice List";

            // =====================================================
            // GRID
            // =====================================================

            this.dgvMemberInvoices.Location =
                new System.Drawing.Point(
                    475,
                    120
                );

            this.dgvMemberInvoices.Size =
                new System.Drawing.Size(
                    750,
                    555
                );

            this.dgvMemberInvoices.ReadOnly = true;

            this.dgvMemberInvoices.AllowUserToAddRows =
                false;

            this.dgvMemberInvoices.AllowUserToDeleteRows =
                false;

            this.dgvMemberInvoices.AllowUserToResizeRows =
                false;

            this.dgvMemberInvoices.AutoGenerateColumns =
                true;

            this.dgvMemberInvoices.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvMemberInvoices.MultiSelect =
                false;

            this.dgvMemberInvoices.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvMemberInvoices.RowHeadersVisible =
                false;

            // =====================================================
            // FORM
            // =====================================================

            this.ClientSize =
                new System.Drawing.Size(
                    1250,
                    700
                );

            this.Controls.Add(
                this.lblTitle
            );

            this.Controls.Add(
                this.pnlInput
            );

            this.Controls.Add(
                this.lblInvoiceList
            );

            this.Controls.Add(
                this.dgvMemberInvoices
            );

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name =
                "StaffInvoiceForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gym Management System - Member Invoice by Staff";

            this.pnlInput.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMemberInvoices)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlInput;

        private System.Windows.Forms.Label lblInvoiceInfo;

        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.TextBox txtInvoiceId;

        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cmbMember;

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;

        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;

        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;

        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblInvoiceList;

        private System.Windows.Forms.DataGridView dgvMemberInvoices;
    }
}