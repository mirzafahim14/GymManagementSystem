namespace gymmanagementsystem_2.FORMS
{
    partial class DashboardForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnWorkout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnTrainers = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblGymName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpRecentMembers = new System.Windows.Forms.GroupBox();
            this.dgvRecentMembers = new System.Windows.Forms.DataGridView();
            this.lblPaymentTitle = new System.Windows.Forms.GroupBox();
            this.IblTotalPayment = new System.Windows.Forms.Label();
            this.grpAttendance = new System.Windows.Forms.GroupBox();
            this.lblAttendanceToday = new System.Windows.Forms.Label();
            this.grpTrainers = new System.Windows.Forms.GroupBox();
            this.lblTotalTrainers = new System.Windows.Forms.Label();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpRecentMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentMembers)).BeginInit();
            this.lblPaymentTitle.SuspendLayout();
            this.grpAttendance.SuspendLayout();
            this.grpTrainers.SuspendLayout();
            this.grpMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btnHealth);
            this.pnlSidebar.Controls.Add(this.btnWorkout);
            this.pnlSidebar.Controls.Add(this.button1);
            this.pnlSidebar.Controls.Add(this.btnInvoice);
            this.pnlSidebar.Controls.Add(this.btnPayment);
            this.pnlSidebar.Controls.Add(this.btnAttendance);
            this.pnlSidebar.Controls.Add(this.btnTrainers);
            this.pnlSidebar.Controls.Add(this.btnMembers);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 605);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(0, 506);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 45);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealth.Location = new System.Drawing.Point(0, 455);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(200, 45);
            this.btnHealth.TabIndex = 9;
            this.btnHealth.Text = "Health";
            this.btnHealth.UseVisualStyleBackColor = true;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnWorkout
            // 
            this.btnWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkout.Location = new System.Drawing.Point(0, 406);
            this.btnWorkout.Name = "btnWorkout";
            this.btnWorkout.Size = new System.Drawing.Size(200, 45);
            this.btnWorkout.TabIndex = 8;
            this.btnWorkout.Text = "Workout";
            this.btnWorkout.UseVisualStyleBackColor = true;
            this.btnWorkout.Click += new System.EventHandler(this.btnWorkout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(0, 355);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(200, 45);
            this.btnInvoice.TabIndex = 6;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(0, 304);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(200, 45);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(0, 253);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(200, 45);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnTrainers
            // 
            this.btnTrainers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainers.Location = new System.Drawing.Point(0, 197);
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.Size = new System.Drawing.Size(200, 45);
            this.btnTrainers.TabIndex = 3;
            this.btnTrainers.Text = "Trainers";
            this.btnTrainers.UseVisualStyleBackColor = true;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Location = new System.Drawing.Point(0, 146);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(200, 45);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 95);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblGymName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 75);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblGymName
            // 
            this.lblGymName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGymName.Location = new System.Drawing.Point(0, 20);
            this.lblGymName.Name = "lblGymName";
            this.lblGymName.Size = new System.Drawing.Size(220, 30);
            this.lblGymName.TabIndex = 0;
            this.lblGymName.Text = "GYM MANAGEMENT";
            this.lblGymName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGymName.Click += new System.EventHandler(this.lblGymName_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Controls.Add(this.grpRecentMembers);
            this.pnlMain.Controls.Add(this.lblPaymentTitle);
            this.pnlMain.Controls.Add(this.grpAttendance);
            this.pnlMain.Controls.Add(this.grpTrainers);
            this.pnlMain.Controls.Add(this.grpMembers);
            this.pnlMain.Controls.Add(this.lblDashboardTitle);
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 700);
            this.pnlMain.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(650, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(280, 35);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome, Admin";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRecentMembers
            // 
            this.grpRecentMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecentMembers.Controls.Add(this.dgvRecentMembers);
            this.grpRecentMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecentMembers.Location = new System.Drawing.Point(25, 225);
            this.grpRecentMembers.Name = "grpRecentMembers";
            this.grpRecentMembers.Size = new System.Drawing.Size(885, 400);
            this.grpRecentMembers.TabIndex = 5;
            this.grpRecentMembers.TabStop = false;
            this.grpRecentMembers.Text = "Recent Members";
            // 
            // dgvRecentMembers
            // 
            this.dgvRecentMembers.AllowUserToAddRows = false;
            this.dgvRecentMembers.AllowUserToDeleteRows = false;
            this.dgvRecentMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentMembers.Location = new System.Drawing.Point(10, 30);
            this.dgvRecentMembers.MultiSelect = false;
            this.dgvRecentMembers.Name = "dgvRecentMembers";
            this.dgvRecentMembers.ReadOnly = true;
            this.dgvRecentMembers.RowHeadersWidth = 51;
            this.dgvRecentMembers.RowTemplate.Height = 24;
            this.dgvRecentMembers.Size = new System.Drawing.Size(865, 350);
            this.dgvRecentMembers.TabIndex = 0;
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.Controls.Add(this.IblTotalPayment);
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTitle.Location = new System.Drawing.Point(700, 85);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(210, 120);
            this.lblPaymentTitle.TabIndex = 4;
            this.lblPaymentTitle.TabStop = false;
            this.lblPaymentTitle.Text = "Payment";
            // 
            // IblTotalPayment
            // 
            this.IblTotalPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IblTotalPayment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTotalPayment.Location = new System.Drawing.Point(10, 35);
            this.IblTotalPayment.Name = "IblTotalPayment";
            this.IblTotalPayment.Size = new System.Drawing.Size(190, 40);
            this.IblTotalPayment.TabIndex = 0;
            this.IblTotalPayment.Text = "0.00";
            this.IblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAttendance
            // 
            this.grpAttendance.Controls.Add(this.lblAttendanceToday);
            this.grpAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAttendance.Location = new System.Drawing.Point(476, 85);
            this.grpAttendance.Name = "grpAttendance";
            this.grpAttendance.Size = new System.Drawing.Size(209, 120);
            this.grpAttendance.TabIndex = 3;
            this.grpAttendance.TabStop = false;
            this.grpAttendance.Text = "Attendance Today";
            // 
            // lblAttendanceToday
            // 
            this.lblAttendanceToday.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceToday.Location = new System.Drawing.Point(10, 35);
            this.lblAttendanceToday.Name = "lblAttendanceToday";
            this.lblAttendanceToday.Size = new System.Drawing.Size(190, 40);
            this.lblAttendanceToday.TabIndex = 0;
            this.lblAttendanceToday.Text = "0";
            this.lblAttendanceToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTrainers
            // 
            this.grpTrainers.Controls.Add(this.lblTotalTrainers);
            this.grpTrainers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrainers.Location = new System.Drawing.Point(250, 85);
            this.grpTrainers.Name = "grpTrainers";
            this.grpTrainers.Size = new System.Drawing.Size(210, 120);
            this.grpTrainers.TabIndex = 2;
            this.grpTrainers.TabStop = false;
            this.grpTrainers.Text = "Trainers";
            // 
            // lblTotalTrainers
            // 
            this.lblTotalTrainers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTrainers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTrainers.Location = new System.Drawing.Point(10, 35);
            this.lblTotalTrainers.Name = "lblTotalTrainers";
            this.lblTotalTrainers.Size = new System.Drawing.Size(190, 40);
            this.lblTotalTrainers.TabIndex = 0;
            this.lblTotalTrainers.Text = "0";
            this.lblTotalTrainers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.lblTotalMembers);
            this.grpMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembers.Location = new System.Drawing.Point(25, 85);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(210, 120);
            this.grpMembers.TabIndex = 1;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Members";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMembers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembers.Location = new System.Drawing.Point(10, 35);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(190, 40);
            this.lblTotalMembers.TabIndex = 0;
            this.lblTotalMembers.Text = "0";
            this.lblTotalMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(25, 20);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(400, 45);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grpRecentMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentMembers)).EndInit();
            this.lblPaymentTitle.ResumeLayout(false);
            this.grpAttendance.ResumeLayout(false);
            this.grpTrainers.ResumeLayout(false);
            this.grpMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblGymName;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnTrainers;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnWorkout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.GroupBox grpTrainers;
        private System.Windows.Forms.Label lblTotalTrainers;
        private System.Windows.Forms.GroupBox lblPaymentTitle;
        private System.Windows.Forms.GroupBox grpAttendance;
        private System.Windows.Forms.Label lblAttendanceToday;
        private System.Windows.Forms.Label IblTotalPayment;
        private System.Windows.Forms.GroupBox grpRecentMembers;
        private System.Windows.Forms.DataGridView dgvRecentMembers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}