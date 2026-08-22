namespace gymmanagementsystem_2.FORMS
{
    partial class StaffWorkoutForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvWorkouts;
        private System.Windows.Forms.Panel panelTop;

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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            this.SuspendLayout();

            // =====================================================
            // lblTitle
            // =====================================================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point
                );

            this.lblTitle.Location =
                new System.Drawing.Point(20, 20);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(250, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text =
                "WORKOUT PLANS";


            // =====================================================
            // PANEL TOP
            // =====================================================

            this.panelTop.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.panelTop.Controls.Add(
                this.lblSearch
            );

            this.panelTop.Controls.Add(
                this.txtSearch
            );

            this.panelTop.Controls.Add(
                this.btnRefresh
            );

            this.panelTop.Controls.Add(
                this.btnClose
            );

            this.panelTop.Location =
                new System.Drawing.Point(20, 75);

            this.panelTop.Name =
                "panelTop";

            this.panelTop.Size =
                new System.Drawing.Size(1140, 70);

            this.panelTop.TabIndex = 1;


            // =====================================================
            // lblSearch
            // =====================================================

            this.lblSearch.AutoSize = true;

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point
                );

            this.lblSearch.Location =
                new System.Drawing.Point(20, 23);

            this.lblSearch.Name =
                "lblSearch";

            this.lblSearch.Size =
                new System.Drawing.Size(55, 19);

            this.lblSearch.TabIndex = 0;

            this.lblSearch.Text =
                "Search:";


            // =====================================================
            // txtSearch
            // =====================================================

            this.txtSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point
                );

            this.txtSearch.Location =
                new System.Drawing.Point(85, 19);

            this.txtSearch.Name =
                "txtSearch";

            this.txtSearch.Size =
                new System.Drawing.Size(500, 25);

            this.txtSearch.TabIndex = 1;

            this.txtSearch.TextChanged +=
                new System.EventHandler(
                    this.txtSearch_TextChanged
                );


            // =====================================================
            // btnRefresh
            // =====================================================

            this.btnRefresh.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point
                );

            this.btnRefresh.Location =
                new System.Drawing.Point(610, 17);

            this.btnRefresh.Name =
                "btnRefresh";

            this.btnRefresh.Size =
                new System.Drawing.Size(110, 30);

            this.btnRefresh.TabIndex = 2;

            this.btnRefresh.Text =
                "REFRESH";

            this.btnRefresh.UseVisualStyleBackColor =
                true;

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
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point
                );

            this.btnClose.Location =
                new System.Drawing.Point(990, 17);

            this.btnClose.Name =
                "btnClose";

            this.btnClose.Size =
                new System.Drawing.Size(120, 30);

            this.btnClose.TabIndex = 3;

            this.btnClose.Text =
                "CLOSE";

            this.btnClose.UseVisualStyleBackColor =
                true;

            this.btnClose.Click +=
                new System.EventHandler(
                    this.btnClose_Click
                );


            // =====================================================
            // dgvWorkouts
            // =====================================================

            this.dgvWorkouts.AllowUserToAddRows =
                false;

            this.dgvWorkouts.AllowUserToDeleteRows =
                false;

            this.dgvWorkouts.AllowUserToResizeRows =
                false;

            this.dgvWorkouts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvWorkouts.BackgroundColor =
                System.Drawing.SystemColors.Window;

            this.dgvWorkouts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvWorkouts.Location =
                new System.Drawing.Point(20, 165);

            this.dgvWorkouts.MultiSelect =
                false;

            this.dgvWorkouts.Name =
                "dgvWorkouts";

            this.dgvWorkouts.ReadOnly =
                true;

            this.dgvWorkouts.RowHeadersVisible =
                false;

            this.dgvWorkouts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvWorkouts.Size =
                new System.Drawing.Size(1140, 470);

            this.dgvWorkouts.TabIndex = 2;

            this.dgvWorkouts.SelectionChanged +=
                new System.EventHandler(
                    this.dgvWorkouts_SelectionChanged
                );


            // =====================================================
            // StaffWorkoutForm
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1180, 670);

            this.Controls.Add(
                this.dgvWorkouts
            );

            this.Controls.Add(
                this.panelTop
            );

            this.Controls.Add(
                this.lblTitle
            );

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox =
                false;

            this.Name =
                "StaffWorkoutForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gym Management System - Staff Workout";

            this.Load +=
                new System.EventHandler(
                    this.StaffWorkoutForm_Load
                );

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvWorkouts)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        #endregion
    }
}