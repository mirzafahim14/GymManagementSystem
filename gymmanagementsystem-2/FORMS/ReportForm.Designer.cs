namespace gymmanagementsystem_2.FORMS
{
    partial class ReportForm
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
            this.pnlReportFilter = new System.Windows.Forms.Panel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTodayAttendance = new System.Windows.Forms.Panel();
            this.lblTodayAttendance = new System.Windows.Forms.Label();
            this.pnlTotalPayments = new System.Windows.Forms.Panel();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.pnlTotalTrainers = new System.Windows.Forms.Panel();
            this.lblTotalTrainers = new System.Windows.Forms.Label();
            this.pnlTotalMembers = new System.Windows.Forms.Panel();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainReport = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblMainReportTitle = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlReportFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTodayAttendance.SuspendLayout();
            this.pnlTotalPayments.SuspendLayout();
            this.pnlTotalTrainers.SuspendLayout();
            this.pnlTotalMembers.SuspendLayout();
            this.pnlMainReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportFilter
            // 
            this.pnlReportFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReportFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportFilter.Controls.Add(this.dtpDateTo);
            this.pnlReportFilter.Controls.Add(this.lblDateTo);
            this.pnlReportFilter.Controls.Add(this.dtpDateFrom);
            this.pnlReportFilter.Controls.Add(this.lblDateFrom);
            this.pnlReportFilter.Controls.Add(this.panel2);
            this.pnlReportFilter.Controls.Add(this.btnClear);
            this.pnlReportFilter.Controls.Add(this.btnViewReport);
            this.pnlReportFilter.Controls.Add(this.cmbReportType);
            this.pnlReportFilter.Controls.Add(this.lblReportType);
            this.pnlReportFilter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlReportFilter.Location = new System.Drawing.Point(21, 73);
            this.pnlReportFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlReportFilter.Name = "pnlReportFilter";
            this.pnlReportFilter.Size = new System.Drawing.Size(631, 606);
            this.pnlReportFilter.TabIndex = 1;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(404, 29);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(130, 30);
            this.dtpDateTo.TabIndex = 9;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(304, 34);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(94, 25);
            this.lblDateTo.TabIndex = 8;
            this.lblDateTo.Text = "Date To";
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(146, 34);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(130, 30);
            this.dtpDateFrom.TabIndex = 7;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(11, 34);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(119, 25);
            this.lblDateFrom.TabIndex = 6;
            this.lblDateFrom.Text = "Date From";
            this.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateFrom.Click += new System.EventHandler(this.lblDateFrom_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(491, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(355, 80);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(130, 35);
            this.btnViewReport.TabIndex = 4;
            this.btnViewReport.Text = "VIEW REPORT";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(146, 84);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(180, 31);
            this.cmbReportType.TabIndex = 3;
            // 
            // lblReportType
            // 
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(11, 90);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(140, 25);
            this.lblReportType.TabIndex = 2;
            this.lblReportType.Text = "Report Type";
            this.lblReportType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlTotalTrainers);
            this.panel2.Controls.Add(this.pnlTodayAttendance);
            this.panel2.Controls.Add(this.pnlTotalPayments);
            this.panel2.Controls.Add(this.pnlTotalMembers);
            this.panel2.Controls.Add(this.lblSummaryTitle);
            this.panel2.Location = new System.Drawing.Point(170, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 447);
            this.panel2.TabIndex = 1;
            // 
            // pnlTodayAttendance
            // 
            this.pnlTodayAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodayAttendance.Controls.Add(this.lblTodayAttendance);
            this.pnlTodayAttendance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlTodayAttendance.Location = new System.Drawing.Point(65, 354);
            this.pnlTodayAttendance.Name = "pnlTodayAttendance";
            this.pnlTodayAttendance.Size = new System.Drawing.Size(279, 76);
            this.pnlTodayAttendance.TabIndex = 11;
            // 
            // lblTodayAttendance
            // 
            this.lblTodayAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayAttendance.Location = new System.Drawing.Point(33, 20);
            this.lblTodayAttendance.Name = "lblTodayAttendance";
            this.lblTodayAttendance.Size = new System.Drawing.Size(188, 30);
            this.lblTodayAttendance.TabIndex = 0;
            this.lblTodayAttendance.Text = "Today\'s Attendance: 0";
            this.lblTodayAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalPayments
            // 
            this.pnlTotalPayments.Controls.Add(this.lblTotalPayments);
            this.pnlTotalPayments.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlTotalPayments.Location = new System.Drawing.Point(64, 246);
            this.pnlTotalPayments.Name = "pnlTotalPayments";
            this.pnlTotalPayments.Size = new System.Drawing.Size(280, 76);
            this.pnlTotalPayments.TabIndex = 10;
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.Location = new System.Drawing.Point(53, 16);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(184, 43);
            this.lblTotalPayments.TabIndex = 0;
            this.lblTotalPayments.Text = "Total Payments: 0";
            this.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalTrainers
            // 
            this.pnlTotalTrainers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalTrainers.Controls.Add(this.lblTotalTrainers);
            this.pnlTotalTrainers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlTotalTrainers.Location = new System.Drawing.Point(64, 153);
            this.pnlTotalTrainers.Name = "pnlTotalTrainers";
            this.pnlTotalTrainers.Size = new System.Drawing.Size(280, 66);
            this.pnlTotalTrainers.TabIndex = 9;
            // 
            // lblTotalTrainers
            // 
            this.lblTotalTrainers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTrainers.Location = new System.Drawing.Point(31, 15);
            this.lblTotalTrainers.Name = "lblTotalTrainers";
            this.lblTotalTrainers.Size = new System.Drawing.Size(225, 30);
            this.lblTotalTrainers.TabIndex = 9;
            this.lblTotalTrainers.Text = "Total Trainers: 0";
            this.lblTotalTrainers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalMembers
            // 
            this.pnlTotalMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalMembers.Controls.Add(this.lblTotalMembers);
            this.pnlTotalMembers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlTotalMembers.Location = new System.Drawing.Point(64, 33);
            this.pnlTotalMembers.Name = "pnlTotalMembers";
            this.pnlTotalMembers.Size = new System.Drawing.Size(280, 83);
            this.pnlTotalMembers.TabIndex = 8;
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembers.Location = new System.Drawing.Point(10, 10);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(240, 51);
            this.lblTotalMembers.TabIndex = 0;
            this.lblTotalMembers.Text = "Total Members: 0";
            this.lblTotalMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSummaryTitle.Location = new System.Drawing.Point(81, 5);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(234, 25);
            this.lblSummaryTitle.TabIndex = 7;
            this.lblSummaryTitle.Text = "REPORT SUMMARY";
            this.lblSummaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(28, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1322, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "GYM MANAGEMENT REPORTS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainReport
            // 
            this.pnlMainReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainReport.Controls.Add(this.dgvReport);
            this.pnlMainReport.Controls.Add(this.lblMainReportTitle);
            this.pnlMainReport.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlMainReport.Location = new System.Drawing.Point(714, 73);
            this.pnlMainReport.Name = "pnlMainReport";
            this.pnlMainReport.Size = new System.Drawing.Size(736, 511);
            this.pnlMainReport.TabIndex = 12;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(30, 48);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 30;
            this.dgvReport.Size = new System.Drawing.Size(686, 447);
            this.dgvReport.TabIndex = 14;
            // 
            // lblMainReportTitle
            // 
            this.lblMainReportTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainReportTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainReportTitle.Location = new System.Drawing.Point(25, 15);
            this.lblMainReportTitle.Name = "lblMainReportTitle";
            this.lblMainReportTitle.Size = new System.Drawing.Size(706, 30);
            this.lblMainReportTitle.TabIndex = 0;
            this.lblMainReportTitle.Text = "REPORT DETAILS";
            this.lblMainReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExport.Location = new System.Drawing.Point(696, 602);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(171, 40);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "EXPORT REPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Location = new System.Drawing.Point(914, 602);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 37);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "PRINT REPORT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1476, 691);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlMainReport);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlReportFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Reports";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.pnlReportFilter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTodayAttendance.ResumeLayout(false);
            this.pnlTotalPayments.ResumeLayout(false);
            this.pnlTotalTrainers.ResumeLayout(false);
            this.pnlTotalMembers.ResumeLayout(false);
            this.pnlMainReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Panel pnlTotalMembers;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Panel pnlTotalTrainers;
        private System.Windows.Forms.Label lblTotalTrainers;
        private System.Windows.Forms.Panel pnlTodayAttendance;
        private System.Windows.Forms.Panel pnlTotalPayments;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label lblTodayAttendance;
        private System.Windows.Forms.Panel pnlMainReport;
        private System.Windows.Forms.Label lblMainReportTitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
    }
}