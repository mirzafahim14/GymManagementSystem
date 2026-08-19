namespace gymmanagementsystem_2.FORMS
{
    partial class WorkoutForm
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
            this.lblWorkoutInfo = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.lblWorkoutType = new System.Windows.Forms.Label();
            this.cmbWorkoutType = new System.Windows.Forms.ComboBox();
            this.lblWorkoutGoal = new System.Windows.Forms.Label();
            this.cmbWorkoutGoal = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblExercises = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.lblReps = new System.Windows.Forms.Label();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblWorkoutList = new System.Windows.Forms.Label();
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.WorkoutId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkoutType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkoutGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exercises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbExercises = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(350, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WORKOUT MANAGEMENT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkoutInfo
            // 
            this.lblWorkoutInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutInfo.Location = new System.Drawing.Point(50, 100);
            this.lblWorkoutInfo.Name = "lblWorkoutInfo";
            this.lblWorkoutInfo.Size = new System.Drawing.Size(350, 30);
            this.lblWorkoutInfo.TabIndex = 1;
            this.lblWorkoutInfo.Text = "Workout Information";
            this.lblWorkoutInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMember
            // 
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(50, 150);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(120, 25);
            this.lblMember.TabIndex = 2;
            this.lblMember.Text = "Member";
            this.lblMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMember
            // 
            this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(213, 144);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(250, 31);
            this.cmbMember.TabIndex = 3;
            // 
            // lblWorkoutType
            // 
            this.lblWorkoutType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutType.Location = new System.Drawing.Point(50, 200);
            this.lblWorkoutType.Name = "lblWorkoutType";
            this.lblWorkoutType.Size = new System.Drawing.Size(150, 25);
            this.lblWorkoutType.TabIndex = 4;
            this.lblWorkoutType.Text = "Workout Type";
            this.lblWorkoutType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbWorkoutType
            // 
            this.cmbWorkoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkoutType.FormattingEnabled = true;
            this.cmbWorkoutType.Items.AddRange(new object[] {
            "Muscle Gain",
            "Weight Loss",
            "Fat Loss",
            "Strength Training",
            "Cardio",
            "Endurance",
            "Flexibility",
            "Bodybuilding",
            "General Fitness",
            "Sports Training",
            "Functional Training",
            "HIIT"});
            this.cmbWorkoutType.Location = new System.Drawing.Point(213, 194);
            this.cmbWorkoutType.Name = "cmbWorkoutType";
            this.cmbWorkoutType.Size = new System.Drawing.Size(250, 31);
            this.cmbWorkoutType.TabIndex = 5;
            // 
            // lblWorkoutGoal
            // 
            this.lblWorkoutGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutGoal.Location = new System.Drawing.Point(50, 250);
            this.lblWorkoutGoal.Name = "lblWorkoutGoal";
            this.lblWorkoutGoal.Size = new System.Drawing.Size(139, 25);
            this.lblWorkoutGoal.TabIndex = 6;
            this.lblWorkoutGoal.Text = "Workout Goal";
            this.lblWorkoutGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbWorkoutGoal
            // 
            this.cmbWorkoutGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkoutGoal.FormattingEnabled = true;
            this.cmbWorkoutGoal.Items.AddRange(new object[] {
            "Build Muscle",
            "Lose Weight",
            "Increase Strength",
            "Improve Endurance",
            "Improve Flexibility",
            "Maintain Fitness",
            "Improve Cardiovascular Health",
            "Improve Athletic Performance",
            "Body Toning",
            "General Wellness"});
            this.cmbWorkoutGoal.Location = new System.Drawing.Point(213, 244);
            this.cmbWorkoutGoal.Name = "cmbWorkoutGoal";
            this.cmbWorkoutGoal.Size = new System.Drawing.Size(250, 31);
            this.cmbWorkoutGoal.TabIndex = 7;
            this.cmbWorkoutGoal.SelectedIndexChanged += new System.EventHandler(this.cmbWorkoutGoal_SelectedIndexChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(50, 300);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(150, 25);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration (Days)";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(213, 295);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(250, 30);
            this.txtDuration.TabIndex = 9;
            // 
            // lblExercises
            // 
            this.lblExercises.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercises.Location = new System.Drawing.Point(50, 350);
            this.lblExercises.Name = "lblExercises";
            this.lblExercises.Size = new System.Drawing.Size(120, 25);
            this.lblExercises.TabIndex = 10;
            this.lblExercises.Text = "Exercises";
            this.lblExercises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSets
            // 
            this.lblSets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSets.Location = new System.Drawing.Point(50, 536);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(61, 25);
            this.lblSets.TabIndex = 12;
            this.lblSets.Text = "Sets";
            this.lblSets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSets
            // 
            this.txtSets.Location = new System.Drawing.Point(117, 536);
            this.txtSets.MaxLength = 2;
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(100, 30);
            this.txtSets.TabIndex = 13;
            // 
            // lblReps
            // 
            this.lblReps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReps.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblReps.Location = new System.Drawing.Point(255, 536);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(70, 25);
            this.lblReps.TabIndex = 14;
            this.lblReps.Text = "Reps";
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(331, 534);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(100, 30);
            this.txtReps.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(118, 590);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(331, 590);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(225, 590);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblWorkoutList
            // 
            this.lblWorkoutList.AutoSize = true;
            this.lblWorkoutList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutList.Location = new System.Drawing.Point(550, 100);
            this.lblWorkoutList.Name = "lblWorkoutList";
            this.lblWorkoutList.Size = new System.Drawing.Size(133, 28);
            this.lblWorkoutList.TabIndex = 22;
            this.lblWorkoutList.Text = "Workout List";
            this.lblWorkoutList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvWorkouts
            // 
            this.dgvWorkouts.AllowUserToAddRows = false;
            this.dgvWorkouts.AllowUserToDeleteRows = false;
            this.dgvWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkouts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkoutId,
            this.MemberId,
            this.WorkoutType,
            this.WorkoutGoal,
            this.Duration,
            this.Exercises,
            this.Sets,
            this.Reps});
            this.dgvWorkouts.Location = new System.Drawing.Point(507, 140);
            this.dgvWorkouts.MultiSelect = false;
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.ReadOnly = true;
            this.dgvWorkouts.RowHeadersWidth = 51;
            this.dgvWorkouts.RowTemplate.Height = 24;
            this.dgvWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkouts.Size = new System.Drawing.Size(696, 485);
            this.dgvWorkouts.TabIndex = 23;
            // 
            // WorkoutId
            // 
            this.WorkoutId.HeaderText = "Workout ID";
            this.WorkoutId.MinimumWidth = 6;
            this.WorkoutId.Name = "WorkoutId";
            this.WorkoutId.ReadOnly = true;
            // 
            // MemberId
            // 
            this.MemberId.HeaderText = "Member ID";
            this.MemberId.MinimumWidth = 6;
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            // 
            // WorkoutType
            // 
            this.WorkoutType.HeaderText = "Workout Type";
            this.WorkoutType.MinimumWidth = 6;
            this.WorkoutType.Name = "WorkoutType";
            this.WorkoutType.ReadOnly = true;
            // 
            // WorkoutGoal
            // 
            this.WorkoutGoal.HeaderText = "Workout Goal";
            this.WorkoutGoal.MinimumWidth = 6;
            this.WorkoutGoal.Name = "WorkoutGoal";
            this.WorkoutGoal.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration (Days)";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Exercises
            // 
            this.Exercises.HeaderText = "Exercises";
            this.Exercises.MinimumWidth = 6;
            this.Exercises.Name = "Exercises";
            this.Exercises.ReadOnly = true;
            // 
            // Sets
            // 
            this.Sets.HeaderText = "Sets";
            this.Sets.MinimumWidth = 6;
            this.Sets.Name = "Sets";
            this.Sets.ReadOnly = true;
            // 
            // Reps
            // 
            this.Reps.HeaderText = "Reps";
            this.Reps.MinimumWidth = 6;
            this.Reps.Name = "Reps";
            this.Reps.ReadOnly = true;
            // 
            // clbExercises
            // 
            this.clbExercises.FormattingEnabled = true;
            this.clbExercises.Location = new System.Drawing.Point(221, 356);
            this.clbExercises.Name = "clbExercises";
            this.clbExercises.Size = new System.Drawing.Size(250, 129);
            this.clbExercises.TabIndex = 24;
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 655);
            this.Controls.Add(this.clbExercises);
            this.Controls.Add(this.dgvWorkouts);
            this.Controls.Add(this.lblWorkoutList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblExercises);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.cmbWorkoutGoal);
            this.Controls.Add(this.lblWorkoutGoal);
            this.Controls.Add(this.cmbWorkoutType);
            this.Controls.Add(this.lblWorkoutType);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblWorkoutInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "WorkoutForm";
            this.Text = "Gym Management System - Workout";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWorkoutInfo;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label lblWorkoutType;
        private System.Windows.Forms.ComboBox cmbWorkoutType;
        private System.Windows.Forms.Label lblWorkoutGoal;
        private System.Windows.Forms.ComboBox cmbWorkoutGoal;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblExercises;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblWorkoutList;
        private System.Windows.Forms.DataGridView dgvWorkouts;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkoutId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkoutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkoutGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercises;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reps;
        private System.Windows.Forms.CheckedListBox clbExercises;
    }
}