namespace gymmanagementsystem_2.FORMS
{
    partial class MemberWorkoutForm
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
            this.pnlMemberInfo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblWorkoutDetails = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblPlanNameValue = new System.Windows.Forms.Label();
            this.lblGoalTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTrainerValue = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMemberInfo.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMemberInfo
            // 
            this.pnlMemberInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMemberInfo.Controls.Add(this.lblMemberName);
            this.pnlMemberInfo.Controls.Add(this.lblMemberId);
            this.pnlMemberInfo.Location = new System.Drawing.Point(27, 63);
            this.pnlMemberInfo.Name = "pnlMemberInfo";
            this.pnlMemberInfo.Size = new System.Drawing.Size(840, 73);
            this.pnlMemberInfo.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(291, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 41);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MY WORKOUT";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(19, 17);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(122, 23);
            this.lblMemberId.TabIndex = 4;
            this.lblMemberId.Text = "Member ID: —";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(19, 19);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(139, 23);
            this.lblPlan.TabIndex = 6;
            this.lblPlan.Text = "Workout Plan: —";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(456, 17);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(151, 23);
            this.lblMemberName.TabIndex = 7;
            this.lblMemberName.Text = "Member Name: —";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblStatus);
            this.pnlSummary.Controls.Add(this.lblTrainer);
            this.pnlSummary.Controls.Add(this.lblGoal);
            this.pnlSummary.Controls.Add(this.lblPlan);
            this.pnlSummary.Location = new System.Drawing.Point(27, 153);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(831, 112);
            this.pnlSummary.TabIndex = 7;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(456, 19);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(71, 23);
            this.lblGoal.TabIndex = 7;
            this.lblGoal.Text = "Goal: —";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Location = new System.Drawing.Point(19, 66);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(88, 23);
            this.lblTrainer.TabIndex = 8;
            this.lblTrainer.Text = "Trainer: —";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(456, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 23);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status: —";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.lblStatusValue);
            this.pnlDetails.Controls.Add(this.lblTrainerValue);
            this.pnlDetails.Controls.Add(this.lblStartDate);
            this.pnlDetails.Controls.Add(this.lblEndDate);
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Controls.Add(this.lblGoalTitle);
            this.pnlDetails.Controls.Add(this.lblPlanNameValue);
            this.pnlDetails.Controls.Add(this.lblPlanName);
            this.pnlDetails.Controls.Add(this.lblWorkoutDetails);
            this.pnlDetails.Location = new System.Drawing.Point(27, 290);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(831, 199);
            this.pnlDetails.TabIndex = 8;
            // 
            // lblWorkoutDetails
            // 
            this.lblWorkoutDetails.AutoSize = true;
            this.lblWorkoutDetails.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutDetails.Location = new System.Drawing.Point(218, 0);
            this.lblWorkoutDetails.Name = "lblWorkoutDetails";
            this.lblWorkoutDetails.Size = new System.Drawing.Size(278, 30);
            this.lblWorkoutDetails.TabIndex = 1;
            this.lblWorkoutDetails.Text = "WORKOUT PLAN DETAILS";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(12, 49);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(98, 23);
            this.lblPlanName.TabIndex = 3;
            this.lblPlanName.Text = "Plan Name:";
            // 
            // lblPlanNameValue
            // 
            this.lblPlanNameValue.AutoSize = true;
            this.lblPlanNameValue.Location = new System.Drawing.Point(213, 49);
            this.lblPlanNameValue.Name = "lblPlanNameValue";
            this.lblPlanNameValue.Size = new System.Drawing.Size(17, 23);
            this.lblPlanNameValue.TabIndex = 5;
            this.lblPlanNameValue.Text = "-";
            // 
            // lblGoalTitle
            // 
            this.lblGoalTitle.AutoSize = true;
            this.lblGoalTitle.Location = new System.Drawing.Point(12, 81);
            this.lblGoalTitle.Name = "lblGoalTitle";
            this.lblGoalTitle.Size = new System.Drawing.Size(49, 23);
            this.lblGoalTitle.TabIndex = 6;
            this.lblGoalTitle.Text = "Goal:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(415, 116);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
        
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(415, 81);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(106, 23);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date: —";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(415, 49);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(112, 23);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date: —";
            // 
            // lblTrainerValue
            // 
            this.lblTrainerValue.AutoSize = true;
            this.lblTrainerValue.Location = new System.Drawing.Point(12, 116);
            this.lblTrainerValue.Name = "lblTrainerValue";
            this.lblTrainerValue.Size = new System.Drawing.Size(88, 23);
            this.lblTrainerValue.TabIndex = 14;
            this.lblTrainerValue.Text = "Trainer: —";
       
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(12, 150);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(82, 23);
            this.lblStatusValue.TabIndex = 16;
            this.lblStatusValue.Text = "Status: —";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(161, 508);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 43);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(488, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 42);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MemberWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 590);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMemberInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.Name = "MemberWorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Workout - Gym Management System";
            this.pnlMemberInfo.ResumeLayout(false);
            this.pnlMemberInfo.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMemberInfo;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblGoalTitle;
        private System.Windows.Forms.Label lblPlanNameValue;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblWorkoutDetails;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblTrainerValue;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}