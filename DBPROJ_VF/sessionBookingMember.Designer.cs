namespace DBPROJ_VF
{
    partial class sessionBookingMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sessionBookingMember));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTimePickerMem = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMem = new System.Windows.Forms.DateTimePicker();
            this.SessionDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.AppointmentSubmitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Schedule A Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(259, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(259, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select End Time";
            // 
            // StartTimePickerMem
            // 
            this.StartTimePickerMem.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePickerMem.Location = new System.Drawing.Point(425, 129);
            this.StartTimePickerMem.Name = "StartTimePickerMem";
            this.StartTimePickerMem.ShowUpDown = true;
            this.StartTimePickerMem.Size = new System.Drawing.Size(118, 22);
            this.StartTimePickerMem.TabIndex = 11;
            // 
            // dateTimePickerMem
            // 
            this.dateTimePickerMem.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerMem.Location = new System.Drawing.Point(425, 169);
            this.dateTimePickerMem.Name = "dateTimePickerMem";
            this.dateTimePickerMem.ShowUpDown = true;
            this.dateTimePickerMem.Size = new System.Drawing.Size(118, 22);
            this.dateTimePickerMem.TabIndex = 12;
            // 
            // SessionDropdown
            // 
            this.SessionDropdown.BackColor = System.Drawing.Color.Transparent;
            this.SessionDropdown.BackgroundColor = System.Drawing.Color.White;
            this.SessionDropdown.BorderColor = System.Drawing.Color.Silver;
            this.SessionDropdown.BorderRadius = 1;
            this.SessionDropdown.Color = System.Drawing.Color.Silver;
            this.SessionDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.SessionDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SessionDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SessionDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SessionDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SessionDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.SessionDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SessionDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.SessionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SessionDropdown.FillDropDown = true;
            this.SessionDropdown.FillIndicator = false;
            this.SessionDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SessionDropdown.ForeColor = System.Drawing.Color.Black;
            this.SessionDropdown.FormattingEnabled = true;
            this.SessionDropdown.Icon = null;
            this.SessionDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SessionDropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.SessionDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SessionDropdown.ItemBackColor = System.Drawing.Color.White;
            this.SessionDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.SessionDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.SessionDropdown.ItemHeight = 26;
            this.SessionDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.SessionDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.SessionDropdown.ItemTopMargin = 3;
            this.SessionDropdown.Location = new System.Drawing.Point(271, 234);
            this.SessionDropdown.Name = "SessionDropdown";
            this.SessionDropdown.Size = new System.Drawing.Size(260, 32);
            this.SessionDropdown.TabIndex = 13;
            this.SessionDropdown.Text = "Select Trainer";
            this.SessionDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SessionDropdown.TextLeftMargin = 5;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AppointmentSubmitButton.CustomizableEdges = borderEdges1;
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
            this.AppointmentSubmitButton.Location = new System.Drawing.Point(329, 290);
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
            this.AppointmentSubmitButton.TabIndex = 14;
            this.AppointmentSubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppointmentSubmitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppointmentSubmitButton.TextMarginLeft = 0;
            this.AppointmentSubmitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AppointmentSubmitButton.UseDefaultRadiusAndThickness = true;
            // 
            // sessionBookingMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBPROJ_VF.Properties.Resources.jeremy_bishop_G9i_plbfDgk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppointmentSubmitButton);
            this.Controls.Add(this.SessionDropdown);
            this.Controls.Add(this.dateTimePickerMem);
            this.Controls.Add(this.StartTimePickerMem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "sessionBookingMember";
            this.Text = "Session Booking";
            this.Load += new System.EventHandler(this.sessionBookingMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartTimePickerMem;
        private System.Windows.Forms.DateTimePicker dateTimePickerMem;
        private Bunifu.UI.WinForms.BunifuDropdown SessionDropdown;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AppointmentSubmitButton;
    }
}