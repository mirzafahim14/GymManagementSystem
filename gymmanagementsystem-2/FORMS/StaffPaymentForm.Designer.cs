namespace gymmanagementsystem_2.FORMS
{
    partial class StaffPaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        // =========================================================
        // DISPOSE
        // =========================================================

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

        // =========================================================
        // INITIALIZE COMPONENT
        // =========================================================

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();

            this.lblPaymentId = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();

            this.lblMember = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();

            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();

            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();

            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();

            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();

            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.dgvPayments = new System.Windows.Forms.DataGridView();

            this.pnlInput.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments))
                .BeginInit();

            this.SuspendLayout();

            // =====================================================
            // HEADING
            // =====================================================

            this.lblHeading.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblHeading.Location =
                new System.Drawing.Point(20, 15);

            this.lblHeading.Name =
                "lblHeading";

            this.lblHeading.Size =
                new System.Drawing.Size(1210, 45);

            this.lblHeading.TabIndex = 0;

            this.lblHeading.Text =
                "MEMBER PAYMENT MANAGEMENT BY STAFF";

            this.lblHeading.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // INPUT PANEL
            // =====================================================

            this.pnlInput.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlInput.Location =
                new System.Drawing.Point(20, 75);

            this.pnlInput.Name =
                "pnlInput";

            this.pnlInput.Size =
                new System.Drawing.Size(430, 600);

            this.pnlInput.TabIndex = 1;

            // =====================================================
            // PAYMENT ID LABEL
            // =====================================================

            this.lblPaymentId.Location =
                new System.Drawing.Point(20, 25);

            this.lblPaymentId.Name =
                "lblPaymentId";

            this.lblPaymentId.Size =
                new System.Drawing.Size(125, 30);

            this.lblPaymentId.TabIndex = 0;

            this.lblPaymentId.Text =
                "Payment ID";

            // =====================================================
            // PAYMENT ID TEXTBOX
            // =====================================================

            this.txtPaymentId.Location =
                new System.Drawing.Point(155, 25);

            this.txtPaymentId.Name =
                "txtPaymentId";

            this.txtPaymentId.ReadOnly = true;

            this.txtPaymentId.Size =
                new System.Drawing.Size(240, 30);

            this.txtPaymentId.TabIndex = 1;

            // =====================================================
            // MEMBER LABEL
            // =====================================================

            this.lblMember.Location =
                new System.Drawing.Point(20, 85);

            this.lblMember.Name =
                "lblMember";

            this.lblMember.Size =
                new System.Drawing.Size(125, 30);

            this.lblMember.TabIndex = 2;

            this.lblMember.Text =
                "Select Member";

            // =====================================================
            // MEMBER COMBOBOX
            // =====================================================

            this.cmbMember.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMember.Location =
                new System.Drawing.Point(155, 85);

            this.cmbMember.Name =
                "cmbMember";

            this.cmbMember.Size =
                new System.Drawing.Size(240, 31);

            this.cmbMember.TabIndex = 3;

            this.cmbMember.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbMember_SelectedIndexChanged);

            // =====================================================
            // MEMBER ID LABEL
            // =====================================================

            this.lblMemberId.Location =
                new System.Drawing.Point(20, 145);

            this.lblMemberId.Name =
                "lblMemberId";

            this.lblMemberId.Size =
                new System.Drawing.Size(125, 30);

            this.lblMemberId.TabIndex = 4;

            this.lblMemberId.Text =
                "Member ID";

            // =====================================================
            // MEMBER ID TEXTBOX
            // =====================================================

            this.txtMemberId.Location =
                new System.Drawing.Point(155, 145);

            this.txtMemberId.Name =
                "txtMemberId";

            this.txtMemberId.ReadOnly = true;

            this.txtMemberId.Size =
                new System.Drawing.Size(240, 30);

            this.txtMemberId.TabIndex = 5;

            // =====================================================
            // MEMBER NAME LABEL
            // =====================================================

            this.lblMemberName.Location =
                new System.Drawing.Point(20, 205);

            this.lblMemberName.Name =
                "lblMemberName";

            this.lblMemberName.Size =
                new System.Drawing.Size(125, 30);

            this.lblMemberName.TabIndex = 6;

            this.lblMemberName.Text =
                "Member Name";

            // =====================================================
            // MEMBER NAME TEXTBOX
            // =====================================================

            this.txtMemberName.Location =
                new System.Drawing.Point(155, 205);

            this.txtMemberName.Name =
                "txtMemberName";

            this.txtMemberName.ReadOnly = true;

            this.txtMemberName.Size =
                new System.Drawing.Size(240, 30);

            this.txtMemberName.TabIndex = 7;

            // =====================================================
            // PAYMENT DATE LABEL
            // =====================================================

            this.lblPaymentDate.Location =
                new System.Drawing.Point(20, 265);

            this.lblPaymentDate.Name =
                "lblPaymentDate";

            this.lblPaymentDate.Size =
                new System.Drawing.Size(125, 30);

            this.lblPaymentDate.TabIndex = 8;

            this.lblPaymentDate.Text =
                "Payment Date";

            // =====================================================
            // PAYMENT DATE
            // =====================================================

            this.dtpPaymentDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpPaymentDate.Location =
                new System.Drawing.Point(155, 265);

            this.dtpPaymentDate.Name =
                "dtpPaymentDate";

            this.dtpPaymentDate.Size =
                new System.Drawing.Size(240, 30);

            this.dtpPaymentDate.TabIndex = 9;

            // =====================================================
            // AMOUNT LABEL
            // =====================================================

            this.lblAmount.Location =
                new System.Drawing.Point(20, 325);

            this.lblAmount.Name =
                "lblAmount";

            this.lblAmount.Size =
                new System.Drawing.Size(125, 30);

            this.lblAmount.TabIndex = 10;

            this.lblAmount.Text =
                "Amount";

            // =====================================================
            // AMOUNT TEXTBOX
            // =====================================================

            this.txtAmount.Location =
                new System.Drawing.Point(155, 325);

            this.txtAmount.Name =
                "txtAmount";

            this.txtAmount.Size =
                new System.Drawing.Size(240, 30);

            this.txtAmount.TabIndex = 11;

            // =====================================================
            // PAYMENT METHOD LABEL
            // =====================================================

            this.lblPaymentMethod.Location =
                new System.Drawing.Point(20, 385);

            this.lblPaymentMethod.Name =
                "lblPaymentMethod";

            this.lblPaymentMethod.Size =
                new System.Drawing.Size(125, 30);

            this.lblPaymentMethod.TabIndex = 12;

            this.lblPaymentMethod.Text =
                "Payment Method";

            // =====================================================
            // PAYMENT METHOD COMBOBOX
            // =====================================================

            this.cmbPaymentMethod.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbPaymentMethod.Location =
                new System.Drawing.Point(155, 385);

            this.cmbPaymentMethod.Name =
                "cmbPaymentMethod";

            this.cmbPaymentMethod.Size =
                new System.Drawing.Size(240, 31);

            this.cmbPaymentMethod.TabIndex = 13;

            // =====================================================
            // SAVE BUTTON
            // =====================================================

            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnSave.Location =
                new System.Drawing.Point(20, 470);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(115, 40);

            this.btnSave.TabIndex = 14;

            this.btnSave.Text =
                "SAVE";

            this.btnSave.UseVisualStyleBackColor = true;

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click);

            // =====================================================
            // UPDATE BUTTON
            // =====================================================

            this.btnUpdate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnUpdate.Location =
                new System.Drawing.Point(150, 470);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(115, 40);

            this.btnUpdate.TabIndex = 15;

            this.btnUpdate.Text =
                "UPDATE";

            this.btnUpdate.UseVisualStyleBackColor = true;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // =====================================================
            // CLEAR BUTTON
            // =====================================================

            this.btnClear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnClear.Location =
                new System.Drawing.Point(280, 470);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(115, 40);

            this.btnClear.TabIndex = 16;

            this.btnClear.Text =
                "CLEAR";

            this.btnClear.UseVisualStyleBackColor = true;

            this.btnClear.Click +=
                new System.EventHandler(
                    this.btnClear_Click);

            // =====================================================
            // ADD CONTROLS TO INPUT PANEL
            // =====================================================

            this.pnlInput.Controls.Add(
                this.lblPaymentId);

            this.pnlInput.Controls.Add(
                this.txtPaymentId);

            this.pnlInput.Controls.Add(
                this.lblMember);

            this.pnlInput.Controls.Add(
                this.cmbMember);

            this.pnlInput.Controls.Add(
                this.lblMemberId);

            this.pnlInput.Controls.Add(
                this.txtMemberId);

            this.pnlInput.Controls.Add(
                this.lblMemberName);

            this.pnlInput.Controls.Add(
                this.txtMemberName);

            this.pnlInput.Controls.Add(
                this.lblPaymentDate);

            this.pnlInput.Controls.Add(
                this.dtpPaymentDate);

            this.pnlInput.Controls.Add(
                this.lblAmount);

            this.pnlInput.Controls.Add(
                this.txtAmount);

            this.pnlInput.Controls.Add(
                this.lblPaymentMethod);

            this.pnlInput.Controls.Add(
                this.cmbPaymentMethod);

            this.pnlInput.Controls.Add(
                this.btnSave);

            this.pnlInput.Controls.Add(
                this.btnUpdate);

            this.pnlInput.Controls.Add(
                this.btnClear);

            // =====================================================
            // SEARCH LABEL
            // =====================================================

            this.lblSearch.Location =
                new System.Drawing.Point(475, 80);

            this.lblSearch.Name =
                "lblSearch";

            this.lblSearch.Size =
                new System.Drawing.Size(170, 30);

            this.lblSearch.TabIndex = 2;

            this.lblSearch.Text =
                "Search Member Payment";

            // =====================================================
            // SEARCH TEXTBOX
            // =====================================================

            this.txtSearch.Location =
                new System.Drawing.Point(650, 80);

            this.txtSearch.Name =
                "txtSearch";

            this.txtSearch.Size =
                new System.Drawing.Size(300, 30);

            this.txtSearch.TabIndex = 3;

            this.txtSearch.TextChanged +=
                new System.EventHandler(
                    this.txtSearch_TextChanged);

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            this.dgvPayments.AllowUserToAddRows = false;

            this.dgvPayments.AllowUserToDeleteRows = false;

            this.dgvPayments.AllowUserToResizeRows = false;

            this.dgvPayments.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvPayments.BackgroundColor =
                System.Drawing.SystemColors.Window;

            this.dgvPayments.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvPayments.Location =
                new System.Drawing.Point(475, 130);

            this.dgvPayments.MultiSelect = false;

            this.dgvPayments.Name =
                "dgvPayments";

            this.dgvPayments.ReadOnly = true;

            this.dgvPayments.RowHeadersVisible = false;

            this.dgvPayments.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvPayments.Size =
                new System.Drawing.Size(750, 545);

            this.dgvPayments.TabIndex = 4;

            this.dgvPayments.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvPayments_CellClick);

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 23F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1250, 700);

            this.Controls.Add(
                this.lblHeading);

            this.Controls.Add(
                this.pnlInput);

            this.Controls.Add(
                this.lblSearch);

            this.Controls.Add(
                this.txtSearch);

            this.Controls.Add(
                this.dgvPayments);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name =
                "StaffPaymentForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gym Management System - Member Payments";

            this.pnlInput.ResumeLayout(false);

            this.pnlInput.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPayments))
                .EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        #endregion

        // =========================================================
        // CONTROLS
        // =========================================================

        private System.Windows.Forms.Label lblHeading;

        private System.Windows.Forms.Panel pnlInput;

        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;

        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cmbMember;

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;

        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;

        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.DataGridView dgvPayments;
    }
}