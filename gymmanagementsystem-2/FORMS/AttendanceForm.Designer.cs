namespace gymmanagementsystem_2.FORMS
{
    partial class AttendanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAttendanceHeading = new System.Windows.Forms.Label();
            this.pnlAttendanceInput = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colAttendanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAttendanceSearch2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.object_b065917a_dd16_47e0_b82c_85f788313709 = new System.Windows.Forms.Panel();
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24 = new System.Windows.Forms.DataGridView();
            this.object_b004f262_92f8_40f3_9402_0887ecc14117 = new System.Windows.Forms.DataGridView();
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342 = new System.Windows.Forms.DataGridView();
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2 = new System.Windows.Forms.Panel();
            this.object_f814caba_7f64_4b25_986f_c80fb746a485 = new System.Windows.Forms.Panel();
            this.object_4b868609_af20_43a4_8648_eb98856caf33 = new System.Windows.Forms.Panel();
            this.pnlAttendanceSearch = new System.Windows.Forms.Panel();
            this.pnlAttendanceData = new System.Windows.Forms.Panel();
            this.pnlAttendanceInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlAttendanceSearch2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.object_80fa1195_204f_4725_aee5_eb93ae126c24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_b004f262_92f8_40f3_9402_0887ecc14117)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342)).BeginInit();
            this.pnlAttendanceSearch.SuspendLayout();
            this.pnlAttendanceData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAttendanceHeading
            // 
            this.lblAttendanceHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttendanceHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceHeading.Location = new System.Drawing.Point(185, 37);
            this.lblAttendanceHeading.Name = "lblAttendanceHeading";
            this.lblAttendanceHeading.Size = new System.Drawing.Size(1009, 40);
            this.lblAttendanceHeading.TabIndex = 0;
            this.lblAttendanceHeading.Text = "ATTENDANCE MANAGEMENT";
            this.lblAttendanceHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAttendanceInput
            // 
            this.pnlAttendanceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAttendanceInput.Controls.Add(this.btnSave);
            this.pnlAttendanceInput.Controls.Add(this.cmbAttendanceStatus);
            this.pnlAttendanceInput.Controls.Add(this.lblAttendanceStatus);
            this.pnlAttendanceInput.Controls.Add(this.dtpCheckOutTime);
            this.pnlAttendanceInput.Controls.Add(this.lblCheckOutTime);
            this.pnlAttendanceInput.Controls.Add(this.dtpCheckInTime);
            this.pnlAttendanceInput.Controls.Add(this.lblCheckInTime);
            this.pnlAttendanceInput.Controls.Add(this.dtpAttendanceDate);
            this.pnlAttendanceInput.Controls.Add(this.lblAttendanceDate);
            this.pnlAttendanceInput.Controls.Add(this.cmbMemberId);
            this.pnlAttendanceInput.Controls.Add(this.lblMemberId);
            this.pnlAttendanceInput.Location = new System.Drawing.Point(42, 120);
            this.pnlAttendanceInput.Name = "pnlAttendanceInput";
            this.pnlAttendanceInput.Size = new System.Drawing.Size(430, 469);
            this.pnlAttendanceInput.TabIndex = 1;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(-1, 1);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(778, 330);
            this.dgvAttendance.TabIndex = 14;
            // 
            // colAttendanceId
            // 
            this.colAttendanceId.HeaderText = "Attendance ID";
            this.colAttendanceId.MinimumWidth = 6;
            this.colAttendanceId.Name = "colAttendanceId";
            this.colAttendanceId.ReadOnly = true;
            this.colAttendanceId.Width = 125;
            // 
            // colMemberId
            // 
            this.colMemberId.HeaderText = "Member ID";
            this.colMemberId.MinimumWidth = 6;
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.ReadOnly = true;
            this.colMemberId.Width = 125;
            // 
            // colAttendanceDate
            // 
            this.colAttendanceDate.HeaderText = "Attendance Date";
            this.colAttendanceDate.MinimumWidth = 6;
            this.colAttendanceDate.Name = "colAttendanceDate";
            this.colAttendanceDate.ReadOnly = true;
            this.colAttendanceDate.Width = 125;
            // 
            // colCheckInTime
            // 
            this.colCheckInTime.HeaderText = "Check-In Time";
            this.colCheckInTime.MinimumWidth = 6;
            this.colCheckInTime.Name = "colCheckInTime";
            this.colCheckInTime.ReadOnly = true;
            this.colCheckInTime.Width = 125;
            // 
            // colCheckOutTime
            // 
            this.colCheckOutTime.HeaderText = "Check-Out Time";
            this.colCheckOutTime.MinimumWidth = 6;
            this.colCheckOutTime.Name = "colCheckOutTime";
            this.colCheckOutTime.ReadOnly = true;
            this.colCheckOutTime.Width = 125;
            // 
            // colAttendanceStatus
            // 
            this.colAttendanceStatus.HeaderText = "Status";
            this.colAttendanceStatus.MinimumWidth = 6;
            this.colAttendanceStatus.Name = "colAttendanceStatus";
            this.colAttendanceStatus.ReadOnly = true;
            this.colAttendanceStatus.Width = 125;
            // 
            // pnlAttendanceSearch2
            // 
            this.pnlAttendanceSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAttendanceSearch2.Controls.Add(this.txtSearch);
            this.pnlAttendanceSearch2.Controls.Add(this.lblSearch);
            this.pnlAttendanceSearch2.Location = new System.Drawing.Point(36, 19);
            this.pnlAttendanceSearch2.Name = "pnlAttendanceSearch2";
            this.pnlAttendanceSearch2.Size = new System.Drawing.Size(729, 59);
            this.pnlAttendanceSearch2.TabIndex = 13;
            this.pnlAttendanceSearch2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAttendanceSearch_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(186, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(20, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(160, 30);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search Attendance";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(150, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAttendanceStatus
            // 
            this.cmbAttendanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttendanceStatus.FormattingEnabled = true;
            this.cmbAttendanceStatus.Items.AddRange(new object[] {
            "Select Status",
            "Present",
            "Absent",
            "Late"});
            this.cmbAttendanceStatus.Location = new System.Drawing.Point(150, 220);
            this.cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            this.cmbAttendanceStatus.Size = new System.Drawing.Size(260, 31);
            this.cmbAttendanceStatus.TabIndex = 11;
            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.Location = new System.Drawing.Point(3, 211);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(120, 30);
            this.lblAttendanceStatus.TabIndex = 10;
            this.lblAttendanceStatus.Text = "Status";
            this.lblAttendanceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckOutTime.Location = new System.Drawing.Point(150, 170);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.ShowUpDown = true;
            this.dtpCheckOutTime.Size = new System.Drawing.Size(260, 30);
            this.dtpCheckOutTime.TabIndex = 9;
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.Location = new System.Drawing.Point(3, 168);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(120, 30);
            this.lblCheckOutTime.TabIndex = 8;
            this.lblCheckOutTime.Text = "Check-Out Time";
            this.lblCheckOutTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckInTime.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtpCheckInTime.Location = new System.Drawing.Point(150, 120);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.ShowUpDown = true;
            this.dtpCheckInTime.Size = new System.Drawing.Size(260, 30);
            this.dtpCheckInTime.TabIndex = 7;
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.Location = new System.Drawing.Point(3, 117);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(120, 30);
            this.lblCheckInTime.TabIndex = 6;
            this.lblCheckInTime.Tag = "Check-In Time";
            this.lblCheckInTime.Text = "Check-In Time";
            this.lblCheckInTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheckInTime.Click += new System.EventHandler(this.lblCheckInTime_Click);
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(150, 70);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(260, 30);
            this.dtpAttendanceDate.TabIndex = 5;
            // 
            // lblAttendanceDate
            // 
            this.lblAttendanceDate.Location = new System.Drawing.Point(3, 72);
            this.lblAttendanceDate.Name = "lblAttendanceDate";
            this.lblAttendanceDate.Size = new System.Drawing.Size(152, 30);
            this.lblAttendanceDate.TabIndex = 4;
            this.lblAttendanceDate.Text = "Attendance Date";
            this.lblAttendanceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMemberId
            // 
            this.cmbMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberId.FormattingEnabled = true;
            this.cmbMemberId.Location = new System.Drawing.Point(150, 20);
            this.cmbMemberId.Name = "cmbMemberId";
            this.cmbMemberId.Size = new System.Drawing.Size(260, 31);
            this.cmbMemberId.TabIndex = 3;
            // 
            // lblMemberId
            // 
            this.lblMemberId.Location = new System.Drawing.Point(3, 20);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(120, 30);
            this.lblMemberId.TabIndex = 2;
            this.lblMemberId.Text = "Member ID";
            this.lblMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(428, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 584);
            this.panel1.TabIndex = 15;
            // 
            // object_b065917a_dd16_47e0_b82c_85f788313709
            // 
            this.object_b065917a_dd16_47e0_b82c_85f788313709.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_b065917a_dd16_47e0_b82c_85f788313709.Location = new System.Drawing.Point(-2, 63);
            this.object_b065917a_dd16_47e0_b82c_85f788313709.Name = "object_b065917a_dd16_47e0_b82c_85f788313709";
            this.object_b065917a_dd16_47e0_b82c_85f788313709.Size = new System.Drawing.Size(1811, 530);
            this.object_b065917a_dd16_47e0_b82c_85f788313709.TabIndex = 1;
            this.object_b065917a_dd16_47e0_b82c_85f788313709.Visible = false;
            // 
            // object_80fa1195_204f_4725_aee5_eb93ae126c24
            // 
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.AllowUserToAddRows = false;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.AllowUserToDeleteRows = false;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.DefaultCellStyle = dataGridViewCellStyle38;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.Location = new System.Drawing.Point(449, 117);
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.MultiSelect = false;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.Name = "object_80fa1195_204f_4725_aee5_eb93ae126c24";
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.RowHeadersWidth = 51;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.RowTemplate.Height = 24;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.Size = new System.Drawing.Size(803, 401);
            this.object_80fa1195_204f_4725_aee5_eb93ae126c24.TabIndex = 14;
            // 
            // object_b004f262_92f8_40f3_9402_0887ecc14117
            // 
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.AllowUserToAddRows = false;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.AllowUserToDeleteRows = false;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.DefaultCellStyle = dataGridViewCellStyle41;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.Location = new System.Drawing.Point(449, 117);
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.MultiSelect = false;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.Name = "object_b004f262_92f8_40f3_9402_0887ecc14117";
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.RowHeadersWidth = 51;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.RowTemplate.Height = 24;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.Size = new System.Drawing.Size(803, 401);
            this.object_b004f262_92f8_40f3_9402_0887ecc14117.TabIndex = 14;
            // 
            // object_45c6a872_ad33_4d2d_9d2f_21b866e90342
            // 
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.AllowUserToAddRows = false;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.AllowUserToDeleteRows = false;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.DefaultCellStyle = dataGridViewCellStyle44;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.Location = new System.Drawing.Point(449, 117);
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.MultiSelect = false;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.Name = "object_45c6a872_ad33_4d2d_9d2f_21b866e90342";
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.ReadOnly = true;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.RowHeadersWidth = 51;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.RowTemplate.Height = 24;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.Size = new System.Drawing.Size(803, 401);
            this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342.TabIndex = 14;
            // 
            // object_d4a2a812_e154_47e5_abb9_2babc2706ab2
            // 
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2.Location = new System.Drawing.Point(-2, 63);
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2.Name = "object_d4a2a812_e154_47e5_abb9_2babc2706ab2";
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2.Size = new System.Drawing.Size(1811, 530);
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2.TabIndex = 1;
            this.object_d4a2a812_e154_47e5_abb9_2babc2706ab2.Visible = false;
            // 
            // object_f814caba_7f64_4b25_986f_c80fb746a485
            // 
            this.object_f814caba_7f64_4b25_986f_c80fb746a485.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_f814caba_7f64_4b25_986f_c80fb746a485.Location = new System.Drawing.Point(-2, 63);
            this.object_f814caba_7f64_4b25_986f_c80fb746a485.Name = "object_f814caba_7f64_4b25_986f_c80fb746a485";
            this.object_f814caba_7f64_4b25_986f_c80fb746a485.Size = new System.Drawing.Size(1811, 530);
            this.object_f814caba_7f64_4b25_986f_c80fb746a485.TabIndex = 1;
            this.object_f814caba_7f64_4b25_986f_c80fb746a485.Visible = false;
            // 
            // object_4b868609_af20_43a4_8648_eb98856caf33
            // 
            this.object_4b868609_af20_43a4_8648_eb98856caf33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_4b868609_af20_43a4_8648_eb98856caf33.Location = new System.Drawing.Point(-2, 63);
            this.object_4b868609_af20_43a4_8648_eb98856caf33.Name = "object_4b868609_af20_43a4_8648_eb98856caf33";
            this.object_4b868609_af20_43a4_8648_eb98856caf33.Size = new System.Drawing.Size(1811, 530);
            this.object_4b868609_af20_43a4_8648_eb98856caf33.TabIndex = 1;
            this.object_4b868609_af20_43a4_8648_eb98856caf33.Visible = false;
            // 
            // pnlAttendanceSearch
            // 
            this.pnlAttendanceSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAttendanceSearch.Controls.Add(this.pnlAttendanceSearch2);
            this.pnlAttendanceSearch.Location = new System.Drawing.Point(495, 120);
            this.pnlAttendanceSearch.Name = "pnlAttendanceSearch";
            this.pnlAttendanceSearch.Size = new System.Drawing.Size(790, 100);
            this.pnlAttendanceSearch.TabIndex = 15;
            // 
            // pnlAttendanceData
            // 
            this.pnlAttendanceData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAttendanceData.Controls.Add(this.dgvAttendance);
            this.pnlAttendanceData.Location = new System.Drawing.Point(500, 235);
            this.pnlAttendanceData.Name = "pnlAttendanceData";
            this.pnlAttendanceData.Size = new System.Drawing.Size(782, 351);
            this.pnlAttendanceData.TabIndex = 16;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 603);
            this.Controls.Add(this.pnlAttendanceData);
            this.Controls.Add(this.pnlAttendanceSearch);
            this.Controls.Add(this.pnlAttendanceInput);
            this.Controls.Add(this.lblAttendanceHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 700);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Attendance";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.pnlAttendanceInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlAttendanceSearch2.ResumeLayout(false);
            this.pnlAttendanceSearch2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.object_80fa1195_204f_4725_aee5_eb93ae126c24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_b004f262_92f8_40f3_9402_0887ecc14117)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_45c6a872_ad33_4d2d_9d2f_21b866e90342)).EndInit();
            this.pnlAttendanceSearch.ResumeLayout(false);
            this.pnlAttendanceData.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        private System.Windows.Forms.Panel pnlAttendanceSearch2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel object_b065917a_dd16_47e0_b82c_85f788313709;
        private System.Windows.Forms.DataGridView object_80fa1195_204f_4725_aee5_eb93ae126c24;
        private System.Windows.Forms.DataGridView object_b004f262_92f8_40f3_9402_0887ecc14117;
        private System.Windows.Forms.DataGridView object_45c6a872_ad33_4d2d_9d2f_21b866e90342;
        private System.Windows.Forms.Panel object_d4a2a812_e154_47e5_abb9_2babc2706ab2;
        private System.Windows.Forms.Panel object_f814caba_7f64_4b25_986f_c80fb746a485;
        private System.Windows.Forms.Panel object_4b868609_af20_43a4_8648_eb98856caf33;
        private System.Windows.Forms.Panel pnlAttendanceSearch;
        private System.Windows.Forms.Panel pnlAttendanceData;
    }
}