namespace DBPROJ_VF
{
    partial class requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requests));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.approve = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.applications = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pROJDataSet1 = new DBPROJ_VF.PROJDataSet1();
            this.pROJDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franchiseApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franchise_ApplicationTableAdapter = new DBPROJ_VF.PROJDataSet1TableAdapters.Franchise_ApplicationTableAdapter();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ownerUNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.applications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franchiseApplicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // approve
            // 
            this.approve.AllowAnimations = true;
            this.approve.AllowMouseEffects = true;
            this.approve.AllowToggling = false;
            this.approve.AnimationSpeed = 200;
            this.approve.AutoGenerateColors = false;
            this.approve.AutoRoundBorders = true;
            this.approve.AutoSizeLeftIcon = true;
            this.approve.AutoSizeRightIcon = true;
            this.approve.BackColor = System.Drawing.Color.Transparent;
            this.approve.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.approve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("approve.BackgroundImage")));
            this.approve.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.approve.ButtonText = "Approve";
            this.approve.ButtonTextMarginLeft = 0;
            this.approve.ColorContrastOnClick = 45;
            this.approve.ColorContrastOnHover = 45;
            this.approve.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.approve.CustomizableEdges = borderEdges1;
            this.approve.DialogResult = System.Windows.Forms.DialogResult.None;
            this.approve.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.approve.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.approve.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.approve.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.approve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approve.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.approve.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.approve.IconMarginLeft = 11;
            this.approve.IconPadding = 10;
            this.approve.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.approve.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.approve.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.approve.IconSize = 25;
            this.approve.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.approve.IdleBorderRadius = 37;
            this.approve.IdleBorderThickness = 1;
            this.approve.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.approve.IdleIconLeftImage = null;
            this.approve.IdleIconRightImage = null;
            this.approve.IndicateFocus = false;
            this.approve.Location = new System.Drawing.Point(155, 392);
            this.approve.Name = "approve";
            this.approve.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.approve.OnDisabledState.BorderRadius = 1;
            this.approve.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.approve.OnDisabledState.BorderThickness = 1;
            this.approve.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.approve.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.approve.OnDisabledState.IconLeftImage = null;
            this.approve.OnDisabledState.IconRightImage = null;
            this.approve.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.approve.onHoverState.BorderRadius = 1;
            this.approve.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.approve.onHoverState.BorderThickness = 1;
            this.approve.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.approve.onHoverState.ForeColor = System.Drawing.Color.White;
            this.approve.onHoverState.IconLeftImage = null;
            this.approve.onHoverState.IconRightImage = null;
            this.approve.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.approve.OnIdleState.BorderRadius = 1;
            this.approve.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.approve.OnIdleState.BorderThickness = 1;
            this.approve.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.approve.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.approve.OnIdleState.IconLeftImage = null;
            this.approve.OnIdleState.IconRightImage = null;
            this.approve.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.approve.OnPressedState.BorderRadius = 1;
            this.approve.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.approve.OnPressedState.BorderThickness = 1;
            this.approve.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.approve.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.approve.OnPressedState.IconLeftImage = null;
            this.approve.OnPressedState.IconRightImage = null;
            this.approve.Size = new System.Drawing.Size(150, 39);
            this.approve.TabIndex = 1;
            this.approve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.approve.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.approve.TextMarginLeft = 0;
            this.approve.TextPadding = new System.Windows.Forms.Padding(0);
            this.approve.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = true;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Reject";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleBorderRadius = 37;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(481, 392);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 1;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.BorderRadius = 1;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 1;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton2.TabIndex = 2;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // applications
            // 
            this.applications.AllowCustomTheming = false;
            this.applications.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.applications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.applications.AutoGenerateColumns = false;
            this.applications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.applications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.idDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.propositionDataGridViewTextBoxColumn,
            this.ownerUNameDataGridViewTextBoxColumn});
            this.applications.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.applications.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.applications.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.applications.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.applications.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.applications.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.applications.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.applications.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.applications.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.applications.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.applications.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.applications.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.applications.CurrentTheme.Name = null;
            this.applications.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.applications.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.applications.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.applications.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.applications.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.applications.DataSource = this.franchiseApplicationBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.applications.DefaultCellStyle = dataGridViewCellStyle3;
            this.applications.EnableHeadersVisualStyles = false;
            this.applications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.applications.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.applications.HeaderBgColor = System.Drawing.Color.Empty;
            this.applications.HeaderForeColor = System.Drawing.Color.White;
            this.applications.Location = new System.Drawing.Point(2, 12);
            this.applications.Name = "applications";
            this.applications.RowHeadersVisible = false;
            this.applications.RowHeadersWidth = 51;
            this.applications.RowTemplate.Height = 40;
            this.applications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applications.Size = new System.Drawing.Size(793, 358);
            this.applications.TabIndex = 3;
            this.applications.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.applications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.applications_CellContentClick);
            // 
            // pROJDataSet1
            // 
            this.pROJDataSet1.DataSetName = "PROJDataSet1";
            this.pROJDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJDataSet1BindingSource
            // 
            this.pROJDataSet1BindingSource.DataSource = this.pROJDataSet1;
            this.pROJDataSet1BindingSource.Position = 0;
            // 
            // franchiseApplicationBindingSource
            // 
            this.franchiseApplicationBindingSource.DataMember = "Franchise_Application";
            this.franchiseApplicationBindingSource.DataSource = this.pROJDataSet1BindingSource;
            // 
            // franchise_ApplicationTableAdapter
            // 
            this.franchise_ApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox
            // 
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // demandDataGridViewTextBoxColumn
            // 
            this.demandDataGridViewTextBoxColumn.DataPropertyName = "demand";
            this.demandDataGridViewTextBoxColumn.HeaderText = "demand";
            this.demandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.demandDataGridViewTextBoxColumn.Name = "demandDataGridViewTextBoxColumn";
            // 
            // propositionDataGridViewTextBoxColumn
            // 
            this.propositionDataGridViewTextBoxColumn.DataPropertyName = "proposition";
            this.propositionDataGridViewTextBoxColumn.HeaderText = "proposition";
            this.propositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propositionDataGridViewTextBoxColumn.Name = "propositionDataGridViewTextBoxColumn";
            this.propositionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.propositionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ownerUNameDataGridViewTextBoxColumn
            // 
            this.ownerUNameDataGridViewTextBoxColumn.DataPropertyName = "ownerUName";
            this.ownerUNameDataGridViewTextBoxColumn.HeaderText = "ownerUName";
            this.ownerUNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerUNameDataGridViewTextBoxColumn.Name = "ownerUNameDataGridViewTextBoxColumn";
            // 
            // requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applications);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.approve);
            this.DoubleBuffered = true;
            this.Name = "requests";
            this.Text = "Applications";
            this.Load += new System.EventHandler(this.requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franchiseApplicationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton approve;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuDataGridView applications;
        private System.Windows.Forms.BindingSource pROJDataSet1BindingSource;
        private PROJDataSet1 pROJDataSet1;
        private System.Windows.Forms.BindingSource franchiseApplicationBindingSource;
        private PROJDataSet1TableAdapters.Franchise_ApplicationTableAdapter franchise_ApplicationTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn propositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerUNameDataGridViewTextBoxColumn;
    }
}