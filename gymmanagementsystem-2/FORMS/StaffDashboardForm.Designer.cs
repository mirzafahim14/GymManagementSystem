namespace gymmanagementsystem_2.FORMS
{
    partial class StaffDashboardForm
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
            this.pnlStaffMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnWorkout = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.lblStaffMenuTitle = new System.Windows.Forms.Label();
            this.lblGymName = new System.Windows.Forms.Label();
            this.pnlStaffWelcome = new System.Windows.Forms.Panel();
            this.pnlSystemStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.pnlQuickAccess = new System.Windows.Forms.Panel();
            this.btnQuickTrainer = new System.Windows.Forms.Button();
            this.btnQuickReport = new System.Windows.Forms.Button();
            this.btnQuickHealth = new System.Windows.Forms.Button();
            this.btnQuickWorkout = new System.Windows.Forms.Button();
            this.btnQuickInvoice = new System.Windows.Forms.Button();
            this.btnQuickPayment = new System.Windows.Forms.Button();
            this.btnQuickAttendance = new System.Windows.Forms.Button();
            this.btnQuickMember = new System.Windows.Forms.Button();
            this.lblQuickAccess = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlStaffMenu.SuspendLayout();
            this.pnlStaffWelcome.SuspendLayout();
            this.pnlSystemStatus.SuspendLayout();
            this.pnlQuickAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.pnlStaffMenu);
            this.pnlSidebar.Controls.Add(this.lblGymName);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(341, 653);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlStaffMenu
            // 
            this.pnlStaffMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlStaffMenu.Controls.Add(this.btnLogout);
            this.pnlStaffMenu.Controls.Add(this.btnReport);
            this.pnlStaffMenu.Controls.Add(this.btnHealth);
            this.pnlStaffMenu.Controls.Add(this.btnWorkout);
            this.pnlStaffMenu.Controls.Add(this.btnTrainer);
            this.pnlStaffMenu.Controls.Add(this.btnInvoice);
            this.pnlStaffMenu.Controls.Add(this.btnPayment);
            this.pnlStaffMenu.Controls.Add(this.btnAttendance);
            this.pnlStaffMenu.Controls.Add(this.btnMember);
            this.pnlStaffMenu.Controls.Add(this.lblStaffMenuTitle);
            this.pnlStaffMenu.Location = new System.Drawing.Point(12, 68);
            this.pnlStaffMenu.Name = "pnlStaffMenu";
            this.pnlStaffMenu.Size = new System.Drawing.Size(300, 561);
            this.pnlStaffMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(51, 518);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(20, 455);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(260, 45);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "BASIC REPORTS";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHealth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealth.Location = new System.Drawing.Point(20, 400);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(260, 45);
            this.btnHealth.TabIndex = 8;
            this.btnHealth.Text = "HEALTH";
            this.btnHealth.UseVisualStyleBackColor = true;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnWorkout
            // 
            this.btnWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkout.Location = new System.Drawing.Point(20, 345);
            this.btnWorkout.Name = "btnWorkout";
            this.btnWorkout.Size = new System.Drawing.Size(260, 45);
            this.btnWorkout.TabIndex = 7;
            this.btnWorkout.Text = "WORKOUT";
            this.btnWorkout.UseVisualStyleBackColor = true;
            this.btnWorkout.Click += new System.EventHandler(this.btnWorkout_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainer.Location = new System.Drawing.Point(20, 290);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(260, 45);
            this.btnTrainer.TabIndex = 6;
            this.btnTrainer.Text = "TRAINER";
            this.btnTrainer.UseVisualStyleBackColor = true;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(20, 235);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(260, 45);
            this.btnInvoice.TabIndex = 5;
            this.btnInvoice.Text = "INVOICE";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(20, 180);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(260, 45);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(20, 125);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(260, 45);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "ATTENDANCE";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnMember
            // 
            this.btnMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(20, 70);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(260, 45);
            this.btnMember.TabIndex = 2;
            this.btnMember.Text = "MEMBER MANAGEMENT";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // lblStaffMenuTitle
            // 
            this.lblStaffMenuTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMenuTitle.Location = new System.Drawing.Point(15, 15);
            this.lblStaffMenuTitle.Name = "lblStaffMenuTitle";
            this.lblStaffMenuTitle.Size = new System.Drawing.Size(270, 40);
            this.lblStaffMenuTitle.TabIndex = 1;
            this.lblStaffMenuTitle.Text = "STAFF MENU";
            this.lblStaffMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGymName
            // 
            this.lblGymName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGymName.Location = new System.Drawing.Point(3, 19);
            this.lblGymName.Name = "lblGymName";
            this.lblGymName.Size = new System.Drawing.Size(321, 35);
            this.lblGymName.TabIndex = 1;
            this.lblGymName.Text = "GYM MANAGEMENT";
            this.lblGymName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStaffWelcome
            // 
            this.pnlStaffWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStaffWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffWelcome.Controls.Add(this.pnlSystemStatus);
            this.pnlStaffWelcome.Controls.Add(this.lblSystemStatus);
            this.pnlStaffWelcome.Controls.Add(this.pnlQuickAccess);
            this.pnlStaffWelcome.Controls.Add(this.lblQuickAccess);
            this.pnlStaffWelcome.Controls.Add(this.lblWelcome);
            this.pnlStaffWelcome.Controls.Add(this.lblCurrentDate);
            this.pnlStaffWelcome.Controls.Add(this.lblStaffRole);
            this.pnlStaffWelcome.Controls.Add(this.lblStaffName);
            this.pnlStaffWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStaffWelcome.Location = new System.Drawing.Point(347, 40);
            this.pnlStaffWelcome.Name = "pnlStaffWelcome";
            this.pnlStaffWelcome.Size = new System.Drawing.Size(830, 583);
            this.pnlStaffWelcome.TabIndex = 11;
            // 
            // pnlSystemStatus
            // 
            this.pnlSystemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSystemStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSystemStatus.Controls.Add(this.lblStatus);
            this.pnlSystemStatus.Location = new System.Drawing.Point(50, 490);
            this.pnlSystemStatus.Name = "pnlSystemStatus";
            this.pnlSystemStatus.Size = new System.Drawing.Size(715, 35);
            this.pnlSystemStatus.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(730, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "System Status: Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemStatus.Location = new System.Drawing.Point(50, 450);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(715, 30);
            this.lblSystemStatus.TabIndex = 26;
            this.lblSystemStatus.Text = "SYSTEM STATUS";
            this.lblSystemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlQuickAccess
            // 
            this.pnlQuickAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuickAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickAccess.Controls.Add(this.btnQuickTrainer);
            this.pnlQuickAccess.Controls.Add(this.btnQuickReport);
            this.pnlQuickAccess.Controls.Add(this.btnQuickHealth);
            this.pnlQuickAccess.Controls.Add(this.btnQuickWorkout);
            this.pnlQuickAccess.Controls.Add(this.btnQuickInvoice);
            this.pnlQuickAccess.Controls.Add(this.btnQuickPayment);
            this.pnlQuickAccess.Controls.Add(this.btnQuickAttendance);
            this.pnlQuickAccess.Controls.Add(this.btnQuickMember);
            this.pnlQuickAccess.Location = new System.Drawing.Point(55, 234);
            this.pnlQuickAccess.Name = "pnlQuickAccess";
            this.pnlQuickAccess.Size = new System.Drawing.Size(730, 187);
            this.pnlQuickAccess.TabIndex = 17;
            // 
            // btnQuickTrainer
            // 
            this.btnQuickTrainer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickTrainer.Location = new System.Drawing.Point(500, 80);
            this.btnQuickTrainer.Name = "btnQuickTrainer";
            this.btnQuickTrainer.Size = new System.Drawing.Size(220, 45);
            this.btnQuickTrainer.TabIndex = 23;
            this.btnQuickTrainer.Text = "TRAINER";
            this.btnQuickTrainer.UseVisualStyleBackColor = true;
            this.btnQuickTrainer.Click += new System.EventHandler(this.btnQuickTrainer_Click_1);
            // 
            // btnQuickReport
            // 
            this.btnQuickReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickReport.Location = new System.Drawing.Point(260, 80);
            this.btnQuickReport.Name = "btnQuickReport";
            this.btnQuickReport.Size = new System.Drawing.Size(220, 45);
            this.btnQuickReport.TabIndex = 22;
            this.btnQuickReport.Text = "BASIC REPORTS";
            this.btnQuickReport.UseVisualStyleBackColor = true;
            this.btnQuickReport.Click += new System.EventHandler(this.btnQuickReport_Click_1);
            // 
            // btnQuickHealth
            // 
            this.btnQuickHealth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickHealth.Location = new System.Drawing.Point(260, 131);
            this.btnQuickHealth.Name = "btnQuickHealth";
            this.btnQuickHealth.Size = new System.Drawing.Size(220, 45);
            this.btnQuickHealth.TabIndex = 25;
            this.btnQuickHealth.Text = "HEALTH";
            this.btnQuickHealth.UseVisualStyleBackColor = true;
            this.btnQuickHealth.Click += new System.EventHandler(this.btnQuickHealth_Click_1);
            // 
            // btnQuickWorkout
            // 
            this.btnQuickWorkout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickWorkout.Location = new System.Drawing.Point(20, 131);
            this.btnQuickWorkout.Name = "btnQuickWorkout";
            this.btnQuickWorkout.Size = new System.Drawing.Size(220, 45);
            this.btnQuickWorkout.TabIndex = 24;
            this.btnQuickWorkout.Text = "WORKOUT";
            this.btnQuickWorkout.UseVisualStyleBackColor = true;
            this.btnQuickWorkout.Click += new System.EventHandler(this.btnQuickWorkout_Click_1);
            // 
            // btnQuickInvoice
            // 
            this.btnQuickInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickInvoice.Location = new System.Drawing.Point(20, 80);
            this.btnQuickInvoice.Name = "btnQuickInvoice";
            this.btnQuickInvoice.Size = new System.Drawing.Size(220, 45);
            this.btnQuickInvoice.TabIndex = 21;
            this.btnQuickInvoice.Text = "INVOICE";
            this.btnQuickInvoice.UseVisualStyleBackColor = true;
            this.btnQuickInvoice.Click += new System.EventHandler(this.btnQuickInvoice_Click_1);
            // 
            // btnQuickPayment
            // 
            this.btnQuickPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickPayment.Location = new System.Drawing.Point(500, 20);
            this.btnQuickPayment.Name = "btnQuickPayment";
            this.btnQuickPayment.Size = new System.Drawing.Size(220, 45);
            this.btnQuickPayment.TabIndex = 20;
            this.btnQuickPayment.Text = "PAYMENT";
            this.btnQuickPayment.UseVisualStyleBackColor = true;
            this.btnQuickPayment.Click += new System.EventHandler(this.btnQuickPayment_Click_1);
            // 
            // btnQuickAttendance
            // 
            this.btnQuickAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAttendance.Location = new System.Drawing.Point(260, 20);
            this.btnQuickAttendance.Name = "btnQuickAttendance";
            this.btnQuickAttendance.Size = new System.Drawing.Size(220, 45);
            this.btnQuickAttendance.TabIndex = 19;
            this.btnQuickAttendance.Text = "ATTENDANCE";
            this.btnQuickAttendance.UseVisualStyleBackColor = true;
            this.btnQuickAttendance.Click += new System.EventHandler(this.btnQuickAttendance_Click_1);
            // 
            // btnQuickMember
            // 
            this.btnQuickMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickMember.Location = new System.Drawing.Point(20, 20);
            this.btnQuickMember.Name = "btnQuickMember";
            this.btnQuickMember.Size = new System.Drawing.Size(220, 45);
            this.btnQuickMember.TabIndex = 18;
            this.btnQuickMember.Text = "MEMBERS";
            this.btnQuickMember.UseVisualStyleBackColor = true;
            this.btnQuickMember.Click += new System.EventHandler(this.btnQuickMember_Click_1);
            // 
            // lblQuickAccess
            // 
            this.lblQuickAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuickAccess.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickAccess.Location = new System.Drawing.Point(50, 188);
            this.lblQuickAccess.Name = "lblQuickAccess";
            this.lblQuickAccess.Size = new System.Drawing.Size(730, 56);
            this.lblQuickAccess.TabIndex = 16;
            this.lblQuickAccess.Text = "QUICK ACCESS";
            this.lblQuickAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(30, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(770, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO STAFF DASHBOARD";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(50, 153);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(750, 35);
            this.lblCurrentDate.TabIndex = 15;
            this.lblCurrentDate.Text = "Date: —";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffRole.Location = new System.Drawing.Point(50, 114);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(730, 28);
            this.lblStaffRole.TabIndex = 14;
            this.lblStaffRole.Text = "Role: Staff";
            this.lblStaffRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(50, 79);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(730, 35);
            this.lblStaffName.TabIndex = 13;
            this.lblStaffName.Text = "Staff Name: —";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 653);
            this.Controls.Add(this.pnlStaffWelcome);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StaffDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Staff Dashboard";
            this.Load += new System.EventHandler(this.StaffDashboardForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlStaffMenu.ResumeLayout(false);
            this.pnlStaffWelcome.ResumeLayout(false);
            this.pnlSystemStatus.ResumeLayout(false);
            this.pnlQuickAccess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblGymName;
        private System.Windows.Forms.Panel pnlStaffMenu;
        private System.Windows.Forms.Label lblStaffMenuTitle;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnWorkout;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStaffWelcome;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlQuickAccess;
        private System.Windows.Forms.Label lblQuickAccess;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.Button btnQuickHealth;
        private System.Windows.Forms.Button btnQuickWorkout;
        private System.Windows.Forms.Button btnQuickTrainer;
        private System.Windows.Forms.Button btnQuickReport;
        private System.Windows.Forms.Button btnQuickInvoice;
        private System.Windows.Forms.Button btnQuickPayment;
        private System.Windows.Forms.Button btnQuickAttendance;
        private System.Windows.Forms.Button btnQuickMember;
        private System.Windows.Forms.Panel pnlSystemStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSystemStatus;
    }
}