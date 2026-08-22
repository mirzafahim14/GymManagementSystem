namespace gymmanagementsystem_2.FORMS
{
    partial class StaffHealthForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStaffInfo;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.DataGridView dgvHealthRecords;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStaffInfo = new System.Windows.Forms.Label();

            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.dgvHealthRecords = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).BeginInit();

            this.SuspendLayout();


            // =====================================================
            // lblTitle
            // =====================================================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTitle.Location =
                new System.Drawing.Point(35, 25);

            this.lblTitle.Name = "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(250, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "HEALTH RECORDS";


            // =====================================================
            // lblStaffInfo
            // =====================================================

            this.lblStaffInfo.AutoSize = true;

            this.lblStaffInfo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular
                );

            this.lblStaffInfo.Location =
                new System.Drawing.Point(38, 68);

            this.lblStaffInfo.Name =
                "lblStaffInfo";

            this.lblStaffInfo.Size =
                new System.Drawing.Size(180, 19);

            this.lblStaffInfo.TabIndex = 1;

            this.lblStaffInfo.Text =
                "Staff: - | Role: Staff";


            // =====================================================
            // lblSearch
            // =====================================================

            this.lblSearch.AutoSize = true;

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblSearch.Location =
                new System.Drawing.Point(38, 115);

            this.lblSearch.Name =
                "lblSearch";

            this.lblSearch.Size =
                new System.Drawing.Size(115, 19);

            this.lblSearch.TabIndex = 2;

            this.lblSearch.Text =
                "Search Member:";


            // =====================================================
            // txtSearch
            // =====================================================

            this.txtSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );

            this.txtSearch.Location =
                new System.Drawing.Point(155, 111);

            this.txtSearch.Name =
                "txtSearch";

            this.txtSearch.Size =
                new System.Drawing.Size(300, 25);

            this.txtSearch.TabIndex = 3;

            this.txtSearch.TextChanged +=
                new System.EventHandler(
                    this.txtSearch_TextChanged
                );


            // =====================================================
            // btnSearch
            // =====================================================

            this.btnSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnSearch.Location =
                new System.Drawing.Point(470, 109);

            this.btnSearch.Name =
                "btnSearch";

            this.btnSearch.Size =
                new System.Drawing.Size(100, 30);

            this.btnSearch.TabIndex = 4;

            this.btnSearch.Text =
                "SEARCH";

            this.btnSearch.UseVisualStyleBackColor = true;

            this.btnSearch.Click +=
                new System.EventHandler(
                    this.btnSearch_Click
                );


            // =====================================================
            // btnRefresh
            // =====================================================

            this.btnRefresh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnRefresh.Location =
                new System.Drawing.Point(585, 109);

            this.btnRefresh.Name =
                "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(100, 30);

            this.btnRefresh.TabIndex = 5;

            this.btnRefresh.Text =
                "REFRESH";

            this.btnRefresh.UseVisualStyleBackColor = true;

            this.btnRefresh.Click +=
                new System.EventHandler(
                    this.btnRefresh_Click
                );


            // =====================================================
            // btnClose
            // =====================================================

            this.btnClose.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );

            this.btnClose.Location =
                new System.Drawing.Point(700, 109);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(100, 30);

            this.btnClose.TabIndex = 6;

            this.btnClose.Text =
                "CLOSE";

            this.btnClose.UseVisualStyleBackColor = true;

            this.btnClose.Click +=
                new System.EventHandler(
                    this.btnClose_Click
                );


            // =====================================================
            // dgvHealthRecords
            // =====================================================

            this.dgvHealthRecords.AllowUserToAddRows = false;

            this.dgvHealthRecords.AllowUserToDeleteRows = false;

            this.dgvHealthRecords.AllowUserToResizeRows = false;

            this.dgvHealthRecords.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvHealthRecords.BackgroundColor =
                System.Drawing.SystemColors.Window;

            this.dgvHealthRecords.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvHealthRecords.Location =
                new System.Drawing.Point(38, 165);

            this.dgvHealthRecords.MultiSelect = false;

            this.dgvHealthRecords.Name =
                "dgvHealthRecords";

            this.dgvHealthRecords.ReadOnly = true;

            this.dgvHealthRecords.RowHeadersVisible = false;

            this.dgvHealthRecords.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvHealthRecords.Size =
                new System.Drawing.Size(1030, 450);

            this.dgvHealthRecords.TabIndex = 7;

            this.dgvHealthRecords.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvHealthRecords_CellClick
                );


            // =====================================================
            // StaffHealthForm
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1110, 660);

            this.Controls.Add(
                this.dgvHealthRecords
            );

            this.Controls.Add(
                this.btnClose
            );

            this.Controls.Add(
                this.btnRefresh
            );

            this.Controls.Add(
                this.btnSearch
            );

            this.Controls.Add(
                this.txtSearch
            );

            this.Controls.Add(
                this.lblSearch
            );

            this.Controls.Add(
                this.lblStaffInfo
            );

            this.Controls.Add(
                this.lblTitle
            );

            this.Name =
                "StaffHealthForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gym Management System - Staff Health Records";

            this.Load +=
                new System.EventHandler(
                    this.StaffHealthForm_Load
                );

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvHealthRecords)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}