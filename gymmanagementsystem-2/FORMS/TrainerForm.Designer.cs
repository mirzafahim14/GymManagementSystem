namespace gymmanagementsystem_2.FORMS
{
    partial class TrainerForm
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
            this.lblTrainerManagement = new System.Windows.Forms.Label();
            this.pnlTrainerInput = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.txtTrainerId = new System.Windows.Forms.TextBox();
            this.lblTrainerId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTrainerSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            this.colTrainerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTrainerInput.SuspendLayout();
            this.pnlTrainerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrainerManagement
            // 
            this.lblTrainerManagement.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerManagement.Location = new System.Drawing.Point(12, 9);
            this.lblTrainerManagement.Name = "lblTrainerManagement";
            this.lblTrainerManagement.Size = new System.Drawing.Size(500, 50);
            this.lblTrainerManagement.TabIndex = 0;
            this.lblTrainerManagement.Text = "TRAINER MANAGEMENT";
            this.lblTrainerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrainerManagement.Click += new System.EventHandler(this.lblTrainerManagement_Click);
            // 
            // pnlTrainerInput
            // 
            this.pnlTrainerInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTrainerInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrainerInput.Controls.Add(this.btnClear);
            this.pnlTrainerInput.Controls.Add(this.btnDelete);
            this.pnlTrainerInput.Controls.Add(this.btnUpdate);
            this.pnlTrainerInput.Controls.Add(this.btnSave);
            this.pnlTrainerInput.Controls.Add(this.txtSalary);
            this.pnlTrainerInput.Controls.Add(this.lblSalary);
            this.pnlTrainerInput.Controls.Add(this.dateTimePicker1);
            this.pnlTrainerInput.Controls.Add(this.lblJoinDate);
            this.pnlTrainerInput.Controls.Add(this.cmbSpecialization);
            this.pnlTrainerInput.Controls.Add(this.lblSpecialization);
            this.pnlTrainerInput.Controls.Add(this.dtpDateOfBirth);
            this.pnlTrainerInput.Controls.Add(this.lblDateOfBirth);
            this.pnlTrainerInput.Controls.Add(this.cmbGender);
            this.pnlTrainerInput.Controls.Add(this.lblGender);
            this.pnlTrainerInput.Controls.Add(this.txtEmail);
            this.pnlTrainerInput.Controls.Add(this.lblEmail);
            this.pnlTrainerInput.Controls.Add(this.txtPhone);
            this.pnlTrainerInput.Controls.Add(this.lblPhone);
            this.pnlTrainerInput.Controls.Add(this.txtTrainerName);
            this.pnlTrainerInput.Controls.Add(this.lblTrainerName);
            this.pnlTrainerInput.Controls.Add(this.txtTrainerId);
            this.pnlTrainerInput.Controls.Add(this.lblTrainerId);
            this.pnlTrainerInput.Location = new System.Drawing.Point(21, 62);
            this.pnlTrainerInput.Name = "pnlTrainerInput";
            this.pnlTrainerInput.Size = new System.Drawing.Size(504, 722);
            this.pnlTrainerInput.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(383, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(-1, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(150, 420);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(261, 30);
            this.txtSalary.TabIndex = 16;
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(20, 420);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(120, 30);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.Location = new System.Drawing.Point(20, 369);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(120, 30);
            this.lblJoinDate.TabIndex = 13;
            this.lblJoinDate.Text = "Join Date";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecialization.Items.AddRange(new object[] {
            "Select Specialization",
            "Fitness Trainer",
            "Personal Trainer",
            "Yoga Trainer",
            "Cardio Trainer",
            "Strength Trainer"});
            this.cmbSpecialization.Location = new System.Drawing.Point(150, 320);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(260, 31);
            this.cmbSpecialization.TabIndex = 12;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.Location = new System.Drawing.Point(20, 320);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(120, 30);
            this.lblSpecialization.TabIndex = 11;
            this.lblSpecialization.Text = "Specialization";
            this.lblSpecialization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(150, 270);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(260, 30);
            this.dtpDateOfBirth.TabIndex = 10;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(20, 270);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(120, 30);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Date of Birth";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(150, 220);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(260, 31);
            this.cmbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(20, 220);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(120, 30);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(150, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 30);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(150, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(20, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(127, 23);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerName.Location = new System.Drawing.Point(150, 70);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(260, 30);
            this.txtTrainerName.TabIndex = 2;
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerName.Location = new System.Drawing.Point(20, 69);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(120, 30);
            this.lblTrainerName.TabIndex = 1;
            this.lblTrainerName.Text = "Trainer Name";
            this.lblTrainerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTrainerId
            // 
            this.txtTrainerId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrainerId.Location = new System.Drawing.Point(150, 20);
            this.txtTrainerId.Name = "txtTrainerId";
            this.txtTrainerId.ReadOnly = true;
            this.txtTrainerId.Size = new System.Drawing.Size(261, 30);
            this.txtTrainerId.TabIndex = 0;
            // 
            // lblTrainerId
            // 
            this.lblTrainerId.AutoSize = true;
            this.lblTrainerId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerId.Location = new System.Drawing.Point(20, 20);
            this.lblTrainerId.Name = "lblTrainerId";
            this.lblTrainerId.Size = new System.Drawing.Size(84, 23);
            this.lblTrainerId.TabIndex = 0;
            this.lblTrainerId.Text = "Trainer ID";
            this.lblTrainerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pnlTrainerSearch
            // 
            this.pnlTrainerSearch.Controls.Add(this.txtSearch);
            this.pnlTrainerSearch.Controls.Add(this.lblSearch);
            this.pnlTrainerSearch.Controls.Add(this.label1);
            this.pnlTrainerSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTrainerSearch.Location = new System.Drawing.Point(555, 62);
            this.pnlTrainerSearch.Name = "pnlTrainerSearch";
            this.pnlTrainerSearch.Size = new System.Drawing.Size(1229, 60);
            this.pnlTrainerSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 22;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(20, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 30);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Search Trainer";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.AllowUserToAddRows = false;
            this.dgvTrainers.AllowUserToDeleteRows = false;
            this.dgvTrainers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainerId,
            this.colTrainerName,
            this.colPhone,
            this.colEmail,
            this.colGender,
            this.colSpecialization,
            this.colJoinDate,
            this.colSalary});
            this.dgvTrainers.Location = new System.Drawing.Point(555, 154);
            this.dgvTrainers.MultiSelect = false;
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.RowHeadersWidth = 51;
            this.dgvTrainers.RowTemplate.Height = 24;
            this.dgvTrainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainers.Size = new System.Drawing.Size(1059, 553);
            this.dgvTrainers.TabIndex = 4;
            this.dgvTrainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainers_CellClick);
            // 
            // colTrainerId
            // 
            this.colTrainerId.HeaderText = "Trainer ID";
            this.colTrainerId.MinimumWidth = 6;
            this.colTrainerId.Name = "colTrainerId";
            this.colTrainerId.ReadOnly = true;
            this.colTrainerId.Width = 125;
            // 
            // colTrainerName
            // 
            this.colTrainerName.HeaderText = "Trainer Name";
            this.colTrainerName.MinimumWidth = 6;
            this.colTrainerName.Name = "colTrainerName";
            this.colTrainerName.ReadOnly = true;
            this.colTrainerName.Width = 125;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone Number";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 125;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 125;
            // 
            // colSpecialization
            // 
            this.colSpecialization.HeaderText = "Specialization";
            this.colSpecialization.MinimumWidth = 6;
            this.colSpecialization.Name = "colSpecialization";
            this.colSpecialization.ReadOnly = true;
            this.colSpecialization.Width = 125;
            // 
            // colJoinDate
            // 
            this.colJoinDate.HeaderText = "Join Date";
            this.colJoinDate.MinimumWidth = 6;
            this.colJoinDate.Name = "colJoinDate";
            this.colJoinDate.ReadOnly = true;
            this.colJoinDate.Width = 125;
            // 
            // colSalary
            // 
            this.colSalary.HeaderText = "Salary";
            this.colSalary.MinimumWidth = 6;
            this.colSalary.Name = "colSalary";
            this.colSalary.ReadOnly = true;
            this.colSalary.Width = 125;
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 734);
            this.Controls.Add(this.dgvTrainers);
            this.Controls.Add(this.pnlTrainerSearch);
            this.Controls.Add(this.pnlTrainerInput);
            this.Controls.Add(this.lblTrainerManagement);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1368, 556);
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Trainers";
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            this.pnlTrainerInput.ResumeLayout(false);
            this.pnlTrainerInput.PerformLayout();
            this.pnlTrainerSearch.ResumeLayout(false);
            this.pnlTrainerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrainerManagement;
        private System.Windows.Forms.Panel pnlTrainerInput;
        private System.Windows.Forms.Label lblTrainerId;
        private System.Windows.Forms.TextBox txtTrainerId;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTrainerSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
    }
}