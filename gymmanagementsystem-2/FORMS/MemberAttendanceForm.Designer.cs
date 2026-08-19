namespace gymmanagementsystem_2.FORMS
{
    partial class MemberAttendanceForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.lblPresentDays = new System.Windows.Forms.Label();
            this.lblAbsentDays = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(253, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MY ATTENDANCE";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(26, 78);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(122, 23);
            this.lblMemberId.TabIndex = 3;
            this.lblMemberId.Text = "Member ID: —";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(26, 105);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(151, 23);
            this.lblMemberName.TabIndex = 5;
            this.lblMemberName.Text = "Member Name: —";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDays.Location = new System.Drawing.Point(26, 140);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(165, 23);
            this.lblTotalDays.TabIndex = 7;
            this.lblTotalDays.Text = "Total Attendance: —";
            // 
            // lblPresentDays
            // 
            this.lblPresentDays.AutoSize = true;
            this.lblPresentDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentDays.Location = new System.Drawing.Point(396, 87);
            this.lblPresentDays.Name = "lblPresentDays";
            this.lblPresentDays.Size = new System.Drawing.Size(93, 23);
            this.lblPresentDays.TabIndex = 9;
            this.lblPresentDays.Text = "Present: —";
            // 
            // lblAbsentDays
            // 
            this.lblAbsentDays.AutoSize = true;
            this.lblAbsentDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsentDays.Location = new System.Drawing.Point(396, 125);
            this.lblAbsentDays.Name = "lblAbsentDays";
            this.lblAbsentDays.Size = new System.Drawing.Size(89, 23);
            this.lblAbsentDays.TabIndex = 11;
            this.lblAbsentDays.Text = "Absent: —";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(30, 189);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(645, 158);
            this.dgvAttendance.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(143, 382);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(218, 37);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(425, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(250, 37);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // MemberAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lblAbsentDays);
            this.Controls.Add(this.lblPresentDays);
            this.Controls.Add(this.lblTotalDays);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblTitle);
            this.Name = "MemberAttendanceForm";
            this.Text = "MemberAttendanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblTotalDays;
        private System.Windows.Forms.Label lblPresentDays;
        private System.Windows.Forms.Label lblAbsentDays;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}