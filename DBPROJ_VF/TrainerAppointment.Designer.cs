namespace DBPROJ_VF
{
    partial class TrainerAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerAppointment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentSubmitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScheduleSessionDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteSessionDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.DeleteSessionButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.projectfinalDataSet = new DBPROJ_VF.ProjectfinalDataSet();
            this.gymMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gym_MemberTableAdapter1 = new DBPROJ_VF.ProjectfinalDataSetTableAdapters.Gym_MemberTableAdapter();
            this.trainingSessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.training_SessionTableAdapter1 = new DBPROJ_VF.ProjectfinalDataSetTableAdapters.Training_SessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSessionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainer Appointments";
            // 
            // AppointmentSubmitButton
            // 
            this.AppointmentSubmitButton.AllowAnimations = true;
            this.AppointmentSubmitButton.AllowMouseEffects = true;
            this.AppointmentSubmitButton.AllowToggling = false;
            this.AppointmentSubmitButton.AnimationSpeed = 200;
            this.AppointmentSubmitButton.AutoGenerateColors = false;
            this.AppointmentSubmitButton.AutoRoundBorders = false;
            this.AppointmentSubmitButton.AutoSizeLeftIcon = true;
            this.AppointmentSubmitButton.AutoSizeRightIcon = true;
            this.AppointmentSubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentSubmitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.AppointmentSubmitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppointmentSubmitButton.BackgroundImage")));
            this.AppointmentSubmitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppointmentSubmitButton.ButtonText = "Submit";
            this.AppointmentSubmitButton.ButtonTextMarginLeft = 0;
            this.AppointmentSubmitButton.ColorContrastOnClick = 45;
            this.AppointmentSubmitButton.ColorContrastOnHover = 45;
            this.AppointmentSubmitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.AppointmentSubmitButton.CustomizableEdges = borderEdges5;
            this.AppointmentSubmitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AppointmentSubmitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AppointmentSubmitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AppointmentSubmitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AppointmentSubmitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AppointmentSubmitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppointmentSubmitButton.ForeColor = System.Drawing.Color.White;
            this.AppointmentSubmitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppointmentSubmitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AppointmentSubmitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AppointmentSubmitButton.IconMarginLeft = 11;
            this.AppointmentSubmitButton.IconPadding = 10;
            this.AppointmentSubmitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AppointmentSubmitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AppointmentSubmitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AppointmentSubmitButton.IconSize = 25;
            this.AppointmentSubmitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.AppointmentSubmitButton.IdleBorderRadius = 1;
            this.AppointmentSubmitButton.IdleBorderThickness = 1;
            this.AppointmentSubmitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.AppointmentSubmitButton.IdleIconLeftImage = null;
            this.AppointmentSubmitButton.IdleIconRightImage = null;
            this.AppointmentSubmitButton.IndicateFocus = false;
            this.AppointmentSubmitButton.Location = new System.Drawing.Point(657, 276);
            this.AppointmentSubmitButton.Name = "AppointmentSubmitButton";
            this.AppointmentSubmitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AppointmentSubmitButton.OnDisabledState.BorderRadius = 1;
            this.AppointmentSubmitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppointmentSubmitButton.OnDisabledState.BorderThickness = 1;
            this.AppointmentSubmitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AppointmentSubmitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AppointmentSubmitButton.OnDisabledState.IconLeftImage = null;
            this.AppointmentSubmitButton.OnDisabledState.IconRightImage = null;
            this.AppointmentSubmitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AppointmentSubmitButton.onHoverState.BorderRadius = 1;
            this.AppointmentSubmitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppointmentSubmitButton.onHoverState.BorderThickness = 1;
            this.AppointmentSubmitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AppointmentSubmitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AppointmentSubmitButton.onHoverState.IconLeftImage = null;
            this.AppointmentSubmitButton.onHoverState.IconRightImage = null;
            this.AppointmentSubmitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AppointmentSubmitButton.OnIdleState.BorderRadius = 1;
            this.AppointmentSubmitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppointmentSubmitButton.OnIdleState.BorderThickness = 1;
            this.AppointmentSubmitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.AppointmentSubmitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AppointmentSubmitButton.OnIdleState.IconLeftImage = null;
            this.AppointmentSubmitButton.OnIdleState.IconRightImage = null;
            this.AppointmentSubmitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AppointmentSubmitButton.OnPressedState.BorderRadius = 1;
            this.AppointmentSubmitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppointmentSubmitButton.OnPressedState.BorderThickness = 1;
            this.AppointmentSubmitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AppointmentSubmitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AppointmentSubmitButton.OnPressedState.IconLeftImage = null;
            this.AppointmentSubmitButton.OnPressedState.IconRightImage = null;
            this.AppointmentSubmitButton.Size = new System.Drawing.Size(133, 22);
            this.AppointmentSubmitButton.TabIndex = 1;
            this.AppointmentSubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppointmentSubmitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppointmentSubmitButton.TextMarginLeft = 0;
            this.AppointmentSubmitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AppointmentSubmitButton.UseDefaultRadiusAndThickness = true;
            this.AppointmentSubmitButton.Click += new System.EventHandler(this.AppointmentSubmitButton_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(793, 89);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(118, 22);
            this.StartTimePicker.TabIndex = 2;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(793, 146);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(118, 22);
            this.EndTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(654, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(654, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select End Time";
            // 
            // ScheduleSessionDropDown
            // 
            this.ScheduleSessionDropDown.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleSessionDropDown.BackgroundColor = System.Drawing.Color.White;
            this.ScheduleSessionDropDown.BorderColor = System.Drawing.Color.Silver;
            this.ScheduleSessionDropDown.BorderRadius = 1;
            this.ScheduleSessionDropDown.Color = System.Drawing.Color.Silver;
            this.ScheduleSessionDropDown.DataSource = this.gymMemberBindingSource1;
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
            this.ScheduleSessionDropDown.Location = new System.Drawing.Point(657, 209);
            this.ScheduleSessionDropDown.Name = "ScheduleSessionDropDown";
            this.ScheduleSessionDropDown.Size = new System.Drawing.Size(260, 32);
            this.ScheduleSessionDropDown.TabIndex = 6;
            this.ScheduleSessionDropDown.Text = "Select Member";
            this.ScheduleSessionDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ScheduleSessionDropDown.TextLeftMargin = 5;
            this.ScheduleSessionDropDown.ValueMember = "UName";
            this.ScheduleSessionDropDown.SelectedIndexChanged += new System.EventHandler(this.ScheduleSessionDropDown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schedule A Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Delete A Session";
            // 
            // DeleteSessionDropdown
            // 
            this.DeleteSessionDropdown.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSessionDropdown.BackgroundColor = System.Drawing.Color.White;
            this.DeleteSessionDropdown.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSessionDropdown.BorderRadius = 1;
            this.DeleteSessionDropdown.Color = System.Drawing.Color.Silver;
            this.DeleteSessionDropdown.DataSource = this.trainingSessionBindingSource1;
            this.DeleteSessionDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DeleteSessionDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeleteSessionDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteSessionDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeleteSessionDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeleteSessionDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DeleteSessionDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DeleteSessionDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DeleteSessionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteSessionDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DeleteSessionDropdown.FillDropDown = true;
            this.DeleteSessionDropdown.FillIndicator = false;
            this.DeleteSessionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSessionDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteSessionDropdown.ForeColor = System.Drawing.Color.Black;
            this.DeleteSessionDropdown.FormattingEnabled = true;
            this.DeleteSessionDropdown.Icon = null;
            this.DeleteSessionDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DeleteSessionDropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.DeleteSessionDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DeleteSessionDropdown.ItemBackColor = System.Drawing.Color.White;
            this.DeleteSessionDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.DeleteSessionDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.DeleteSessionDropdown.ItemHeight = 26;
            this.DeleteSessionDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSessionDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DeleteSessionDropdown.ItemTopMargin = 3;
            this.DeleteSessionDropdown.Location = new System.Drawing.Point(657, 379);
            this.DeleteSessionDropdown.Name = "DeleteSessionDropdown";
            this.DeleteSessionDropdown.Size = new System.Drawing.Size(260, 32);
            this.DeleteSessionDropdown.TabIndex = 9;
            this.DeleteSessionDropdown.Text = "Select Member";
            this.DeleteSessionDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DeleteSessionDropdown.TextLeftMargin = 5;
            this.DeleteSessionDropdown.ValueMember = "sessionID";
            this.DeleteSessionDropdown.SelectedIndexChanged += new System.EventHandler(this.DeleteSessionDropdown_SelectedIndexChanged);
            // 
            // DeleteSessionButton
            // 
            this.DeleteSessionButton.AllowAnimations = true;
            this.DeleteSessionButton.AllowMouseEffects = true;
            this.DeleteSessionButton.AllowToggling = false;
            this.DeleteSessionButton.AnimationSpeed = 200;
            this.DeleteSessionButton.AutoGenerateColors = false;
            this.DeleteSessionButton.AutoRoundBorders = false;
            this.DeleteSessionButton.AutoSizeLeftIcon = true;
            this.DeleteSessionButton.AutoSizeRightIcon = true;
            this.DeleteSessionButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSessionButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.DeleteSessionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteSessionButton.BackgroundImage")));
            this.DeleteSessionButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSessionButton.ButtonText = "Delete";
            this.DeleteSessionButton.ButtonTextMarginLeft = 0;
            this.DeleteSessionButton.ColorContrastOnClick = 45;
            this.DeleteSessionButton.ColorContrastOnHover = 45;
            this.DeleteSessionButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.DeleteSessionButton.CustomizableEdges = borderEdges6;
            this.DeleteSessionButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteSessionButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteSessionButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteSessionButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteSessionButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DeleteSessionButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteSessionButton.ForeColor = System.Drawing.Color.White;
            this.DeleteSessionButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSessionButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSessionButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeleteSessionButton.IconMarginLeft = 11;
            this.DeleteSessionButton.IconPadding = 10;
            this.DeleteSessionButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSessionButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSessionButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeleteSessionButton.IconSize = 25;
            this.DeleteSessionButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSessionButton.IdleBorderRadius = 1;
            this.DeleteSessionButton.IdleBorderThickness = 1;
            this.DeleteSessionButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSessionButton.IdleIconLeftImage = null;
            this.DeleteSessionButton.IdleIconRightImage = null;
            this.DeleteSessionButton.IndicateFocus = false;
            this.DeleteSessionButton.Location = new System.Drawing.Point(657, 437);
            this.DeleteSessionButton.Name = "DeleteSessionButton";
            this.DeleteSessionButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteSessionButton.OnDisabledState.BorderRadius = 1;
            this.DeleteSessionButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSessionButton.OnDisabledState.BorderThickness = 1;
            this.DeleteSessionButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteSessionButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteSessionButton.OnDisabledState.IconLeftImage = null;
            this.DeleteSessionButton.OnDisabledState.IconRightImage = null;
            this.DeleteSessionButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DeleteSessionButton.onHoverState.BorderRadius = 1;
            this.DeleteSessionButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSessionButton.onHoverState.BorderThickness = 1;
            this.DeleteSessionButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DeleteSessionButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DeleteSessionButton.onHoverState.IconLeftImage = null;
            this.DeleteSessionButton.onHoverState.IconRightImage = null;
            this.DeleteSessionButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSessionButton.OnIdleState.BorderRadius = 1;
            this.DeleteSessionButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSessionButton.OnIdleState.BorderThickness = 1;
            this.DeleteSessionButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSessionButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DeleteSessionButton.OnIdleState.IconLeftImage = null;
            this.DeleteSessionButton.OnIdleState.IconRightImage = null;
            this.DeleteSessionButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeleteSessionButton.OnPressedState.BorderRadius = 1;
            this.DeleteSessionButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSessionButton.OnPressedState.BorderThickness = 1;
            this.DeleteSessionButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeleteSessionButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteSessionButton.OnPressedState.IconLeftImage = null;
            this.DeleteSessionButton.OnPressedState.IconRightImage = null;
            this.DeleteSessionButton.Size = new System.Drawing.Size(133, 22);
            this.DeleteSessionButton.TabIndex = 10;
            this.DeleteSessionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteSessionButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteSessionButton.TextMarginLeft = 0;
            this.DeleteSessionButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeleteSessionButton.UseDefaultRadiusAndThickness = true;
            this.DeleteSessionButton.Click += new System.EventHandler(this.DeleteSessionButton_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(19, 80);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(603, 310);
            this.bunifuDataGridView1.TabIndex = 11;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // projectfinalDataSet
            // 
            this.projectfinalDataSet.DataSetName = "ProjectfinalDataSet";
            this.projectfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymMemberBindingSource1
            // 
            this.gymMemberBindingSource1.DataMember = "Gym_Member";
            this.gymMemberBindingSource1.DataSource = this.projectfinalDataSet;
            // 
            // gym_MemberTableAdapter1
            // 
            this.gym_MemberTableAdapter1.ClearBeforeFill = true;
            // 
            // trainingSessionBindingSource1
            // 
            this.trainingSessionBindingSource1.DataMember = "Training_Session";
            this.trainingSessionBindingSource1.DataSource = this.projectfinalDataSet;
            // 
            // training_SessionTableAdapter1
            // 
            this.training_SessionTableAdapter1.ClearBeforeFill = true;
            // 
            // TrainerAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 482);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.DeleteSessionButton);
            this.Controls.Add(this.DeleteSessionDropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ScheduleSessionDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.AppointmentSubmitButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "TrainerAppointment";
            this.Text = "TrainerAppointment";
            this.Load += new System.EventHandler(this.TrainerAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingSessionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AppointmentSubmitButton;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown ScheduleSessionDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuDropdown DeleteSessionDropdown;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteSessionButton;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private ProjectfinalDataSet projectfinalDataSet;
        private System.Windows.Forms.BindingSource gymMemberBindingSource1;
        private ProjectfinalDataSetTableAdapters.Gym_MemberTableAdapter gym_MemberTableAdapter1;
        private System.Windows.Forms.BindingSource trainingSessionBindingSource1;
        private ProjectfinalDataSetTableAdapters.Training_SessionTableAdapter training_SessionTableAdapter1;
    }
}