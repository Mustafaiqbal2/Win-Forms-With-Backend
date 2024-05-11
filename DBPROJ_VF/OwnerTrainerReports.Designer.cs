namespace DBPROJ_VF
{
    partial class OwnerTrainerReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerTrainerReports));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.view = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trainer_report = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trainer_report)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.AllowAnimations = true;
            this.view.AllowMouseEffects = true;
            this.view.AllowToggling = false;
            this.view.AnimationSpeed = 200;
            this.view.AutoGenerateColors = false;
            this.view.AutoRoundBorders = false;
            this.view.AutoSizeLeftIcon = true;
            this.view.AutoSizeRightIcon = true;
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view.BackgroundImage")));
            this.view.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.ButtonText = "View";
            this.view.ButtonTextMarginLeft = 0;
            this.view.ColorContrastOnClick = 45;
            this.view.ColorContrastOnHover = 45;
            this.view.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.view.CustomizableEdges = borderEdges1;
            this.view.DialogResult = System.Windows.Forms.DialogResult.None;
            this.view.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.view.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.view.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.view.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.view.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.view.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.view.IconMarginLeft = 11;
            this.view.IconPadding = 10;
            this.view.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.view.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.view.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.view.IconSize = 25;
            this.view.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.view.IdleBorderRadius = 1;
            this.view.IdleBorderThickness = 1;
            this.view.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.view.IdleIconLeftImage = null;
            this.view.IdleIconRightImage = null;
            this.view.IndicateFocus = false;
            this.view.Location = new System.Drawing.Point(558, 28);
            this.view.Name = "view";
            this.view.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.view.OnDisabledState.BorderRadius = 1;
            this.view.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.OnDisabledState.BorderThickness = 1;
            this.view.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.view.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.view.OnDisabledState.IconLeftImage = null;
            this.view.OnDisabledState.IconRightImage = null;
            this.view.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.view.onHoverState.BorderRadius = 1;
            this.view.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.onHoverState.BorderThickness = 1;
            this.view.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.view.onHoverState.ForeColor = System.Drawing.Color.White;
            this.view.onHoverState.IconLeftImage = null;
            this.view.onHoverState.IconRightImage = null;
            this.view.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.view.OnIdleState.BorderRadius = 1;
            this.view.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.OnIdleState.BorderThickness = 1;
            this.view.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.view.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.view.OnIdleState.IconLeftImage = null;
            this.view.OnIdleState.IconRightImage = null;
            this.view.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.view.OnPressedState.BorderRadius = 1;
            this.view.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.view.OnPressedState.BorderThickness = 1;
            this.view.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.view.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.view.OnPressedState.IconLeftImage = null;
            this.view.OnPressedState.IconRightImage = null;
            this.view.Size = new System.Drawing.Size(69, 22);
            this.view.TabIndex = 5;
            this.view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.view.TextMarginLeft = 0;
            this.view.TextPadding = new System.Windows.Forms.Padding(0);
            this.view.UseDefaultRadiusAndThickness = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trainer Reports ";
            // 
            // trainer_report
            // 
            this.trainer_report.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.trainer_report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.trainer_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainer_report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainer_report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.trainer_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trainer_report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.trainer_report.ColumnHeadersHeight = 40;
            this.trainer_report.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.trainer_report.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.trainer_report.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.trainer_report.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trainer_report.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.trainer_report.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.trainer_report.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.trainer_report.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.trainer_report.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.trainer_report.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.trainer_report.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.trainer_report.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.trainer_report.CurrentTheme.Name = null;
            this.trainer_report.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.trainer_report.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.trainer_report.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.trainer_report.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trainer_report.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trainer_report.DefaultCellStyle = dataGridViewCellStyle3;
            this.trainer_report.EnableHeadersVisualStyles = false;
            this.trainer_report.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.trainer_report.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.trainer_report.HeaderBgColor = System.Drawing.Color.Empty;
            this.trainer_report.HeaderForeColor = System.Drawing.Color.White;
            this.trainer_report.Location = new System.Drawing.Point(12, 73);
            this.trainer_report.Name = "trainer_report";
            this.trainer_report.RowHeadersVisible = false;
            this.trainer_report.RowHeadersWidth = 51;
            this.trainer_report.RowTemplate.Height = 40;
            this.trainer_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainer_report.Size = new System.Drawing.Size(814, 376);
            this.trainer_report.TabIndex = 3;
            this.trainer_report.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.trainer_report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainer_report_CellContentClick);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Experience Top to bottom ",
            "Rating"});
            this.comboBox.Location = new System.Drawing.Point(12, 26);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(202, 24);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // OwnerTrainerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 461);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainer_report);
            this.Name = "OwnerTrainerReports";
            this.Text = "OwnerTrainerReports";
            this.Load += new System.EventHandler(this.OwnerTrainerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainer_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton view;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView trainer_report;
        private System.Windows.Forms.ComboBox comboBox;
    }
}