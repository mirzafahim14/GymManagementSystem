namespace gymmanagementsystem_2.FORMS
{
    partial class HealthForm
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
            this.lblMedicalCondition = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.cmbMemberId = new System.Windows.Forms.ComboBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeightFeet = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblEmergencyContact = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.pnlHealthInfo = new System.Windows.Forms.Panel();
            this.pnlHealthRecords = new System.Windows.Forms.Panel();
            this.dgvHealthRecords = new System.Windows.Forms.DataGridView();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.colMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBloodPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedicalCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmergencyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbMedicalConditions = new System.Windows.Forms.CheckedListBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbHeightFeet = new System.Windows.Forms.ComboBox();
            this.cmbHeightInch = new System.Windows.Forms.ComboBox();
            this.lblHeightInch = new System.Windows.Forms.Label();
            this.txtHeightCm = new System.Windows.Forms.TextBox();
            this.lblHeightCm = new System.Windows.Forms.Label();
            this.pnlHealthInfo.SuspendLayout();
            this.pnlHealthRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(282, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(491, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HEALTH MANAGEMENT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedicalCondition
            // 
            this.lblMedicalCondition.Location = new System.Drawing.Point(5, 406);
            this.lblMedicalCondition.Name = "lblMedicalCondition";
            this.lblMedicalCondition.Size = new System.Drawing.Size(160, 25);
            this.lblMedicalCondition.TabIndex = 11;
            this.lblMedicalCondition.Text = "Medical Condition";
            this.lblMedicalCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMedicalCondition.Click += new System.EventHandler(this.lblMedicalCondition_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(9, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(131, 534);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(237, 534);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(343, 534);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMemberId
            // 
            this.lblMemberId.Location = new System.Drawing.Point(5, 21);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(100, 25);
            this.lblMemberId.TabIndex = 1;
            this.lblMemberId.Text = "Member ID";
            this.lblMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMemberId
            // 
            this.cmbMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberId.FormattingEnabled = true;
            this.cmbMemberId.Location = new System.Drawing.Point(189, 15);
            this.cmbMemberId.Name = "cmbMemberId";
            this.cmbMemberId.Size = new System.Drawing.Size(220, 31);
            this.cmbMemberId.TabIndex = 2;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.Location = new System.Drawing.Point(5, 74);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(134, 25);
            this.lblBloodGroup.TabIndex = 3;
            this.lblBloodGroup.Text = "Blood Group";
            this.lblBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(189, 120);
            this.txtWeight.MaxLength = 6;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(220, 30);
            this.txtWeight.TabIndex = 6;
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(5, 122);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(134, 25);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight (kg) ";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeightFeet
            // 
            this.lblHeightFeet.Location = new System.Drawing.Point(5, 173);
            this.lblHeightFeet.Name = "lblHeightFeet";
            this.lblHeightFeet.Size = new System.Drawing.Size(111, 25);
            this.lblHeightFeet.TabIndex = 7;
            this.lblHeightFeet.Text = "Height (Feet)";
            this.lblHeightFeet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(200, 288);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(220, 30);
            this.txtBMI.TabIndex = 10;
            // 
            // lblBMI
            // 
            this.lblBMI.Location = new System.Drawing.Point(9, 293);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(100, 25);
            this.lblBMI.TabIndex = 9;
            this.lblBMI.Text = "BMI";
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBMI.Click += new System.EventHandler(this.lblBMI_Click);
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.Location = new System.Drawing.Point(5, 482);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(201, 25);
            this.lblEmergencyContact.TabIndex = 13;
            this.lblEmergencyContact.Text = "Emergency Contact";
            this.lblEmergencyContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(223, 477);
            this.txtEmergencyContact.MaxLength = 20;
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(220, 30);
            this.txtEmergencyContact.TabIndex = 14;
            // 
            // pnlHealthInfo
            // 
            this.pnlHealthInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHealthInfo.Controls.Add(this.lblHeightCm);
            this.pnlHealthInfo.Controls.Add(this.txtHeightCm);
            this.pnlHealthInfo.Controls.Add(this.lblHeightInch);
            this.pnlHealthInfo.Controls.Add(this.cmbHeightInch);
            this.pnlHealthInfo.Controls.Add(this.cmbHeightFeet);
            this.pnlHealthInfo.Controls.Add(this.cmbBloodGroup);
            this.pnlHealthInfo.Controls.Add(this.clbMedicalConditions);
            this.pnlHealthInfo.Controls.Add(this.lblMedicalCondition);
            this.pnlHealthInfo.Controls.Add(this.btnClear);
            this.pnlHealthInfo.Controls.Add(this.btnDelete);
            this.pnlHealthInfo.Controls.Add(this.txtEmergencyContact);
            this.pnlHealthInfo.Controls.Add(this.btnUpdate);
            this.pnlHealthInfo.Controls.Add(this.lblEmergencyContact);
            this.pnlHealthInfo.Controls.Add(this.btnSave);
            this.pnlHealthInfo.Controls.Add(this.lblBMI);
            this.pnlHealthInfo.Controls.Add(this.txtBMI);
            this.pnlHealthInfo.Controls.Add(this.lblHeightFeet);
            this.pnlHealthInfo.Controls.Add(this.lblWeight);
            this.pnlHealthInfo.Controls.Add(this.txtWeight);
            this.pnlHealthInfo.Controls.Add(this.lblBloodGroup);
            this.pnlHealthInfo.Controls.Add(this.cmbMemberId);
            this.pnlHealthInfo.Controls.Add(this.lblMemberId);
            this.pnlHealthInfo.Location = new System.Drawing.Point(40, 57);
            this.pnlHealthInfo.Name = "pnlHealthInfo";
            this.pnlHealthInfo.Size = new System.Drawing.Size(507, 590);
            this.pnlHealthInfo.TabIndex = 1;
            // 
            // pnlHealthRecords
            // 
            this.pnlHealthRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHealthRecords.Controls.Add(this.dgvHealthRecords);
            this.pnlHealthRecords.Controls.Add(this.lblRecordsTitle);
            this.pnlHealthRecords.Location = new System.Drawing.Point(564, 57);
            this.pnlHealthRecords.Name = "pnlHealthRecords";
            this.pnlHealthRecords.Size = new System.Drawing.Size(703, 620);
            this.pnlHealthRecords.TabIndex = 21;
            // 
            // dgvHealthRecords
            // 
            this.dgvHealthRecords.AllowUserToAddRows = false;
            this.dgvHealthRecords.AllowUserToDeleteRows = false;
            this.dgvHealthRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHealthRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHealthRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberId,
            this.colBloodPressure,
            this.colWeight,
            this.colHeight,
            this.colBMI,
            this.colMedicalCondition,
            this.colEmergencyContact});
            this.dgvHealthRecords.Location = new System.Drawing.Point(5, 74);
            this.dgvHealthRecords.MultiSelect = false;
            this.dgvHealthRecords.Name = "dgvHealthRecords";
            this.dgvHealthRecords.ReadOnly = true;
            this.dgvHealthRecords.RowHeadersVisible = false;
            this.dgvHealthRecords.RowHeadersWidth = 51;
            this.dgvHealthRecords.RowTemplate.Height = 24;
            this.dgvHealthRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthRecords.Size = new System.Drawing.Size(683, 500);
            this.dgvHealthRecords.TabIndex = 23;
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(643, 35);
            this.lblRecordsTitle.TabIndex = 22;
            this.lblRecordsTitle.Text = "HEALTH RECORDS";
            this.lblRecordsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colMemberId
            // 
            this.colMemberId.HeaderText = "Member ID";
            this.colMemberId.MinimumWidth = 6;
            this.colMemberId.Name = "colMemberId";
            this.colMemberId.ReadOnly = true;
            // 
            // colBloodPressure
            // 
            this.colBloodPressure.HeaderText = "Blood Pressure";
            this.colBloodPressure.MinimumWidth = 6;
            this.colBloodPressure.Name = "colBloodPressure";
            this.colBloodPressure.ReadOnly = true;
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "Weight (kg)";
            this.colWeight.MinimumWidth = 6;
            this.colWeight.Name = "colWeight";
            this.colWeight.ReadOnly = true;
            // 
            // colHeight
            // 
            this.colHeight.HeaderText = "Height (cm)";
            this.colHeight.MinimumWidth = 6;
            this.colHeight.Name = "colHeight";
            this.colHeight.ReadOnly = true;
            // 
            // colBMI
            // 
            this.colBMI.HeaderText = "BMI";
            this.colBMI.MinimumWidth = 6;
            this.colBMI.Name = "colBMI";
            this.colBMI.ReadOnly = true;
            // 
            // colMedicalCondition
            // 
            this.colMedicalCondition.HeaderText = "Medical Condition";
            this.colMedicalCondition.MinimumWidth = 6;
            this.colMedicalCondition.Name = "colMedicalCondition";
            this.colMedicalCondition.ReadOnly = true;
            // 
            // colEmergencyContact
            // 
            this.colEmergencyContact.HeaderText = "Emergency Contact";
            this.colEmergencyContact.MinimumWidth = 6;
            this.colEmergencyContact.Name = "colEmergencyContact";
            this.colEmergencyContact.ReadOnly = true;
            // 
            // clbMedicalConditions
            // 
            this.clbMedicalConditions.FormattingEnabled = true;
            this.clbMedicalConditions.Items.AddRange(new object[] {
            "None",
            "Diabetes",
            "High Blood Pressure",
            "Asthma",
            "Heart Disease",
            "Knee Problem",
            "Back Pain",
            "Joint Pain",
            "Obesity",
            "Other"});
            this.clbMedicalConditions.Location = new System.Drawing.Point(215, 339);
            this.clbMedicalConditions.Name = "clbMedicalConditions";
            this.clbMedicalConditions.Size = new System.Drawing.Size(228, 104);
            this.clbMedicalConditions.TabIndex = 21;
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "Select Blood Group",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(189, 68);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(220, 31);
            this.cmbBloodGroup.TabIndex = 22;
            // 
            // cmbHeightFeet
            // 
            this.cmbHeightFeet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeightFeet.FormattingEnabled = true;
            this.cmbHeightFeet.Items.AddRange(new object[] {
            "Select Feet",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbHeightFeet.Location = new System.Drawing.Point(189, 167);
            this.cmbHeightFeet.Name = "cmbHeightFeet";
            this.cmbHeightFeet.Size = new System.Drawing.Size(220, 31);
            this.cmbHeightFeet.TabIndex = 23;
            // 
            // cmbHeightInch
            // 
            this.cmbHeightInch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeightInch.FormattingEnabled = true;
            this.cmbHeightInch.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbHeightInch.Location = new System.Drawing.Point(189, 204);
            this.cmbHeightInch.Name = "cmbHeightInch";
            this.cmbHeightInch.Size = new System.Drawing.Size(220, 31);
            this.cmbHeightInch.TabIndex = 24;
            // 
            // lblHeightInch
            // 
            this.lblHeightInch.AutoSize = true;
            this.lblHeightInch.Location = new System.Drawing.Point(9, 212);
            this.lblHeightInch.Name = "lblHeightInch";
            this.lblHeightInch.Size = new System.Drawing.Size(125, 23);
            this.lblHeightInch.TabIndex = 25;
            this.lblHeightInch.Text = "Height (Inches)";
            // 
            // txtHeightCm
            // 
            this.txtHeightCm.Location = new System.Drawing.Point(189, 241);
            this.txtHeightCm.Name = "txtHeightCm";
            this.txtHeightCm.ReadOnly = true;
            this.txtHeightCm.Size = new System.Drawing.Size(220, 30);
            this.txtHeightCm.TabIndex = 26;
            // 
            // lblHeightCm
            // 
            this.lblHeightCm.AutoSize = true;
            this.lblHeightCm.Location = new System.Drawing.Point(9, 248);
            this.lblHeightCm.Name = "lblHeightCm";
            this.lblHeightCm.Size = new System.Drawing.Size(99, 23);
            this.lblHeightCm.TabIndex = 27;
            this.lblHeightCm.Text = "Height (cm)";
            // 
            // HealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 680);
            this.Controls.Add(this.pnlHealthRecords);
            this.Controls.Add(this.pnlHealthInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "HealthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System - Health";
            this.pnlHealthInfo.ResumeLayout(false);
            this.pnlHealthInfo.PerformLayout();
            this.pnlHealthRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMedicalCondition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.ComboBox cmbMemberId;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeightFeet;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Panel pnlHealthInfo;
        private System.Windows.Forms.Panel pnlHealthRecords;
        private System.Windows.Forms.DataGridView dgvHealthRecords;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBloodPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicalCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyContact;
        private System.Windows.Forms.CheckedListBox clbMedicalConditions;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbHeightInch;
        private System.Windows.Forms.ComboBox cmbHeightFeet;
        private System.Windows.Forms.Label lblHeightInch;
        private System.Windows.Forms.Label lblHeightCm;
        private System.Windows.Forms.TextBox txtHeightCm;
    }
}