namespace gymmanagementsystem_2.FORMS
{
    partial class MemberHealthForm
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
            this.pnlMemberInfo = new System.Windows.Forms.Panel();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.pnlHealthInfo = new System.Windows.Forms.Panel();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblMedicalConditions = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.pnlEmergency = new System.Windows.Forms.Panel();
            this.lblEmergencyContact = new System.Windows.Forms.Label();
            this.lblEmergencyPhone = new System.Windows.Forms.Label();
            this.dgvHealthRecords = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMemberInfo.SuspendLayout();
            this.pnlHealthInfo.SuspendLayout();
            this.pnlEmergency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(250, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MY HEALTH RECORD";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(22, 18);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(122, 23);
            this.lblMemberId.TabIndex = 1;
            this.lblMemberId.Text = "Member ID: —";
            // 
            // pnlMemberInfo
            // 
            this.pnlMemberInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMemberInfo.Controls.Add(this.lblMemberName);
            this.pnlMemberInfo.Controls.Add(this.lblMemberId);
            this.pnlMemberInfo.Location = new System.Drawing.Point(34, 53);
            this.pnlMemberInfo.Name = "pnlMemberInfo";
            this.pnlMemberInfo.Size = new System.Drawing.Size(892, 66);
            this.pnlMemberInfo.TabIndex = 2;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(460, 18);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(151, 23);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Member Name: —";
            // 
            // pnlHealthInfo
            // 
            this.pnlHealthInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHealthInfo.Controls.Add(this.lblAllergies);
            this.pnlHealthInfo.Controls.Add(this.lblMedicalConditions);
            this.pnlHealthInfo.Controls.Add(this.lblBloodGroup);
            this.pnlHealthInfo.Controls.Add(this.lblBMI);
            this.pnlHealthInfo.Controls.Add(this.lblWeight);
            this.pnlHealthInfo.Controls.Add(this.lblHeight);
            this.pnlHealthInfo.Controls.Add(this.lblRecordDate);
            this.pnlHealthInfo.Location = new System.Drawing.Point(34, 135);
            this.pnlHealthInfo.Name = "pnlHealthInfo";
            this.pnlHealthInfo.Size = new System.Drawing.Size(892, 153);
            this.pnlHealthInfo.TabIndex = 3;
            // 
            // lblRecordDate
            // 
            this.lblRecordDate.AutoSize = true;
            this.lblRecordDate.Location = new System.Drawing.Point(14, 18);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(130, 23);
            this.lblRecordDate.TabIndex = 1;
            this.lblRecordDate.Text = "Record Date: —";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(494, 18);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(87, 23);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height: —";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(494, 51);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(95, 23);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = " Weight: —";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(494, 86);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(71, 23);
            this.lblBMI.TabIndex = 7;
            this.lblBMI.Text = " BMI: —";
            this.lblBMI.Click += new System.EventHandler(this.lblBlood_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(11, 119);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(133, 23);
            this.lblBloodGroup.TabIndex = 9;
            this.lblBloodGroup.Text = "Blood Group: —";
            // 
            // lblMedicalConditions
            // 
            this.lblMedicalConditions.AutoSize = true;
            this.lblMedicalConditions.Location = new System.Drawing.Point(14, 51);
            this.lblMedicalConditions.Name = "lblMedicalConditions";
            this.lblMedicalConditions.Size = new System.Drawing.Size(182, 23);
            this.lblMedicalConditions.TabIndex = 11;
            this.lblMedicalConditions.Text = "Medical Conditions: —";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(14, 86);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(85, 23);
            this.lblAllergies.TabIndex = 13;
            this.lblAllergies.Text = "Allergies:-";
            // 
            // pnlEmergency
            // 
            this.pnlEmergency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmergency.Controls.Add(this.lblEmergencyPhone);
            this.pnlEmergency.Controls.Add(this.lblEmergencyContact);
            this.pnlEmergency.Location = new System.Drawing.Point(34, 294);
            this.pnlEmergency.Name = "pnlEmergency";
            this.pnlEmergency.Size = new System.Drawing.Size(892, 72);
            this.pnlEmergency.TabIndex = 4;
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Location = new System.Drawing.Point(10, 20);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(185, 23);
            this.lblEmergencyContact.TabIndex = 0;
            this.lblEmergencyContact.Text = "Emergency Contact: —";
            // 
            // lblEmergencyPhone
            // 
            this.lblEmergencyPhone.AutoSize = true;
            this.lblEmergencyPhone.Location = new System.Drawing.Point(490, 20);
            this.lblEmergencyPhone.Name = "lblEmergencyPhone";
            this.lblEmergencyPhone.Size = new System.Drawing.Size(174, 23);
            this.lblEmergencyPhone.TabIndex = 2;
            this.lblEmergencyPhone.Text = "Emergency Phone: —";
            // 
            // dgvHealthRecords
            // 
            this.dgvHealthRecords.AllowUserToAddRows = false;
            this.dgvHealthRecords.AllowUserToDeleteRows = false;
            this.dgvHealthRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHealthRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthRecords.Location = new System.Drawing.Point(34, 383);
            this.dgvHealthRecords.MultiSelect = false;
            this.dgvHealthRecords.Name = "dgvHealthRecords";
            this.dgvHealthRecords.ReadOnly = true;
            this.dgvHealthRecords.RowHeadersWidth = 51;
            this.dgvHealthRecords.RowTemplate.Height = 24;
            this.dgvHealthRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthRecords.Size = new System.Drawing.Size(892, 211);
            this.dgvHealthRecords.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(154, 627);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(205, 37);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(558, 627);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 37);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MemberHealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 692);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvHealthRecords);
            this.Controls.Add(this.pnlEmergency);
            this.Controls.Add(this.pnlHealthInfo);
            this.Controls.Add(this.pnlMemberInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MemberHealthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Health - Gym Management System";
            this.pnlMemberInfo.ResumeLayout(false);
            this.pnlMemberInfo.PerformLayout();
            this.pnlHealthInfo.ResumeLayout(false);
            this.pnlHealthInfo.PerformLayout();
            this.pnlEmergency.ResumeLayout(false);
            this.pnlEmergency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Panel pnlMemberInfo;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Panel pnlHealthInfo;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblMedicalConditions;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRecordDate;
        private System.Windows.Forms.Panel pnlEmergency;
        private System.Windows.Forms.Label lblEmergencyPhone;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.DataGridView dgvHealthRecords;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}