namespace DBPROJ_VF
{
    partial class gym_manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gym_manage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pROJDataSet = new DBPROJ_VF.PROJDataSet();
            this.pROJDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymTableAdapter = new DBPROJ_VF.PROJDataSetTableAdapters.GymTableAdapter();
            this.revoke = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerUNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noMembersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTrainersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.idDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.ownerUNameDataGridViewTextBoxColumn,
            this.noMembersDataGridViewTextBoxColumn,
            this.noTrainersDataGridViewTextBoxColumn,
            this.financesDataGridViewTextBoxColumn});
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
            this.bunifuDataGridView1.DataSource = this.gymBindingSource;
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
            this.bunifuDataGridView1.Location = new System.Drawing.Point(-3, 26);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(820, 316);
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
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "Gym";
            this.gymBindingSource.DataSource = this.pROJDataSetBindingSource;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
            // 
            // revoke
            // 
            this.revoke.AllowAnimations = true;
            this.revoke.AllowMouseEffects = true;
            this.revoke.AllowToggling = false;
            this.revoke.AnimationSpeed = 200;
            this.revoke.AutoGenerateColors = false;
            this.revoke.AutoRoundBorders = true;
            this.revoke.AutoSizeLeftIcon = true;
            this.revoke.AutoSizeRightIcon = true;
            this.revoke.BackColor = System.Drawing.Color.Transparent;
            this.revoke.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.revoke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("revoke.BackgroundImage")));
            this.revoke.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.revoke.ButtonText = "Revoke Selected";
            this.revoke.ButtonTextMarginLeft = 0;
            this.revoke.ColorContrastOnClick = 45;
            this.revoke.ColorContrastOnHover = 45;
            this.revoke.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.revoke.CustomizableEdges = borderEdges1;
            this.revoke.DialogResult = System.Windows.Forms.DialogResult.None;
            this.revoke.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.revoke.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.revoke.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.revoke.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.revoke.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.revoke.ForeColor = System.Drawing.Color.White;
            this.revoke.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revoke.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.revoke.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.revoke.IconMarginLeft = 11;
            this.revoke.IconPadding = 10;
            this.revoke.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revoke.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.revoke.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.revoke.IconSize = 25;
            this.revoke.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.revoke.IdleBorderRadius = 37;
            this.revoke.IdleBorderThickness = 1;
            this.revoke.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.revoke.IdleIconLeftImage = null;
            this.revoke.IdleIconRightImage = null;
            this.revoke.IndicateFocus = false;
            this.revoke.Location = new System.Drawing.Point(327, 358);
            this.revoke.Name = "revoke";
            this.revoke.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.revoke.OnDisabledState.BorderRadius = 1;
            this.revoke.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.revoke.OnDisabledState.BorderThickness = 1;
            this.revoke.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.revoke.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.revoke.OnDisabledState.IconLeftImage = null;
            this.revoke.OnDisabledState.IconRightImage = null;
            this.revoke.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.revoke.onHoverState.BorderRadius = 1;
            this.revoke.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.revoke.onHoverState.BorderThickness = 1;
            this.revoke.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.revoke.onHoverState.ForeColor = System.Drawing.Color.White;
            this.revoke.onHoverState.IconLeftImage = null;
            this.revoke.onHoverState.IconRightImage = null;
            this.revoke.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.revoke.OnIdleState.BorderRadius = 1;
            this.revoke.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.revoke.OnIdleState.BorderThickness = 1;
            this.revoke.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.revoke.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.revoke.OnIdleState.IconLeftImage = null;
            this.revoke.OnIdleState.IconRightImage = null;
            this.revoke.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.revoke.OnPressedState.BorderRadius = 1;
            this.revoke.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.revoke.OnPressedState.BorderThickness = 1;
            this.revoke.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.revoke.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.revoke.OnPressedState.IconLeftImage = null;
            this.revoke.OnPressedState.IconRightImage = null;
            this.revoke.Size = new System.Drawing.Size(150, 39);
            this.revoke.TabIndex = 1;
            this.revoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revoke.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.revoke.TextMarginLeft = 0;
            this.revoke.TextPadding = new System.Windows.Forms.Padding(0);
            this.revoke.UseDefaultRadiusAndThickness = true;
            // 
            // checkBox
            // 
            this.checkBox.DataPropertyName = "id";
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // ownerUNameDataGridViewTextBoxColumn
            // 
            this.ownerUNameDataGridViewTextBoxColumn.DataPropertyName = "ownerUName";
            this.ownerUNameDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerUNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerUNameDataGridViewTextBoxColumn.Name = "ownerUNameDataGridViewTextBoxColumn";
            // 
            // noMembersDataGridViewTextBoxColumn
            // 
            this.noMembersDataGridViewTextBoxColumn.DataPropertyName = "noMembers";
            this.noMembersDataGridViewTextBoxColumn.HeaderText = "Members";
            this.noMembersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noMembersDataGridViewTextBoxColumn.Name = "noMembersDataGridViewTextBoxColumn";
            // 
            // noTrainersDataGridViewTextBoxColumn
            // 
            this.noTrainersDataGridViewTextBoxColumn.DataPropertyName = "noTrainers";
            this.noTrainersDataGridViewTextBoxColumn.HeaderText = "Trainers";
            this.noTrainersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTrainersDataGridViewTextBoxColumn.Name = "noTrainersDataGridViewTextBoxColumn";
            // 
            // financesDataGridViewTextBoxColumn
            // 
            this.financesDataGridViewTextBoxColumn.DataPropertyName = "finances";
            this.financesDataGridViewTextBoxColumn.HeaderText = "Finances";
            this.financesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.financesDataGridViewTextBoxColumn.Name = "financesDataGridViewTextBoxColumn";
            // 
            // gym_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 590);
            this.Controls.Add(this.revoke);
            this.Controls.Add(this.bunifuDataGridView1);
            this.DoubleBuffered = true;
            this.Name = "gym_manage";
            this.Text = "gym_manage";
            this.Load += new System.EventHandler(this.gym_manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.BindingSource pROJDataSetBindingSource;
        private PROJDataSet pROJDataSet;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private PROJDataSetTableAdapters.GymTableAdapter gymTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton revoke;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerUNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMembersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTrainersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn financesDataGridViewTextBoxColumn;
    }
}