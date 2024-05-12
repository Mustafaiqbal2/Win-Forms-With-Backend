namespace DBPROJ_VF
{
    partial class MemberChooseWorkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberChooseWorkout));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Submit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.WorkSelectDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.projectfinalDataSet = new DBPROJ_VF.ProjectfinalDataSet();
            this.workoutPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workout_PlanTableAdapter = new DBPROJ_VF.ProjectfinalDataSetTableAdapters.Workout_PlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutPlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Workout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(22, 164);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(739, 234);
            this.bunifuDataGridView1.TabIndex = 8;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // Submit
            // 
            this.Submit.AllowAnimations = true;
            this.Submit.AllowMouseEffects = true;
            this.Submit.AllowToggling = false;
            this.Submit.AnimationSpeed = 200;
            this.Submit.AutoGenerateColors = false;
            this.Submit.AutoRoundBorders = false;
            this.Submit.AutoSizeLeftIcon = true;
            this.Submit.AutoSizeRightIcon = true;
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Submit.BackgroundImage")));
            this.Submit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.ButtonText = "submit";
            this.Submit.ButtonTextMarginLeft = 0;
            this.Submit.ColorContrastOnClick = 45;
            this.Submit.ColorContrastOnHover = 45;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Submit.CustomizableEdges = borderEdges5;
            this.Submit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Submit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Submit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Submit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Submit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Submit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Submit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Submit.IconMarginLeft = 11;
            this.Submit.IconPadding = 10;
            this.Submit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Submit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Submit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Submit.IconSize = 25;
            this.Submit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Submit.IdleBorderRadius = 1;
            this.Submit.IdleBorderThickness = 1;
            this.Submit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Submit.IdleIconLeftImage = null;
            this.Submit.IdleIconRightImage = null;
            this.Submit.IndicateFocus = false;
            this.Submit.Location = new System.Drawing.Point(280, 415);
            this.Submit.Name = "Submit";
            this.Submit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Submit.OnDisabledState.BorderRadius = 1;
            this.Submit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.OnDisabledState.BorderThickness = 1;
            this.Submit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Submit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Submit.OnDisabledState.IconLeftImage = null;
            this.Submit.OnDisabledState.IconRightImage = null;
            this.Submit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Submit.onHoverState.BorderRadius = 1;
            this.Submit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.onHoverState.BorderThickness = 1;
            this.Submit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Submit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Submit.onHoverState.IconLeftImage = null;
            this.Submit.onHoverState.IconRightImage = null;
            this.Submit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Submit.OnIdleState.BorderRadius = 1;
            this.Submit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.OnIdleState.BorderThickness = 1;
            this.Submit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Submit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Submit.OnIdleState.IconLeftImage = null;
            this.Submit.OnIdleState.IconRightImage = null;
            this.Submit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Submit.OnPressedState.BorderRadius = 1;
            this.Submit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Submit.OnPressedState.BorderThickness = 1;
            this.Submit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Submit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Submit.OnPressedState.IconLeftImage = null;
            this.Submit.OnPressedState.IconRightImage = null;
            this.Submit.Size = new System.Drawing.Size(198, 34);
            this.Submit.TabIndex = 9;
            this.Submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Submit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Submit.TextMarginLeft = 0;
            this.Submit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Submit.UseDefaultRadiusAndThickness = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // WorkSelectDropDown
            // 
            this.WorkSelectDropDown.BackColor = System.Drawing.Color.Transparent;
            this.WorkSelectDropDown.BackgroundColor = System.Drawing.Color.White;
            this.WorkSelectDropDown.BorderColor = System.Drawing.Color.Silver;
            this.WorkSelectDropDown.BorderRadius = 1;
            this.WorkSelectDropDown.Color = System.Drawing.Color.Silver;
            this.WorkSelectDropDown.DataSource = this.workoutPlanBindingSource;
            this.WorkSelectDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.WorkSelectDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.WorkSelectDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.WorkSelectDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.WorkSelectDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WorkSelectDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.WorkSelectDropDown.DisplayMember = "name";
            this.WorkSelectDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.WorkSelectDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.WorkSelectDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkSelectDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.WorkSelectDropDown.FillDropDown = true;
            this.WorkSelectDropDown.FillIndicator = false;
            this.WorkSelectDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkSelectDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WorkSelectDropDown.ForeColor = System.Drawing.Color.Black;
            this.WorkSelectDropDown.Icon = null;
            this.WorkSelectDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.WorkSelectDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.WorkSelectDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.WorkSelectDropDown.ItemBackColor = System.Drawing.Color.White;
            this.WorkSelectDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.WorkSelectDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.WorkSelectDropDown.ItemHeight = 26;
            this.WorkSelectDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.WorkSelectDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.WorkSelectDropDown.ItemTopMargin = 3;
            this.WorkSelectDropDown.Location = new System.Drawing.Point(259, 101);
            this.WorkSelectDropDown.Name = "WorkSelectDropDown";
            this.WorkSelectDropDown.Size = new System.Drawing.Size(260, 32);
            this.WorkSelectDropDown.TabIndex = 0;
            this.WorkSelectDropDown.Text = null;
            this.WorkSelectDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.WorkSelectDropDown.TextLeftMargin = 5;
            this.WorkSelectDropDown.ValueMember = "name";
            this.WorkSelectDropDown.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // projectfinalDataSet
            // 
            this.projectfinalDataSet.DataSetName = "ProjectfinalDataSet";
            this.projectfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutPlanBindingSource
            // 
            this.workoutPlanBindingSource.DataMember = "Workout_Plan";
            this.workoutPlanBindingSource.DataSource = this.projectfinalDataSet;
            // 
            // workout_PlanTableAdapter
            // 
            this.workout_PlanTableAdapter.ClearBeforeFill = true;
            // 
            // MemberChooseWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkSelectDropDown);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MemberChooseWorkout";
            this.Text = "MemberChooseWorkout";
            this.Load += new System.EventHandler(this.MemberChooseWorkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutPlanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Submit;
        private Bunifu.UI.WinForms.BunifuDropdown WorkSelectDropDown;
        private ProjectfinalDataSet projectfinalDataSet;
        private System.Windows.Forms.BindingSource workoutPlanBindingSource;
        private ProjectfinalDataSetTableAdapters.Workout_PlanTableAdapter workout_PlanTableAdapter;
    }
}