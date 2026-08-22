namespace gymmanagementsystem_2.FORMS
{
    partial class StaffAttendanceForm
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
            this.lblAttendanceHeading = new System.Windows.Forms.Label();
            this.pnlAttendanceInput = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblAttendanceDate = new System.Windows.Forms.Label();
            this.cmbMemberId = new System.Windows.Forms.ComboBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.pnlAttendanceData = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlAttendanceSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();

            this.pnlAttendanceInput.SuspendLayout();
            this.pnlAttendanceData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlAttendanceSearch.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // HEADING
            // =====================================================
            this.lblAttendanceHeading.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                   System.Windows.Forms.AnchorStyles.Left) |
                   System.Windows.Forms.AnchorStyles.Right)));

            this.lblAttendanceHeading.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblAttendanceHeading.Location =
                new System.Drawing.Point(40, 20);

            this.lblAttendanceHeading.Name =
                "lblAttendanceHeading";

            this.lblAttendanceHeading.Size =
                new System.Drawing.Size(1220, 40);

            this.lblAttendanceHeading.TabIndex = 0;

            this.lblAttendanceHeading.Text =
                "MEMBER ATTENDANCE BY STAFF";

            this.lblAttendanceHeading.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================
            // INPUT PANEL
            // =====================================================
            this.pnlAttendanceInput.Controls.Add(
                this.btnSave);

            this.pnlAttendanceInput.Controls.Add(
                this.cmbAttendanceStatus);

            this.pnlAttendanceInput.Controls.Add(
                this.lblAttendanceStatus);

            this.pnlAttendanceInput.Controls.Add(
                this.dtpCheckOutTime);

            this.pnlAttendanceInput.Controls.Add(
                this.lblCheckOutTime);

            this.pnlAttendanceInput.Controls.Add(
                this.dtpCheckInTime);

            this.pnlAttendanceInput.Controls.Add(
                this.lblCheckInTime);

            this.pnlAttendanceInput.Controls.Add(
                this.dtpAttendanceDate);

            this.pnlAttendanceInput.Controls.Add(
                this.lblAttendanceDate);

            this.pnlAttendanceInput.Controls.Add(
                this.cmbMemberId);

            this.pnlAttendanceInput.Controls.Add(
                this.lblMemberId);

            this.pnlAttendanceInput.Location =
                new System.Drawing.Point(40, 90);

            this.pnlAttendanceInput.Name =
                "pnlAttendanceInput";

            this.pnlAttendanceInput.Size =
                new System.Drawing.Size(430, 469);

            this.pnlAttendanceInput.TabIndex = 1;

            // =====================================================
            // MEMBER ID LABEL
            // =====================================================
            this.lblMemberId.Location =
                new System.Drawing.Point(10, 20);

            this.lblMemberId.Name =
                "lblMemberId";

            this.lblMemberId.Size =
                new System.Drawing.Size(130, 30);

            this.lblMemberId.TabIndex = 0;

            this.lblMemberId.Text =
                "Member";

            this.lblMemberId.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =====================================================
            // MEMBER COMBOBOX
            // =====================================================
            this.cmbMemberId.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbMemberId.FormattingEnabled = true;

            this.cmbMemberId.Location =
                new System.Drawing.Point(150, 20);

            this.cmbMemberId.Name =
                "cmbMemberId";

            this.cmbMemberId.Size =
                new System.Drawing.Size(260, 28);

            this.cmbMemberId.TabIndex = 1;

            // =====================================================
            // DATE LABEL
            // =====================================================
            this.lblAttendanceDate.Location =
                new System.Drawing.Point(10, 70);

            this.lblAttendanceDate.Name =
                "lblAttendanceDate";

            this.lblAttendanceDate.Size =
                new System.Drawing.Size(130, 30);

            this.lblAttendanceDate.TabIndex = 2;

            this.lblAttendanceDate.Text =
                "Attendance Date";

            this.lblAttendanceDate.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =====================================================
            // DATE PICKER
            // =====================================================
            this.dtpAttendanceDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpAttendanceDate.Location =
                new System.Drawing.Point(150, 70);

            this.dtpAttendanceDate.Name =
                "dtpAttendanceDate";

            this.dtpAttendanceDate.Size =
                new System.Drawing.Size(260, 27);

            this.dtpAttendanceDate.TabIndex = 3;

            // =====================================================
            // CHECK-IN LABEL
            // =====================================================
            this.lblCheckInTime.Location =
                new System.Drawing.Point(10, 120);

            this.lblCheckInTime.Name =
                "lblCheckInTime";

            this.lblCheckInTime.Size =
                new System.Drawing.Size(130, 30);

            this.lblCheckInTime.TabIndex = 4;

            this.lblCheckInTime.Text =
                "Check-In Time";

            this.lblCheckInTime.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =====================================================
            // CHECK-IN
            // =====================================================
            this.dtpCheckInTime.Format =
                System.Windows.Forms.DateTimePickerFormat.Time;

            this.dtpCheckInTime.Location =
                new System.Drawing.Point(150, 120);

            this.dtpCheckInTime.Name =
                "dtpCheckInTime";

            this.dtpCheckInTime.ShowUpDown = true;

            this.dtpCheckInTime.Size =
                new System.Drawing.Size(260, 27);

            this.dtpCheckInTime.TabIndex = 5;

            // =====================================================
            // CHECK-OUT LABEL
            // =====================================================
            this.lblCheckOutTime.Location =
                new System.Drawing.Point(10, 170);

            this.lblCheckOutTime.Name =
                "lblCheckOutTime";

            this.lblCheckOutTime.Size =
                new System.Drawing.Size(130, 30);

            this.lblCheckOutTime.TabIndex = 6;

            this.lblCheckOutTime.Text =
                "Check-Out Time";

            this.lblCheckOutTime.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =====================================================
            // CHECK-OUT
            // =====================================================
            this.dtpCheckOutTime.Format =
                System.Windows.Forms.DateTimePickerFormat.Time;

            this.dtpCheckOutTime.Location =
                new System.Drawing.Point(150, 170);

            this.dtpCheckOutTime.Name =
                "dtpCheckOutTime";

            this.dtpCheckOutTime.ShowUpDown = true;

            this.dtpCheckOutTime.Size =
                new System.Drawing.Size(260, 27);

            this.dtpCheckOutTime.TabIndex = 7;

            // =====================================================
            // STATUS LABEL
            // =====================================================
            this.lblAttendanceStatus.Location =
                new System.Drawing.Point(10, 220);

            this.lblAttendanceStatus.Name =
                "lblAttendanceStatus";

            this.lblAttendanceStatus.Size =
                new System.Drawing.Size(130, 30);

            this.lblAttendanceStatus.TabIndex = 8;

            this.lblAttendanceStatus.Text =
                "Status";

            this.lblAttendanceStatus.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =====================================================
            // STATUS COMBOBOX
            // =====================================================
            this.cmbAttendanceStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbAttendanceStatus.FormattingEnabled = true;

            this.cmbAttendanceStatus.Location =
                new System.Drawing.Point(150, 220);

            this.cmbAttendanceStatus.Name =
                "cmbAttendanceStatus";

            this.cmbAttendanceStatus.Size =
                new System.Drawing.Size(260, 28);

            this.cmbAttendanceStatus.TabIndex = 9;

            // =====================================================
            // SAVE BUTTON
            // =====================================================
            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btnSave.Location =
                new System.Drawing.Point(150, 270);

            this.btnSave.Name =
                "btnSave";

            this.btnSave.Size =
                new System.Drawing.Size(120, 35);

            this.btnSave.TabIndex = 10;

            this.btnSave.Text =
                "SAVE";

            this.btnSave.UseVisualStyleBackColor = true;

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click);

            // =====================================================
            // SEARCH PANEL
            // =====================================================
            this.pnlAttendanceSearch.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                   System.Windows.Forms.AnchorStyles.Left) |
                   System.Windows.Forms.AnchorStyles.Right)));

            this.pnlAttendanceSearch.Controls.Add(
                this.txtSearch);

            this.pnlAttendanceSearch.Controls.Add(
                this.lblSearch);

            this.pnlAttendanceSearch.Location =
                new System.Drawing.Point(490, 90);

            this.pnlAttendanceSearch.Name =
                "pnlAttendanceSearch";

            this.pnlAttendanceSearch.Size =
                new System.Drawing.Size(770, 60);

            this.pnlAttendanceSearch.TabIndex = 2;

            // =====================================================
            // SEARCH LABEL
            // =====================================================
            this.lblSearch.Location =
                new System.Drawing.Point(10, 15);

            this.lblSearch.Name =
                "lblSearch";

            this.lblSearch.Size =
                new System.Drawing.Size(150, 30);

            this.lblSearch.TabIndex = 0;

            this.lblSearch.Text =
                "Search Attendance";

            this.lblSearch.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // =====================================================
            // SEARCH TEXTBOX
            // =====================================================
            this.txtSearch.Location =
                new System.Drawing.Point(170, 16);

            this.txtSearch.Name =
                "txtSearch";

            this.txtSearch.Size =
                new System.Drawing.Size(300, 27);

            this.txtSearch.TabIndex = 1;

            this.txtSearch.TextChanged +=
                new System.EventHandler(
                    this.txtSearch_TextChanged);

            // =====================================================
            // DATA PANEL
            // =====================================================
            this.pnlAttendanceData.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                    System.Windows.Forms.AnchorStyles.Bottom) |
                    System.Windows.Forms.AnchorStyles.Left) |
                    System.Windows.Forms.AnchorStyles.Right)));

            this.pnlAttendanceData.Controls.Add(
                this.dgvAttendance);

            this.pnlAttendanceData.Location =
                new System.Drawing.Point(490, 160);

            this.pnlAttendanceData.Name =
                "pnlAttendanceData";

            this.pnlAttendanceData.Size =
                new System.Drawing.Size(770, 399);

            this.pnlAttendanceData.TabIndex = 3;

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================
            this.dgvAttendance.AllowUserToAddRows = false;

            this.dgvAttendance.AllowUserToDeleteRows = false;

            this.dgvAttendance.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvAttendance.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvAttendance.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvAttendance.Location =
                new System.Drawing.Point(0, 0);

            this.dgvAttendance.MultiSelect = false;

            this.dgvAttendance.Name =
                "dgvAttendance";

            this.dgvAttendance.ReadOnly = true;

            this.dgvAttendance.RowHeadersWidth = 51;

            this.dgvAttendance.RowTemplate.Height = 24;

            this.dgvAttendance.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvAttendance.Size =
                new System.Drawing.Size(770, 399);

            this.dgvAttendance.TabIndex = 0;

            this.dgvAttendance.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvAttendance_CellClick);

            // =====================================================
            // FORM
            // =====================================================
            this.ClientSize =
                new System.Drawing.Size(1300, 600);

            this.Controls.Add(
                this.pnlAttendanceData);

            this.Controls.Add(
                this.pnlAttendanceSearch);

            this.Controls.Add(
                this.pnlAttendanceInput);

            this.Controls.Add(
                this.lblAttendanceHeading);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.Name =
                "StaffAttendanceForm";

            this.Text =
                "Member Attendance By Staff";

            this.pnlAttendanceInput.ResumeLayout(false);

            this.pnlAttendanceData.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAttendance)).EndInit();

            this.pnlAttendanceSearch.ResumeLayout(false);

            this.pnlAttendanceSearch.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblAttendanceHeading;

        private System.Windows.Forms.Panel pnlAttendanceInput;

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.ComboBox cmbMemberId;

        private System.Windows.Forms.Label lblAttendanceDate;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;

        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;

        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.DateTimePicker dtpCheckOutTime;

        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Panel pnlAttendanceSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Panel pnlAttendanceData;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}