namespace DBPROJ_VF
{
    partial class WorkoutPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutPlan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ScheduleSessionDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.ExerciseNameInputMonday = new System.Windows.Forms.TextBox();
            this.MachineNameInputMonday = new System.Windows.Forms.TextBox();
            this.SetsInputMonday = new System.Windows.Forms.NumericUpDown();
            this.RepsInputMonday = new System.Windows.Forms.NumericUpDown();
            this.RestIntervalInputMonday = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ExerciseNameInputTuesday = new System.Windows.Forms.TextBox();
            this.MachineNameInputTuesday = new System.Windows.Forms.TextBox();
            this.SetsInputTuesday = new System.Windows.Forms.NumericUpDown();
            this.RepsInputTuesday = new System.Windows.Forms.NumericUpDown();
            this.RestIntervalInputTuesday = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ExerciseNameInputWednesday = new System.Windows.Forms.TextBox();
            this.MachineNameInputWednesday = new System.Windows.Forms.TextBox();
            this.SetsInputWednesday = new System.Windows.Forms.NumericUpDown();
            this.RepsInputwednesday = new System.Windows.Forms.NumericUpDown();
            this.RestIntervalInputWednesday = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputwednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputWednesday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a Workout Plan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plan Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 2;
            // 
            // ScheduleSessionDropDown
            // 
            this.ScheduleSessionDropDown.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleSessionDropDown.BackgroundColor = System.Drawing.Color.White;
            this.ScheduleSessionDropDown.BorderColor = System.Drawing.Color.Silver;
            this.ScheduleSessionDropDown.BorderRadius = 1;
            this.ScheduleSessionDropDown.Color = System.Drawing.Color.Silver;
            this.ScheduleSessionDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ScheduleSessionDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ScheduleSessionDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ScheduleSessionDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ScheduleSessionDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ScheduleSessionDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ScheduleSessionDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ScheduleSessionDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ScheduleSessionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleSessionDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ScheduleSessionDropDown.FillDropDown = true;
            this.ScheduleSessionDropDown.FillIndicator = false;
            this.ScheduleSessionDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleSessionDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduleSessionDropDown.ForeColor = System.Drawing.Color.Black;
            this.ScheduleSessionDropDown.FormattingEnabled = true;
            this.ScheduleSessionDropDown.Icon = null;
            this.ScheduleSessionDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ScheduleSessionDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.ScheduleSessionDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ScheduleSessionDropDown.ItemBackColor = System.Drawing.Color.White;
            this.ScheduleSessionDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.ScheduleSessionDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.ScheduleSessionDropDown.ItemHeight = 26;
            this.ScheduleSessionDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ScheduleSessionDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ScheduleSessionDropDown.ItemTopMargin = 3;
            this.ScheduleSessionDropDown.Location = new System.Drawing.Point(693, 43);
            this.ScheduleSessionDropDown.Name = "ScheduleSessionDropDown";
            this.ScheduleSessionDropDown.Size = new System.Drawing.Size(192, 32);
            this.ScheduleSessionDropDown.TabIndex = 7;
            this.ScheduleSessionDropDown.Text = "Select Member";
            this.ScheduleSessionDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ScheduleSessionDropDown.TextLeftMargin = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monday";
            // 
            // ExerciseNameInputMonday
            // 
            this.ExerciseNameInputMonday.Location = new System.Drawing.Point(205, 154);
            this.ExerciseNameInputMonday.Name = "ExerciseNameInputMonday";
            this.ExerciseNameInputMonday.Size = new System.Drawing.Size(138, 22);
            this.ExerciseNameInputMonday.TabIndex = 9;
            this.ExerciseNameInputMonday.Text = "Exercise Name";
            // 
            // MachineNameInputMonday
            // 
            this.MachineNameInputMonday.Location = new System.Drawing.Point(390, 156);
            this.MachineNameInputMonday.Name = "MachineNameInputMonday";
            this.MachineNameInputMonday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputMonday.TabIndex = 10;
            this.MachineNameInputMonday.Text = "Machine";
            // 
            // SetsInputMonday
            // 
            this.SetsInputMonday.Location = new System.Drawing.Point(592, 154);
            this.SetsInputMonday.Name = "SetsInputMonday";
            this.SetsInputMonday.Size = new System.Drawing.Size(61, 22);
            this.SetsInputMonday.TabIndex = 11;
            // 
            // RepsInputMonday
            // 
            this.RepsInputMonday.Location = new System.Drawing.Point(693, 154);
            this.RepsInputMonday.Name = "RepsInputMonday";
            this.RepsInputMonday.Size = new System.Drawing.Size(61, 22);
            this.RepsInputMonday.TabIndex = 12;
            // 
            // RestIntervalInputMonday
            // 
            this.RestIntervalInputMonday.Location = new System.Drawing.Point(809, 156);
            this.RestIntervalInputMonday.Name = "RestIntervalInputMonday";
            this.RestIntervalInputMonday.Size = new System.Drawing.Size(61, 22);
            this.RestIntervalInputMonday.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ExerciseName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Machine Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(689, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(805, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rest Interval";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tuesday";
            // 
            // ExerciseNameInputTuesday
            // 
            this.ExerciseNameInputTuesday.Location = new System.Drawing.Point(205, 211);
            this.ExerciseNameInputTuesday.Name = "ExerciseNameInputTuesday";
            this.ExerciseNameInputTuesday.Size = new System.Drawing.Size(138, 22);
            this.ExerciseNameInputTuesday.TabIndex = 21;
            this.ExerciseNameInputTuesday.Text = "Exercise Name";
            // 
            // MachineNameInputTuesday
            // 
            this.MachineNameInputTuesday.Location = new System.Drawing.Point(390, 211);
            this.MachineNameInputTuesday.Name = "MachineNameInputTuesday";
            this.MachineNameInputTuesday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputTuesday.TabIndex = 22;
            this.MachineNameInputTuesday.Text = "Machine";
            // 
            // SetsInputTuesday
            // 
            this.SetsInputTuesday.Location = new System.Drawing.Point(592, 211);
            this.SetsInputTuesday.Name = "SetsInputTuesday";
            this.SetsInputTuesday.Size = new System.Drawing.Size(61, 22);
            this.SetsInputTuesday.TabIndex = 23;
            // 
            // RepsInputTuesday
            // 
            this.RepsInputTuesday.Location = new System.Drawing.Point(693, 211);
            this.RepsInputTuesday.Name = "RepsInputTuesday";
            this.RepsInputTuesday.Size = new System.Drawing.Size(61, 22);
            this.RepsInputTuesday.TabIndex = 24;
            // 
            // RestIntervalInputTuesday
            // 
            this.RestIntervalInputTuesday.Location = new System.Drawing.Point(809, 211);
            this.RestIntervalInputTuesday.Name = "RestIntervalInputTuesday";
            this.RestIntervalInputTuesday.Size = new System.Drawing.Size(61, 22);
            this.RestIntervalInputTuesday.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Wednesday";
            // 
            // ExerciseNameInputWednesday
            // 
            this.ExerciseNameInputWednesday.Location = new System.Drawing.Point(205, 265);
            this.ExerciseNameInputWednesday.Name = "ExerciseNameInputWednesday";
            this.ExerciseNameInputWednesday.Size = new System.Drawing.Size(138, 22);
            this.ExerciseNameInputWednesday.TabIndex = 27;
            this.ExerciseNameInputWednesday.Text = "Exercise Name";
            // 
            // MachineNameInputWednesday
            // 
            this.MachineNameInputWednesday.Location = new System.Drawing.Point(390, 265);
            this.MachineNameInputWednesday.Name = "MachineNameInputWednesday";
            this.MachineNameInputWednesday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputWednesday.TabIndex = 28;
            this.MachineNameInputWednesday.Text = "Machine";
            // 
            // SetsInputWednesday
            // 
            this.SetsInputWednesday.Location = new System.Drawing.Point(592, 263);
            this.SetsInputWednesday.Name = "SetsInputWednesday";
            this.SetsInputWednesday.Size = new System.Drawing.Size(61, 22);
            this.SetsInputWednesday.TabIndex = 29;
            // 
            // RepsInputwednesday
            // 
            this.RepsInputwednesday.Location = new System.Drawing.Point(693, 263);
            this.RepsInputwednesday.Name = "RepsInputwednesday";
            this.RepsInputwednesday.Size = new System.Drawing.Size(61, 22);
            this.RepsInputwednesday.TabIndex = 30;
            // 
            // RestIntervalInputWednesday
            // 
            this.RestIntervalInputWednesday.Location = new System.Drawing.Point(809, 263);
            this.RestIntervalInputWednesday.Name = "RestIntervalInputWednesday";
            this.RestIntervalInputWednesday.Size = new System.Drawing.Size(61, 22);
            this.RestIntervalInputWednesday.TabIndex = 31;
            // 
            // WorkoutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 482);
            this.Controls.Add(this.RestIntervalInputWednesday);
            this.Controls.Add(this.RepsInputwednesday);
            this.Controls.Add(this.SetsInputWednesday);
            this.Controls.Add(this.MachineNameInputWednesday);
            this.Controls.Add(this.ExerciseNameInputWednesday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RestIntervalInputTuesday);
            this.Controls.Add(this.RepsInputTuesday);
            this.Controls.Add(this.SetsInputTuesday);
            this.Controls.Add(this.MachineNameInputTuesday);
            this.Controls.Add(this.ExerciseNameInputTuesday);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RestIntervalInputMonday);
            this.Controls.Add(this.RepsInputMonday);
            this.Controls.Add(this.SetsInputMonday);
            this.Controls.Add(this.MachineNameInputMonday);
            this.Controls.Add(this.ExerciseNameInputMonday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScheduleSessionDropDown);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkoutPlan";
            this.Text = "WorkoutPlan";
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputwednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputWednesday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.UI.WinForms.BunifuDropdown ScheduleSessionDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExerciseNameInputMonday;
        private System.Windows.Forms.TextBox MachineNameInputMonday;
        private System.Windows.Forms.NumericUpDown SetsInputMonday;
        private System.Windows.Forms.NumericUpDown RepsInputMonday;
        private System.Windows.Forms.NumericUpDown RestIntervalInputMonday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExerciseNameInputTuesday;
        private System.Windows.Forms.TextBox MachineNameInputTuesday;
        private System.Windows.Forms.NumericUpDown SetsInputTuesday;
        private System.Windows.Forms.NumericUpDown RepsInputTuesday;
        private System.Windows.Forms.NumericUpDown RestIntervalInputTuesday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ExerciseNameInputWednesday;
        private System.Windows.Forms.TextBox MachineNameInputWednesday;
        private System.Windows.Forms.NumericUpDown SetsInputWednesday;
        private System.Windows.Forms.NumericUpDown RepsInputwednesday;
        private System.Windows.Forms.NumericUpDown RestIntervalInputWednesday;
    }
}