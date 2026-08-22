namespace gymmanagementsystem_2.FORMS
{
    partial class StaffBasicReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.DataGridView dgvReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblReportType =
                new System.Windows.Forms.Label();

            this.cmbReportType =
                new System.Windows.Forms.ComboBox();

            this.lblFrom =
                new System.Windows.Forms.Label();

            this.dtpFrom =
                new System.Windows.Forms.DateTimePicker();

            this.lblTo =
                new System.Windows.Forms.Label();

            this.dtpTo =
                new System.Windows.Forms.DateTimePicker();

            this.btnGenerate =
                new System.Windows.Forms.Button();

            this.btnRefresh =
                new System.Windows.Forms.Button();

            this.btnClose =
                new System.Windows.Forms.Button();

            this.lblTotalRecords =
                new System.Windows.Forms.Label();

            this.dgvReport =
                new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvReport)).BeginInit();

            this.SuspendLayout();

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1100, 650);

            this.Name =
                "StaffBasicReportForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Staff - Basic Reports";

            this.Load +=
                new System.EventHandler(
                    this.StaffBasicReportForm_Load);

            // =====================================================
            // TITLE
            // =====================================================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(35, 25);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(220, 37);

            this.lblTitle.Text =
                "BASIC REPORTS";

            // =====================================================
            // REPORT TYPE LABEL
            // =====================================================

            this.lblReportType.AutoSize = true;

            this.lblReportType.Location =
                new System.Drawing.Point(40, 90);

            this.lblReportType.Name =
                "lblReportType";

            this.lblReportType.Size =
                new System.Drawing.Size(74, 15);

            this.lblReportType.Text =
                "Report Type:";

            // =====================================================
            // REPORT TYPE COMBOBOX
            // =====================================================

            this.cmbReportType.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbReportType.FormattingEnabled = true;

            this.cmbReportType.Location =
                new System.Drawing.Point(125, 86);

            this.cmbReportType.Name =
                "cmbReportType";

            this.cmbReportType.Size =
                new System.Drawing.Size(220, 23);

            this.cmbReportType.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbReportType_SelectedIndexChanged);

            // =====================================================
            // FROM LABEL
            // =====================================================

            this.lblFrom.AutoSize = true;

            this.lblFrom.Location =
                new System.Drawing.Point(375, 90);

            this.lblFrom.Name =
                "lblFrom";

            this.lblFrom.Size =
                new System.Drawing.Size(34, 15);

            this.lblFrom.Text =
                "From:";

            // =====================================================
            // FROM DATE
            // =====================================================

            this.dtpFrom.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpFrom.Location =
                new System.Drawing.Point(420, 86);

            this.dtpFrom.Name =
                "dtpFrom";

            this.dtpFrom.Size =
                new System.Drawing.Size(120, 23);

            this.dtpFrom.ValueChanged +=
                new System.EventHandler(
                    this.dtpFrom_ValueChanged);

            // =====================================================
            // TO LABEL
            // =====================================================

            this.lblTo.AutoSize = true;

            this.lblTo.Location =
                new System.Drawing.Point(565, 90);

            this.lblTo.Name =
                "lblTo";

            this.lblTo.Size =
                new System.Drawing.Size(22, 15);

            this.lblTo.Text =
                "To:";

            // =====================================================
            // TO DATE
            // =====================================================

            this.dtpTo.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpTo.Location =
                new System.Drawing.Point(595, 86);

            this.dtpTo.Name =
                "dtpTo";

            this.dtpTo.Size =
                new System.Drawing.Size(120, 23);

            this.dtpTo.ValueChanged +=
                new System.EventHandler(
                    this.dtpTo_ValueChanged);

            // =====================================================
            // GENERATE BUTTON
            // =====================================================

            this.btnGenerate.Location =
                new System.Drawing.Point(745, 82);

            this.btnGenerate.Name =
                "btnGenerate";

            this.btnGenerate.Size =
                new System.Drawing.Size(105, 32);

            this.btnGenerate.Text =
                "Generate";

            this.btnGenerate.UseVisualStyleBackColor =
                true;

            this.btnGenerate.Click +=
                new System.EventHandler(
                    this.btnGenerate_Click);

            // =====================================================
            // REFRESH BUTTON
            // =====================================================

            this.btnRefresh.Location =
                new System.Drawing.Point(860, 82);

            this.btnRefresh.Name =
                "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(95, 32);

            this.btnRefresh.Text =
                "Refresh";

            this.btnRefresh.UseVisualStyleBackColor =
                true;

            this.btnRefresh.Click +=
                new System.EventHandler(
                    this.btnRefresh_Click);

            // =====================================================
            // TOTAL RECORDS
            // =====================================================

            this.lblTotalRecords.AutoSize = true;

            this.lblTotalRecords.Location =
                new System.Drawing.Point(40, 135);

            this.lblTotalRecords.Name =
                "lblTotalRecords";

            this.lblTotalRecords.Size =
                new System.Drawing.Size(111, 15);

            this.lblTotalRecords.Text =
                "Total Records: 0";

            // =====================================================
            // DATA GRID VIEW
            // =====================================================

            this.dgvReport.AllowUserToAddRows =
                false;

            this.dgvReport.AllowUserToDeleteRows =
                false;

            this.dgvReport.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvReport.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvReport.Location =
                new System.Drawing.Point(40, 165);

            this.dgvReport.MultiSelect =
                false;

            this.dgvReport.Name =
                "dgvReport";

            this.dgvReport.ReadOnly =
                true;

            this.dgvReport.RowHeadersWidth =
                51;

            this.dgvReport.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvReport.Size =
                new System.Drawing.Size(1015, 400);

            this.dgvReport.TabIndex =
                0;

            this.dgvReport.CellContentClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvReport_CellContentClick);

            // =====================================================
            // CLOSE BUTTON
            // =====================================================

            this.btnClose.Location =
                new System.Drawing.Point(920, 585);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(135, 35);

            this.btnClose.Text =
                "Close";

            this.btnClose.UseVisualStyleBackColor =
                true;

            this.btnClose.Click +=
                new System.EventHandler(
                    this.btnClose_Click);

            // =====================================================
            // ADD CONTROLS
            // =====================================================

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cmbReportType);

            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);

            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);

            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRefresh);

            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.dgvReport);

            this.Controls.Add(this.btnClose);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvReport)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}