namespace gymmanagementsystem_2.FORMS
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPaymentHeading = new System.Windows.Forms.Label();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.cmbMemberId = new System.Windows.Forms.ComboBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.pnlPaymentInputNew = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPaymentSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.pnlPaymentInputNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlPaymentSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPaymentHeading
            // 
            this.lblPaymentHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHeading.Location = new System.Drawing.Point(20, 20);
            this.lblPaymentHeading.Name = "lblPaymentHeading";
            this.lblPaymentHeading.Size = new System.Drawing.Size(1040, 40);
            this.lblPaymentHeading.TabIndex = 0;
            this.lblPaymentHeading.Text = "PAYMENT MANAGEMENT";
            this.lblPaymentHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.Location = new System.Drawing.Point(12, 14);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(120, 30);
            this.lblPaymentId.TabIndex = 2;
            this.lblPaymentId.Text = "Payment ID";
            this.lblPaymentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Location = new System.Drawing.Point(159, 15);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.ReadOnly = true;
            this.txtPaymentId.Size = new System.Drawing.Size(260, 30);
            this.txtPaymentId.TabIndex = 3;
            // 
            // lblMemberId
            // 
            this.lblMemberId.Location = new System.Drawing.Point(12, 73);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(120, 30);
            this.lblMemberId.TabIndex = 4;
            this.lblMemberId.Text = "Member ID";
            this.lblMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // cmbMemberId
            // 
            this.cmbMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberId.FormattingEnabled = true;
            this.cmbMemberId.Location = new System.Drawing.Point(159, 73);
            this.cmbMemberId.Name = "cmbMemberId";
            this.cmbMemberId.Size = new System.Drawing.Size(260, 31);
            this.cmbMemberId.TabIndex = 5;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 217);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(120, 30);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPaymentDate.Click += new System.EventHandler(this.lblPaymentDate_Click);
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(159, 215);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(260, 30);
            this.dtpPaymentDate.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(12, 167);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(120, 30);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(159, 167);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(260, 30);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // pnlPaymentInputNew
            // 
            this.pnlPaymentInputNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaymentInputNew.Controls.Add(this.cmbPlan);
            this.pnlPaymentInputNew.Controls.Add(this.lblPlan);
            this.pnlPaymentInputNew.Controls.Add(this.btnClear);
            this.pnlPaymentInputNew.Controls.Add(this.btnDelete);
            this.pnlPaymentInputNew.Controls.Add(this.btnUpdate);
            this.pnlPaymentInputNew.Controls.Add(this.dgvPayments);
            this.pnlPaymentInputNew.Controls.Add(this.pnlPaymentSearch);
            this.pnlPaymentInputNew.Controls.Add(this.btnSave);
            this.pnlPaymentInputNew.Controls.Add(this.cmbPaymentStatus);
            this.pnlPaymentInputNew.Controls.Add(this.lblPaymentStatus);
            this.pnlPaymentInputNew.Controls.Add(this.cmbPaymentMethod);
            this.pnlPaymentInputNew.Controls.Add(this.lblPaymentMethod);
            this.pnlPaymentInputNew.Controls.Add(this.lblPaymentId);
            this.pnlPaymentInputNew.Controls.Add(this.txtPaymentId);
            this.pnlPaymentInputNew.Controls.Add(this.lblMemberId);
            this.pnlPaymentInputNew.Controls.Add(this.cmbMemberId);
            this.pnlPaymentInputNew.Controls.Add(this.lblPaymentDate);
            this.pnlPaymentInputNew.Controls.Add(this.dtpPaymentDate);
            this.pnlPaymentInputNew.Controls.Add(this.lblAmount);
            this.pnlPaymentInputNew.Controls.Add(this.txtAmount);
            this.pnlPaymentInputNew.Location = new System.Drawing.Point(1, 63);
            this.pnlPaymentInputNew.Name = "pnlPaymentInputNew";
            this.pnlPaymentInputNew.Size = new System.Drawing.Size(1202, 477);
            this.pnlPaymentInputNew.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(304, 412);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(192, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(84, 412);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(500, 114);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(684, 230);
            this.dgvPayments.TabIndex = 16;
            // 
            // PaymentId
            // 
            this.PaymentId.HeaderText = "Payment ID";
            this.PaymentId.MinimumWidth = 6;
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.ReadOnly = true;
            // 
            // MemberId
            // 
            this.MemberId.HeaderText = "Member ID";
            this.MemberId.MinimumWidth = 6;
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.HeaderText = "Payment Status";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // pnlPaymentSearch
            // 
            this.pnlPaymentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaymentSearch.Controls.Add(this.txtSearch);
            this.pnlPaymentSearch.Controls.Add(this.lblSearch);
            this.pnlPaymentSearch.Location = new System.Drawing.Point(500, 15);
            this.pnlPaymentSearch.Name = "pnlPaymentSearch";
            this.pnlPaymentSearch.Size = new System.Drawing.Size(684, 69);
            this.pnlPaymentSearch.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(160, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(20, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(160, 30);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search Payment";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Select Status",
            "Paid",
            "Pending",
            "Cancelled"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(159, 337);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(260, 31);
            this.cmbPaymentStatus.TabIndex = 13;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Location = new System.Drawing.Point(7, 338);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(167, 30);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Payment Status";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "",
            "Cash",
            "Credit Card",
            "Debit Card",
            "bKash",
            "Nagad",
            "Bank Transfer"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(159, 280);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(260, 31);
            this.cmbPaymentMethod.TabIndex = 11;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Location = new System.Drawing.Point(12, 281);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(162, 30);
            this.lblPaymentMethod.TabIndex = 10;
            this.lblPaymentMethod.Text = "Payment Method";
            this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(7, 125);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(143, 23);
            this.lblPlan.TabIndex = 20;
            this.lblPlan.Text = "Membership Plan";
            // 
            // cmbPlan
            // 
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(160, 117);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(260, 31);
            this.cmbPlan.TabIndex = 21;
            this.cmbPlan.SelectedIndexChanged += new System.EventHandler(this.cmbPlan_SelectedIndexChanged);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 552);
            this.Controls.Add(this.pnlPaymentInputNew);
            this.Controls.Add(this.lblPaymentHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1233, 556);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Payments";
            this.pnlPaymentInputNew.ResumeLayout(false);
            this.pnlPaymentInputNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlPaymentSearch.ResumeLayout(false);
            this.pnlPaymentSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentHeading;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.ComboBox cmbMemberId;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel pnlPaymentInputNew;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label btnSave;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Panel pnlPaymentSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cmbPlan;
    }
}