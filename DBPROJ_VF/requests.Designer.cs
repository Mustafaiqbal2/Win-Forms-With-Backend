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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requests));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pROJDataSet = new DBPROJ_VF.PROJDataSet();
            this.pROJDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franchiseApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.franchise_ApplicationTableAdapter = new DBPROJ_VF.PROJDataSetTableAdapters.Franchise_ApplicationTableAdapter();
            this.approve = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.App_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proposition = new System.Windows.Forms.DataGridViewLinkColumn();
            this.owner_uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franchiseApplicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.App_Id,
            this.Location,
            this.Demand,
            this.Proposition,
            this.owner_uname});
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
            this.bunifuDataGridView1.DataSource = this.franchiseApplicationBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(12, 12);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(747, 346);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pROJDataSet
            // 
            this.pROJDataSet.DataSetName = "PROJDataSet";
            this.pROJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJDataSetBindingSource
            // 
            this.pROJDataSetBindingSource.DataSource = this.pROJDataSet;
            this.pROJDataSetBindingSource.Position = 0;
            // 
            // franchiseApplicationBindingSource
            // 
            this.franchiseApplicationBindingSource.DataMember = "Franchise_Application";
            this.franchiseApplicationBindingSource.DataSource = this.pROJDataSetBindingSource;
            // 
            // franchise_ApplicationTableAdapter
            // 
            this.franchise_ApplicationTableAdapter.ClearBeforeFill = true;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.approve.CustomizableEdges = borderEdges3;
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges4;
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
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.Frozen = true;
            this.ID.HeaderText = "";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // App_Id
            // 
            this.App_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.App_Id.Frozen = true;
            this.App_Id.HeaderText = "ID";
            this.App_Id.MinimumWidth = 6;
            this.App_Id.Name = "App_Id";
            this.App_Id.ReadOnly = true;
            this.App_Id.Width = 125;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Location.Frozen = true;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 125;
            // 
            // Demand
            // 
            this.Demand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Demand.Frozen = true;
            this.Demand.HeaderText = "Amount";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            this.Demand.Width = 125;
            // 
            // Proposition
            // 
            this.Proposition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Proposition.Frozen = true;
            this.Proposition.HeaderText = "Proposition";
            this.Proposition.MinimumWidth = 6;
            this.Proposition.Name = "Proposition";
            this.Proposition.ReadOnly = true;
            this.Proposition.Width = 125;
            // 
            // owner_uname
            // 
            this.owner_uname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.owner_uname.Frozen = true;
            this.owner_uname.HeaderText = "Owner";
            this.owner_uname.MinimumWidth = 6;
            this.owner_uname.Name = "owner_uname";
            this.owner_uname.ReadOnly = true;
            this.owner_uname.Width = 125;
            // 
            // requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.bunifuDataGridView1);
            this.DoubleBuffered = true;
            this.Name = "requests";
            this.Text = "Applications";
            this.Load += new System.EventHandler(this.requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franchiseApplicationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.BindingSource pROJDataSetBindingSource;
        private PROJDataSet pROJDataSet;
        private System.Windows.Forms.BindingSource franchiseApplicationBindingSource;
        private PROJDataSetTableAdapters.Franchise_ApplicationTableAdapter franchise_ApplicationTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton approve;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewLinkColumn Proposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_uname;
    }
}