namespace DBPROJ_VF
{
    partial class deleteAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteAccounts));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gymMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJDataSet = new DBPROJ_VF.PROJDataSet();
            this.gym_MemberTableAdapter = new DBPROJ_VF.PROJDataSetTableAdapters.Gym_MemberTableAdapter();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trnUNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymMemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainerTableAdapter = new DBPROJ_VF.PROJDataSetTableAdapters.TrainerTableAdapter();
            this.submit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.mem = new System.Windows.Forms.Label();
            this.Trainers = new System.Windows.Forms.Label();
            this.bunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gymMemberBindingSource
            // 
            this.gymMemberBindingSource.DataMember = "Gym_Member";
            this.gymMemberBindingSource.DataSource = this.pROJDataSet;
            // 
            // pROJDataSet
            // 
            this.pROJDataSet.DataSetName = "PROJDataSet";
            this.pROJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gym_MemberTableAdapter
            // 
            this.gym_MemberTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.uNameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.regdateDataGridViewTextBoxColumn,
            this.subscriptionDataGridViewTextBoxColumn,
            this.trnUNameDataGridViewTextBoxColumn});
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
            this.bunifuDataGridView1.DataSource = this.gymMemberBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(45, 92);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(940, 181);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // checkBox
            // 
            this.checkBox.FalseValue = "0";
            this.checkBox.HeaderText = "";
            this.checkBox.IndeterminateValue = "0";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.TrueValue = "1";
            // 
            // uNameDataGridViewTextBoxColumn
            // 
            this.uNameDataGridViewTextBoxColumn.DataPropertyName = "UName";
            this.uNameDataGridViewTextBoxColumn.HeaderText = "UName";
            this.uNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNameDataGridViewTextBoxColumn.Name = "uNameDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // regdateDataGridViewTextBoxColumn
            // 
            this.regdateDataGridViewTextBoxColumn.DataPropertyName = "reg_date";
            this.regdateDataGridViewTextBoxColumn.HeaderText = "reg_date";
            this.regdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regdateDataGridViewTextBoxColumn.Name = "regdateDataGridViewTextBoxColumn";
            // 
            // subscriptionDataGridViewTextBoxColumn
            // 
            this.subscriptionDataGridViewTextBoxColumn.DataPropertyName = "subscription";
            this.subscriptionDataGridViewTextBoxColumn.HeaderText = "subscription";
            this.subscriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subscriptionDataGridViewTextBoxColumn.Name = "subscriptionDataGridViewTextBoxColumn";
            // 
            // trnUNameDataGridViewTextBoxColumn
            // 
            this.trnUNameDataGridViewTextBoxColumn.DataPropertyName = "trnUName";
            this.trnUNameDataGridViewTextBoxColumn.HeaderText = "trnUName";
            this.trnUNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trnUNameDataGridViewTextBoxColumn.Name = "trnUNameDataGridViewTextBoxColumn";
            // 
            // gymMemberBindingSource1
            // 
            this.gymMemberBindingSource1.DataMember = "Gym_Member";
            this.gymMemberBindingSource1.DataSource = this.pROJDataSet;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "Trainer";
            this.trainerBindingSource.DataSource = this.pROJDataSet;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // submit
            // 
            this.submit.AllowAnimations = true;
            this.submit.AllowMouseEffects = true;
            this.submit.AllowToggling = false;
            this.submit.AnimationSpeed = 200;
            this.submit.AutoGenerateColors = false;
            this.submit.AutoRoundBorders = false;
            this.submit.AutoSizeLeftIcon = true;
            this.submit.AutoSizeRightIcon = true;
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit.BackgroundImage")));
            this.submit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.submit.ButtonText = "Delete Selected";
            this.submit.ButtonTextMarginLeft = 0;
            this.submit.ColorContrastOnClick = 45;
            this.submit.ColorContrastOnHover = 45;
            this.submit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.submit.CustomizableEdges = borderEdges1;
            this.submit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.submit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.submit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.submit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.submit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.submit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.submit.IconMarginLeft = 11;
            this.submit.IconPadding = 10;
            this.submit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.submit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.submit.IconSize = 25;
            this.submit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.submit.IdleBorderRadius = 1;
            this.submit.IdleBorderThickness = 1;
            this.submit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.submit.IdleIconLeftImage = null;
            this.submit.IdleIconRightImage = null;
            this.submit.IndicateFocus = false;
            this.submit.Location = new System.Drawing.Point(427, 575);
            this.submit.Name = "submit";
            this.submit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.submit.OnDisabledState.BorderRadius = 1;
            this.submit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.submit.OnDisabledState.BorderThickness = 1;
            this.submit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.submit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.submit.OnDisabledState.IconLeftImage = null;
            this.submit.OnDisabledState.IconRightImage = null;
            this.submit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.submit.onHoverState.BorderRadius = 1;
            this.submit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.submit.onHoverState.BorderThickness = 1;
            this.submit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.submit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.submit.onHoverState.IconLeftImage = null;
            this.submit.onHoverState.IconRightImage = null;
            this.submit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.submit.OnIdleState.BorderRadius = 1;
            this.submit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.submit.OnIdleState.BorderThickness = 1;
            this.submit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.submit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.submit.OnIdleState.IconLeftImage = null;
            this.submit.OnIdleState.IconRightImage = null;
            this.submit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.submit.OnPressedState.BorderRadius = 1;
            this.submit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.submit.OnPressedState.BorderThickness = 1;
            this.submit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.submit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.submit.OnPressedState.IconLeftImage = null;
            this.submit.OnPressedState.IconRightImage = null;
            this.submit.Size = new System.Drawing.Size(150, 39);
            this.submit.TabIndex = 2;
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.submit.TextMarginLeft = 0;
            this.submit.TextPadding = new System.Windows.Forms.Padding(0);
            this.submit.UseDefaultRadiusAndThickness = true;
            // 
            // mem
            // 
            this.mem.AutoSize = true;
            this.mem.BackColor = System.Drawing.Color.Transparent;
            this.mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.mem.Location = new System.Drawing.Point(44, 13);
            this.mem.Name = "mem";
            this.mem.Size = new System.Drawing.Size(311, 76);
            this.mem.TabIndex = 6;
            this.mem.Text = "Members";
            // 
            // Trainers
            // 
            this.Trainers.AutoSize = true;
            this.Trainers.BackColor = System.Drawing.Color.Transparent;
            this.Trainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Trainers.Location = new System.Drawing.Point(44, 276);
            this.Trainers.Name = "Trainers";
            this.Trainers.Size = new System.Drawing.Size(276, 76);
            this.Trainers.TabIndex = 7;
            this.Trainers.Text = "Trainers";
            // 
            // bunifuDataGridView2
            // 
            this.bunifuDataGridView2.AllowCustomTheming = false;
            this.bunifuDataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView2.AutoGenerateColumns = false;
            this.bunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.uNameDataGridViewTextBoxColumn1,
            this.fNameDataGridViewTextBoxColumn1,
            this.lNameDataGridViewTextBoxColumn1,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.explvlDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn});
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.Name = null;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.DataSource = this.trainerBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView2.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.Location = new System.Drawing.Point(45, 355);
            this.bunifuDataGridView2.Name = "bunifuDataGridView2";
            this.bunifuDataGridView2.RowHeadersVisible = false;
            this.bunifuDataGridView2.RowHeadersWidth = 51;
            this.bunifuDataGridView2.RowTemplate.Height = 40;
            this.bunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView2.Size = new System.Drawing.Size(940, 214);
            this.bunifuDataGridView2.TabIndex = 8;
            this.bunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "0";
            this.Column1.HeaderText = "";
            this.Column1.IndeterminateValue = "0";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "1";
            // 
            // uNameDataGridViewTextBoxColumn1
            // 
            this.uNameDataGridViewTextBoxColumn1.DataPropertyName = "UName";
            this.uNameDataGridViewTextBoxColumn1.HeaderText = "UName";
            this.uNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.uNameDataGridViewTextBoxColumn1.Name = "uNameDataGridViewTextBoxColumn1";
            // 
            // fNameDataGridViewTextBoxColumn1
            // 
            this.fNameDataGridViewTextBoxColumn1.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn1.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn1.Name = "fNameDataGridViewTextBoxColumn1";
            // 
            // lNameDataGridViewTextBoxColumn1
            // 
            this.lNameDataGridViewTextBoxColumn1.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn1.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lNameDataGridViewTextBoxColumn1.Name = "lNameDataGridViewTextBoxColumn1";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // explvlDataGridViewTextBoxColumn
            // 
            this.explvlDataGridViewTextBoxColumn.DataPropertyName = "exp_lvl";
            this.explvlDataGridViewTextBoxColumn.HeaderText = "exp_lvl";
            this.explvlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.explvlDataGridViewTextBoxColumn.Name = "explvlDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // deleteAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 638);
            this.Controls.Add(this.bunifuDataGridView2);
            this.Controls.Add(this.Trainers);
            this.Controls.Add(this.mem);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.bunifuDataGridView1);
            this.DoubleBuffered = true;
            this.Name = "deleteAccounts";
            this.Text = "deleteAccounts";
            this.Load += new System.EventHandler(this.deleteAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PROJDataSet pROJDataSet;
        private System.Windows.Forms.BindingSource gymMemberBindingSource;
        private PROJDataSetTableAdapters.Gym_MemberTableAdapter gym_MemberTableAdapter;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.BindingSource gymMemberBindingSource1;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private PROJDataSetTableAdapters.TrainerTableAdapter trainerTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton submit;
        private System.Windows.Forms.Label mem;
        private System.Windows.Forms.Label Trainers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trnUNameDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explvlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    }
}