
namespace gymmanagementsystem_2.FORMS
{
    partial class StaffMemberForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();

            this.grpMemberInfo =
                new System.Windows.Forms.GroupBox();

            this.lblMemberName =
                new System.Windows.Forms.Label();

            this.txtMemberName =
                new System.Windows.Forms.TextBox();

            this.lblPhone =
                new System.Windows.Forms.Label();

            this.txtPhone =
                new System.Windows.Forms.TextBox();

            this.lblEmail =
                new System.Windows.Forms.Label();

            this.txtEmail =
                new System.Windows.Forms.TextBox();

            this.lblGender =
                new System.Windows.Forms.Label();

            this.cmbGender =
                new System.Windows.Forms.ComboBox();

            this.lblMembershipType =
                new System.Windows.Forms.Label();

            this.cmbMembershipType =
                new System.Windows.Forms.ComboBox();

            this.lblJoinDate =
                new System.Windows.Forms.Label();

            this.dtpJoinDate =
                new System.Windows.Forms.DateTimePicker();

            this.lblExpiryDate =
                new System.Windows.Forms.Label();

            this.dtpExpiryDate =
                new System.Windows.Forms.DateTimePicker();

            this.btnSave =
                new System.Windows.Forms.Button();

            this.btnUpdate =
                new System.Windows.Forms.Button();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.btnClear =
                new System.Windows.Forms.Button();

            this.lblMemberList =
                new System.Windows.Forms.Label();

            this.dgvMembers =
                new System.Windows.Forms.DataGridView();


            this.grpMemberInfo.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMembers)).BeginInit();

            this.SuspendLayout();


            // =====================================================
            // lblTitle
            // =====================================================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.lblTitle.Location =
                new System.Drawing.Point(20, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(500, 32);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "MEMBER MANAGEMENT BY STAFF";


            // =====================================================
            // grpMemberInfo
            // =====================================================

            this.grpMemberInfo.Controls.Add(
                this.dtpExpiryDate
            );

            this.grpMemberInfo.Controls.Add(
                this.lblExpiryDate
            );

            this.grpMemberInfo.Controls.Add(
                this.dtpJoinDate
            );

            this.grpMemberInfo.Controls.Add(
                this.lblJoinDate
            );

            this.grpMemberInfo.Controls.Add(
                this.cmbMembershipType
            );

            this.grpMemberInfo.Controls.Add(
                this.lblMembershipType
            );

            this.grpMemberInfo.Controls.Add(
                this.cmbGender
            );

            this.grpMemberInfo.Controls.Add(
                this.lblGender
            );

            this.grpMemberInfo.Controls.Add(
                this.txtEmail
            );

            this.grpMemberInfo.Controls.Add(
                this.lblEmail
            );

            this.grpMemberInfo.Controls.Add(
                this.txtPhone
            );

            this.grpMemberInfo.Controls.Add(
                this.lblPhone
            );

            this.grpMemberInfo.Controls.Add(
                this.txtMemberName
            );

            this.grpMemberInfo.Controls.Add(
                this.lblMemberName
            );

            this.grpMemberInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.grpMemberInfo.Location =
                new System.Drawing.Point(20, 65);

            this.grpMemberInfo.Name =
                "grpMemberInfo";

            this.grpMemberInfo.Size =
                new System.Drawing.Size(440, 365);

            this.grpMemberInfo.TabIndex = 1;

            this.grpMemberInfo.TabStop = false;

            this.grpMemberInfo.Text =
                "Member Information";


            // =====================================================
            // lblMemberName
            // =====================================================

            this.lblMemberName.AutoSize = true;

            this.lblMemberName.Location =
                new System.Drawing.Point(20, 40);

            this.lblMemberName.Name =
                "lblMemberName";

            this.lblMemberName.Size =
                new System.Drawing.Size(104, 19);

            this.lblMemberName.TabIndex = 0;

            this.lblMemberName.Text =
                "Member Name";


            // =====================================================
            // txtMemberName
            // =====================================================

            this.txtMemberName.Location =
                new System.Drawing.Point(155, 36);

            this.txtMemberName.Name =
                "txtMemberName";

            this.txtMemberName.Size =
                new System.Drawing.Size(250, 25);

            this.txtMemberName.TabIndex = 1;


            // =====================================================
            // lblPhone
            // =====================================================

            this.lblPhone.AutoSize = true;

            this.lblPhone.Location =
                new System.Drawing.Point(20, 82);

            this.lblPhone.Name =
                "lblPhone";

            this.lblPhone.Size =
                new System.Drawing.Size(48, 19);

            this.lblPhone.TabIndex = 2;

            this.lblPhone.Text =
                "Phone";


            // =====================================================
            // txtPhone
            // =====================================================

            this.txtPhone.Location =
                new System.Drawing.Point(155, 78);

            this.txtPhone.Name =
                "txtPhone";

            this.txtPhone.Size =
                new System.Drawing.Size(250, 25);

            this.txtPhone.TabIndex = 3;


            // =====================================================
            // lblEmail
            // =====================================================

            this.lblEmail.AutoSize = true;

            this.lblEmail.Location =
                new System.Drawing.Point(20, 124);

            this.lblEmail.Name =
                "lblEmail";

            this.lblEmail.Size =
                new System.Drawing.Size(42, 19);

            this.lblEmail.TabIndex = 4;

            this.lblEmail.Text =
                "Email";


            // =====================================================
            // txtEmail
            // =====================================================

            this.txtEmail.Location =
                new System.Drawing.Point(155, 120);

            this.txtEmail.Name =
                "txtEmail";

            this.txtEmail.Size =
                new System.Drawing.Size(250, 25);

            this.txtEmail.TabIndex = 5;


            // =====================================================
            // lblGender
            // =====================================================

            this.lblGender.AutoSize = true;

            this.lblGender.Location =
                new System.Drawing.Point(20, 166);

            this.lblGender.Name =
                "lblGender";

            this.lblGender.Size =
                new System.Drawing.Size(55, 19);

            this.lblGender.TabIndex = 6;

            this.lblGender.Text =
                "Gender";


            // =====================================================
            // cmbGender
            // =====================================================

            this.cmbGender.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbGender.FormattingEnabled = true;

            this.cmbGender.Location =
                new System.Drawing.Point(155, 162);

            this.cmbGender.Name =
                "cmbGender";

            this.cmbGender.Size =
                new System.Drawing.Size(250, 25);

            this.cmbGender.TabIndex = 7;


            // =====================================================
            // lblMembershipType
            // =====================================================

            this.lblMembershipType.AutoSize = true;

            this.lblMembershipType.Location =
                new System.Drawing.Point(20, 208);

            this.lblMembershipType.Name =
                "lblMembershipType";

            this.lblMembershipType.Size =
                new System.Drawing.Size(119, 19);

            this.lblMembershipType.TabIndex = 8;

            this.lblMembershipType.Text =
                "Membership Plan";


            // =====================================================
            // cmbMembershipType
            // =====================================================

            this.cmbMembershipType.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMembershipType.FormattingEnabled = true;

            this.cmbMembershipType.Location =
                new System.Drawing.Point(155, 204);

            this.cmbMembershipType.Name =
                "cmbMembershipType";

            this.cmbMembershipType.Size =
                new System.Drawing.Size(250, 25);

            this.cmbMembershipType.TabIndex = 9;


            // =====================================================
            // lblJoinDate
            // =====================================================

            this.lblJoinDate.AutoSize = true;

            this.lblJoinDate.Location =
                new System.Drawing.Point(20, 250);

            this.lblJoinDate.Name =
                "lblJoinDate";

            this.lblJoinDate.Size =
                new System.Drawing.Size(68, 19);

            this.lblJoinDate.TabIndex = 10;

            this.lblJoinDate.Text =
                "Join Date";


            // =====================================================
            // dtpJoinDate
            // =====================================================

            this.dtpJoinDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpJoinDate.Location =
                new System.Drawing.Point(155, 246);

            this.dtpJoinDate.Name =
                "dtpJoinDate";

            this.dtpJoinDate.Size =
                new System.Drawing.Size(250, 25);

            this.dtpJoinDate.TabIndex = 11;


            // =====================================================
            // lblExpiryDate
            // =====================================================

            this.lblExpiryDate.AutoSize = true;

            this.lblExpiryDate.Location =
                new System.Drawing.Point(20, 292);

            this.lblExpiryDate.Name =
                "lblExpiryDate";

            this.lblExpiryDate.Size =
                new System.Drawing.Size(85, 19);

            this.lblExpiryDate.TabIndex = 12;

            this.lblExpiryDate.Text =
                "Expiry Date";


            // =====================================================
            // dtpExpiryDate
            // =====================================================

            this.dtpExpiryDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpExpiryDate.Location =
                new System.Drawing.Point(155, 288);

            this.dtpExpiryDate.Name =
                "dtpExpiryDate";

            this.dtpExpiryDate.Size =
                new System.Drawing.Size(250, 25);

            this.dtpExpiryDate.TabIndex = 13;


            // =====================================================
            // btnSave
            // =====================================================

            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnSave.Location =
                new System.Drawing.Point(20, 455);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(100, 40);

            this.btnSave.TabIndex = 2;

            this.btnSave.Text =
                "SAVE";

            this.btnSave.UseVisualStyleBackColor =
                true;

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click
                );


            // =====================================================
            // btnUpdate
            // =====================================================

            this.btnUpdate.Enabled = false;

            this.btnUpdate.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnUpdate.Location =
                new System.Drawing.Point(130, 455);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(100, 40);

            this.btnUpdate.TabIndex = 3;

            this.btnUpdate.Text =
                "UPDATE";

            this.btnUpdate.UseVisualStyleBackColor =
                true;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click
                );


            // =====================================================
            // btnClear
            // =====================================================

            this.btnClear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnClear.Location =
                new System.Drawing.Point(240, 455);

            this.btnClear.Name =
                "btnClear";

            this.btnClear.Size =
                new System.Drawing.Size(100, 40);

            this.btnClear.TabIndex = 4;

            this.btnClear.Text =
                "CLEAR";

            this.btnClear.UseVisualStyleBackColor =
                true;

            this.btnClear.Click +=
                new System.EventHandler(
                    this.btnClear_Click
                );


            // =====================================================
            // btnDelete
            // =====================================================

            this.btnDelete.Enabled = false;

            this.btnDelete.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnDelete.Location =
                new System.Drawing.Point(350, 455);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(100, 40);

            this.btnDelete.TabIndex = 5;

            this.btnDelete.Text =
                "DELETE";

            this.btnDelete.UseVisualStyleBackColor =
                true;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click
                );


            // =====================================================
            // lblMemberList
            // =====================================================

            this.lblMemberList.AutoSize = true;

            this.lblMemberList.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblMemberList.Location =
                new System.Drawing.Point(500, 70);

            this.lblMemberList.Name =
                "lblMemberList";

            this.lblMemberList.Size =
                new System.Drawing.Size(120, 20);

            this.lblMemberList.TabIndex = 6;

            this.lblMemberList.Text =
                "MEMBER LIST";


            // =====================================================
            // dgvMembers
            // =====================================================

            this.dgvMembers.AllowUserToAddRows =
                false;

            this.dgvMembers.AllowUserToDeleteRows =
                false;

            this.dgvMembers.AllowUserToResizeRows =
                false;

            this.dgvMembers.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvMembers.BackgroundColor =
                System.Drawing.SystemColors.Window;

            this.dgvMembers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvMembers.Location =
                new System.Drawing.Point(500, 105);

            this.dgvMembers.MultiSelect = false;

            this.dgvMembers.Name =
                "dgvMembers";

            this.dgvMembers.ReadOnly = true;

            this.dgvMembers.RowHeadersVisible = false;

            this.dgvMembers.RowTemplate.Height = 28;

            this.dgvMembers.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvMembers.Size =
                new System.Drawing.Size(550, 390);

            this.dgvMembers.TabIndex = 7;

            this.dgvMembers.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvMembers_CellClick
                );


            // =====================================================
            // StaffMemberForm
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 23F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1080, 530);

            this.Controls.Add(
                this.dgvMembers
            );

            this.Controls.Add(
                this.lblMemberList
            );

            this.Controls.Add(
                this.btnDelete
            );

            this.Controls.Add(
                this.btnClear
            );

            this.Controls.Add(
                this.btnUpdate
            );

            this.Controls.Add(
                this.btnSave
            );

            this.Controls.Add(
                this.grpMemberInfo
            );

            this.Controls.Add(
                this.lblTitle
            );

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.Name =
                "StaffMemberForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gym Management System - Member Management By Staff";

            this.Load +=
                new System.EventHandler(
                    this.StaffMemberForm_Load
                );


            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMembers)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion


        // =========================================================
        // CONTROLS
        // =========================================================

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpMemberInfo;

        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;

        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.ComboBox cmbMembershipType;

        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;

        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblMemberList;

        private System.Windows.Forms.DataGridView dgvMembers;
    }
}

