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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutPlan));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlanNameInput = new System.Windows.Forms.TextBox();
            this.MemberSelectDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
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
            this.label12 = new System.Windows.Forms.Label();
            this.ExerciseNameInputThursday = new System.Windows.Forms.TextBox();
            this.MachineNameInputThursday = new System.Windows.Forms.TextBox();
            this.SetsInputThursday = new System.Windows.Forms.NumericUpDown();
            this.RepsInputThursday = new System.Windows.Forms.NumericUpDown();
            this.RestIntervalInputThursday = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ExerciseNameInputFriday = new System.Windows.Forms.TextBox();
            this.MachineNameInputFriday = new System.Windows.Forms.TextBox();
            this.SetsInputFriday = new System.Windows.Forms.NumericUpDown();
            this.RepsInputFriday = new System.Windows.Forms.NumericUpDown();
            this.RestIntervalInputFriday = new System.Windows.Forms.NumericUpDown();
            this.WorkoutPlanSubmitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pROJDataSet = new DBPROJ_VF.PROJDataSet();
            this.gymMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gym_MemberTableAdapter = new DBPROJ_VF.PROJDataSetTableAdapters.Gym_MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputwednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(330, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plan Name";
            // 
            // PlanNameInput
            // 
            this.PlanNameInput.Location = new System.Drawing.Point(456, 52);
            this.PlanNameInput.Name = "PlanNameInput";
            this.PlanNameInput.Size = new System.Drawing.Size(197, 22);
            this.PlanNameInput.TabIndex = 2;
            // 
            // MemberSelectDropDown
            // 
            this.MemberSelectDropDown.BackColor = System.Drawing.Color.Transparent;
            this.MemberSelectDropDown.BackgroundColor = System.Drawing.Color.White;
            this.MemberSelectDropDown.BorderColor = System.Drawing.Color.Silver;
            this.MemberSelectDropDown.BorderRadius = 1;
            this.MemberSelectDropDown.Color = System.Drawing.Color.Silver;
            this.MemberSelectDropDown.DataSource = this.gymMemberBindingSource;
            this.MemberSelectDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.MemberSelectDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MemberSelectDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MemberSelectDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MemberSelectDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MemberSelectDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.MemberSelectDropDown.DisplayMember = "UName";
            this.MemberSelectDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MemberSelectDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.MemberSelectDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MemberSelectDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.MemberSelectDropDown.FillDropDown = true;
            this.MemberSelectDropDown.FillIndicator = false;
            this.MemberSelectDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberSelectDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MemberSelectDropDown.ForeColor = System.Drawing.Color.Black;
            this.MemberSelectDropDown.FormattingEnabled = true;
            this.MemberSelectDropDown.Icon = null;
            this.MemberSelectDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.MemberSelectDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.MemberSelectDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.MemberSelectDropDown.ItemBackColor = System.Drawing.Color.White;
            this.MemberSelectDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.MemberSelectDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.MemberSelectDropDown.ItemHeight = 26;
            this.MemberSelectDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.MemberSelectDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.MemberSelectDropDown.ItemTopMargin = 3;
            this.MemberSelectDropDown.Location = new System.Drawing.Point(693, 43);
            this.MemberSelectDropDown.Name = "MemberSelectDropDown";
            this.MemberSelectDropDown.Size = new System.Drawing.Size(192, 32);
            this.MemberSelectDropDown.TabIndex = 7;
            this.MemberSelectDropDown.Text = "Select Member";
            this.MemberSelectDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.MemberSelectDropDown.TextLeftMargin = 5;
            this.MemberSelectDropDown.ValueMember = "UName";
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
            this.ExerciseNameInputMonday.TextChanged += new System.EventHandler(this.ExerciseNameInputMonday_TextChanged);
            // 
            // MachineNameInputMonday
            // 
            this.MachineNameInputMonday.Location = new System.Drawing.Point(390, 156);
            this.MachineNameInputMonday.Name = "MachineNameInputMonday";
            this.MachineNameInputMonday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputMonday.TabIndex = 10;
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
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(83, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(201, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "ExerciseName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(386, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 44);
            this.label6.TabIndex = 16;
            this.label6.Text = "Machine Name\r\n(blank if none)\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(588, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(689, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Reps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(805, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 22);
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
            this.ExerciseNameInputTuesday.TextChanged += new System.EventHandler(this.ExerciseNameInputTuesday_TextChanged);
            // 
            // MachineNameInputTuesday
            // 
            this.MachineNameInputTuesday.Location = new System.Drawing.Point(390, 211);
            this.MachineNameInputTuesday.Name = "MachineNameInputTuesday";
            this.MachineNameInputTuesday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputTuesday.TabIndex = 22;
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
            // 
            // MachineNameInputWednesday
            // 
            this.MachineNameInputWednesday.Location = new System.Drawing.Point(390, 265);
            this.MachineNameInputWednesday.Name = "MachineNameInputWednesday";
            this.MachineNameInputWednesday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputWednesday.TabIndex = 28;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Thursday";
            // 
            // ExerciseNameInputThursday
            // 
            this.ExerciseNameInputThursday.Location = new System.Drawing.Point(205, 317);
            this.ExerciseNameInputThursday.Name = "ExerciseNameInputThursday";
            this.ExerciseNameInputThursday.Size = new System.Drawing.Size(138, 22);
            this.ExerciseNameInputThursday.TabIndex = 33;
            // 
            // MachineNameInputThursday
            // 
            this.MachineNameInputThursday.Location = new System.Drawing.Point(390, 317);
            this.MachineNameInputThursday.Name = "MachineNameInputThursday";
            this.MachineNameInputThursday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputThursday.TabIndex = 34;
            // 
            // SetsInputThursday
            // 
            this.SetsInputThursday.Location = new System.Drawing.Point(592, 317);
            this.SetsInputThursday.Name = "SetsInputThursday";
            this.SetsInputThursday.Size = new System.Drawing.Size(61, 22);
            this.SetsInputThursday.TabIndex = 35;
            // 
            // RepsInputThursday
            // 
            this.RepsInputThursday.Location = new System.Drawing.Point(693, 317);
            this.RepsInputThursday.Name = "RepsInputThursday";
            this.RepsInputThursday.Size = new System.Drawing.Size(61, 22);
            this.RepsInputThursday.TabIndex = 36;
            // 
            // RestIntervalInputThursday
            // 
            this.RestIntervalInputThursday.Location = new System.Drawing.Point(809, 317);
            this.RestIntervalInputThursday.Name = "RestIntervalInputThursday";
            this.RestIntervalInputThursday.Size = new System.Drawing.Size(61, 22);
            this.RestIntervalInputThursday.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Friday";
            // 
            // ExerciseNameInputFriday
            // 
            this.ExerciseNameInputFriday.Location = new System.Drawing.Point(205, 373);
            this.ExerciseNameInputFriday.Name = "ExerciseNameInputFriday";
            this.ExerciseNameInputFriday.Size = new System.Drawing.Size(138, 22);
            this.ExerciseNameInputFriday.TabIndex = 39;
            // 
            // MachineNameInputFriday
            // 
            this.MachineNameInputFriday.Location = new System.Drawing.Point(390, 373);
            this.MachineNameInputFriday.Name = "MachineNameInputFriday";
            this.MachineNameInputFriday.Size = new System.Drawing.Size(139, 22);
            this.MachineNameInputFriday.TabIndex = 40;
            // 
            // SetsInputFriday
            // 
            this.SetsInputFriday.Location = new System.Drawing.Point(592, 373);
            this.SetsInputFriday.Name = "SetsInputFriday";
            this.SetsInputFriday.Size = new System.Drawing.Size(61, 22);
            this.SetsInputFriday.TabIndex = 41;
            // 
            // RepsInputFriday
            // 
            this.RepsInputFriday.Location = new System.Drawing.Point(693, 373);
            this.RepsInputFriday.Name = "RepsInputFriday";
            this.RepsInputFriday.Size = new System.Drawing.Size(61, 22);
            this.RepsInputFriday.TabIndex = 42;
            // 
            // RestIntervalInputFriday
            // 
            this.RestIntervalInputFriday.Location = new System.Drawing.Point(809, 373);
            this.RestIntervalInputFriday.Name = "RestIntervalInputFriday";
            this.RestIntervalInputFriday.Size = new System.Drawing.Size(61, 22);
            this.RestIntervalInputFriday.TabIndex = 43;
            // 
            // WorkoutPlanSubmitButton
            // 
            this.WorkoutPlanSubmitButton.AllowAnimations = true;
            this.WorkoutPlanSubmitButton.AllowMouseEffects = true;
            this.WorkoutPlanSubmitButton.AllowToggling = false;
            this.WorkoutPlanSubmitButton.AnimationSpeed = 200;
            this.WorkoutPlanSubmitButton.AutoGenerateColors = false;
            this.WorkoutPlanSubmitButton.AutoRoundBorders = false;
            this.WorkoutPlanSubmitButton.AutoSizeLeftIcon = true;
            this.WorkoutPlanSubmitButton.AutoSizeRightIcon = true;
            this.WorkoutPlanSubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.WorkoutPlanSubmitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.WorkoutPlanSubmitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WorkoutPlanSubmitButton.BackgroundImage")));
            this.WorkoutPlanSubmitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.WorkoutPlanSubmitButton.ButtonText = "Submit";
            this.WorkoutPlanSubmitButton.ButtonTextMarginLeft = 0;
            this.WorkoutPlanSubmitButton.ColorContrastOnClick = 45;
            this.WorkoutPlanSubmitButton.ColorContrastOnHover = 45;
            this.WorkoutPlanSubmitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.WorkoutPlanSubmitButton.CustomizableEdges = borderEdges3;
            this.WorkoutPlanSubmitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.WorkoutPlanSubmitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.WorkoutPlanSubmitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.WorkoutPlanSubmitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.WorkoutPlanSubmitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.WorkoutPlanSubmitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkoutPlanSubmitButton.ForeColor = System.Drawing.Color.White;
            this.WorkoutPlanSubmitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkoutPlanSubmitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.WorkoutPlanSubmitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.WorkoutPlanSubmitButton.IconMarginLeft = 11;
            this.WorkoutPlanSubmitButton.IconPadding = 10;
            this.WorkoutPlanSubmitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkoutPlanSubmitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.WorkoutPlanSubmitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.WorkoutPlanSubmitButton.IconSize = 25;
            this.WorkoutPlanSubmitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.WorkoutPlanSubmitButton.IdleBorderRadius = 1;
            this.WorkoutPlanSubmitButton.IdleBorderThickness = 1;
            this.WorkoutPlanSubmitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.WorkoutPlanSubmitButton.IdleIconLeftImage = null;
            this.WorkoutPlanSubmitButton.IdleIconRightImage = null;
            this.WorkoutPlanSubmitButton.IndicateFocus = false;
            this.WorkoutPlanSubmitButton.Location = new System.Drawing.Point(396, 428);
            this.WorkoutPlanSubmitButton.Name = "WorkoutPlanSubmitButton";
            this.WorkoutPlanSubmitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.WorkoutPlanSubmitButton.OnDisabledState.BorderRadius = 1;
            this.WorkoutPlanSubmitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.WorkoutPlanSubmitButton.OnDisabledState.BorderThickness = 1;
            this.WorkoutPlanSubmitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.WorkoutPlanSubmitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.WorkoutPlanSubmitButton.OnDisabledState.IconLeftImage = null;
            this.WorkoutPlanSubmitButton.OnDisabledState.IconRightImage = null;
            this.WorkoutPlanSubmitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.WorkoutPlanSubmitButton.onHoverState.BorderRadius = 1;
            this.WorkoutPlanSubmitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.WorkoutPlanSubmitButton.onHoverState.BorderThickness = 1;
            this.WorkoutPlanSubmitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.WorkoutPlanSubmitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.WorkoutPlanSubmitButton.onHoverState.IconLeftImage = null;
            this.WorkoutPlanSubmitButton.onHoverState.IconRightImage = null;
            this.WorkoutPlanSubmitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.WorkoutPlanSubmitButton.OnIdleState.BorderRadius = 1;
            this.WorkoutPlanSubmitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.WorkoutPlanSubmitButton.OnIdleState.BorderThickness = 1;
            this.WorkoutPlanSubmitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.WorkoutPlanSubmitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.WorkoutPlanSubmitButton.OnIdleState.IconLeftImage = null;
            this.WorkoutPlanSubmitButton.OnIdleState.IconRightImage = null;
            this.WorkoutPlanSubmitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.WorkoutPlanSubmitButton.OnPressedState.BorderRadius = 1;
            this.WorkoutPlanSubmitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.WorkoutPlanSubmitButton.OnPressedState.BorderThickness = 1;
            this.WorkoutPlanSubmitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.WorkoutPlanSubmitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.WorkoutPlanSubmitButton.OnPressedState.IconLeftImage = null;
            this.WorkoutPlanSubmitButton.OnPressedState.IconRightImage = null;
            this.WorkoutPlanSubmitButton.Size = new System.Drawing.Size(133, 22);
            this.WorkoutPlanSubmitButton.TabIndex = 44;
            this.WorkoutPlanSubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WorkoutPlanSubmitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkoutPlanSubmitButton.TextMarginLeft = 0;
            this.WorkoutPlanSubmitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.WorkoutPlanSubmitButton.UseDefaultRadiusAndThickness = true;
            this.WorkoutPlanSubmitButton.Click += new System.EventHandler(this.WorkoutPlanSubmitButton_Click);
            // 
            // pROJDataSet
            // 
            this.pROJDataSet.DataSetName = "PROJDataSet";
            this.pROJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymMemberBindingSource
            // 
            this.gymMemberBindingSource.DataMember = "Gym_Member";
            this.gymMemberBindingSource.DataSource = this.pROJDataSet;
            // 
            // gym_MemberTableAdapter
            // 
            this.gym_MemberTableAdapter.ClearBeforeFill = true;
            // 
            // WorkoutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 482);
            this.Controls.Add(this.WorkoutPlanSubmitButton);
            this.Controls.Add(this.RestIntervalInputFriday);
            this.Controls.Add(this.RepsInputFriday);
            this.Controls.Add(this.SetsInputFriday);
            this.Controls.Add(this.MachineNameInputFriday);
            this.Controls.Add(this.ExerciseNameInputFriday);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RestIntervalInputThursday);
            this.Controls.Add(this.RepsInputThursday);
            this.Controls.Add(this.SetsInputThursday);
            this.Controls.Add(this.MachineNameInputThursday);
            this.Controls.Add(this.ExerciseNameInputThursday);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.MemberSelectDropDown);
            this.Controls.Add(this.PlanNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkoutPlan";
            this.Text = "WorkoutPlan";
            this.Load += new System.EventHandler(this.WorkoutPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputwednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetsInputFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepsInputFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestIntervalInputFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlanNameInput;
        private Bunifu.UI.WinForms.BunifuDropdown MemberSelectDropDown;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ExerciseNameInputThursday;
        private System.Windows.Forms.TextBox MachineNameInputThursday;
        private System.Windows.Forms.NumericUpDown SetsInputThursday;
        private System.Windows.Forms.NumericUpDown RepsInputThursday;
        private System.Windows.Forms.NumericUpDown RestIntervalInputThursday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ExerciseNameInputFriday;
        private System.Windows.Forms.TextBox MachineNameInputFriday;
        private System.Windows.Forms.NumericUpDown SetsInputFriday;
        private System.Windows.Forms.NumericUpDown RepsInputFriday;
        private System.Windows.Forms.NumericUpDown RestIntervalInputFriday;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton WorkoutPlanSubmitButton;
        private PROJDataSet pROJDataSet;
        private System.Windows.Forms.BindingSource gymMemberBindingSource;
        private PROJDataSetTableAdapters.Gym_MemberTableAdapter gym_MemberTableAdapter;
    }
}