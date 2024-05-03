namespace DBPROJ_VF
{
    partial class MemberScheduleSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberScheduleSession));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentSubmitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Schedule A Session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(298, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(298, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Start Time";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(437, 263);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(118, 22);
            this.EndTimePicker.TabIndex = 9;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(437, 206);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(118, 22);
            this.StartTimePicker.TabIndex = 8;
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
            this.AppointmentSubmitButton.Location = new System.Drawing.Point(352, 329);
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
            this.AppointmentSubmitButton.Size = new System.Drawing.Size(142, 43);
            this.AppointmentSubmitButton.TabIndex = 14;
            this.AppointmentSubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppointmentSubmitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppointmentSubmitButton.TextMarginLeft = 0;
            this.AppointmentSubmitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AppointmentSubmitButton.UseDefaultRadiusAndThickness = true;
            this.AppointmentSubmitButton.Click += new System.EventHandler(this.AppointmentSubmitButton_Click);
            // 
            // MemberScheduleSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppointmentSubmitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Name = "MemberScheduleSession";
            this.Text = "MemberFeedback";
            this.Load += new System.EventHandler(this.MemberFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AppointmentSubmitButton;
    }
}