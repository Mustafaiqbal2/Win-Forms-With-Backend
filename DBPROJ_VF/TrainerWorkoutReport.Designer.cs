namespace DBPROJ_VF
{
    partial class TrainerWorkoutReport
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
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.uNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wieghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectfinalDataSet = new DBPROJ_VF.ProjectfinalDataSet();
            this.gym_MemberTableAdapter = new DBPROJ_VF.ProjectfinalDataSetTableAdapters.Gym_MemberTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.trainerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.trainerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.wieghtDataGridViewTextBoxColumn,
            this.regdateDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.subscriptionDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.workPlanDataGridViewTextBoxColumn,
            this.dietPlanDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.gymMemberBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 30);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1267, 382);
            this.advancedDataGridView1.TabIndex = 1;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            // 
            // uNameDataGridViewTextBoxColumn
            // 
            this.uNameDataGridViewTextBoxColumn.DataPropertyName = "UName";
            this.uNameDataGridViewTextBoxColumn.HeaderText = "UName";
            this.uNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.uNameDataGridViewTextBoxColumn.Name = "uNameDataGridViewTextBoxColumn";
            this.uNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.uNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.lNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // wieghtDataGridViewTextBoxColumn
            // 
            this.wieghtDataGridViewTextBoxColumn.DataPropertyName = "wieght";
            this.wieghtDataGridViewTextBoxColumn.HeaderText = "wieght";
            this.wieghtDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.wieghtDataGridViewTextBoxColumn.Name = "wieghtDataGridViewTextBoxColumn";
            this.wieghtDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.wieghtDataGridViewTextBoxColumn.Width = 125;
            // 
            // regdateDataGridViewTextBoxColumn
            // 
            this.regdateDataGridViewTextBoxColumn.DataPropertyName = "reg_date";
            this.regdateDataGridViewTextBoxColumn.HeaderText = "reg_date";
            this.regdateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.regdateDataGridViewTextBoxColumn.Name = "regdateDataGridViewTextBoxColumn";
            this.regdateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.regdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // goalDataGridViewTextBoxColumn
            // 
            this.goalDataGridViewTextBoxColumn.DataPropertyName = "goal";
            this.goalDataGridViewTextBoxColumn.HeaderText = "goal";
            this.goalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.goalDataGridViewTextBoxColumn.Name = "goalDataGridViewTextBoxColumn";
            this.goalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.goalDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // subscriptionDataGridViewTextBoxColumn
            // 
            this.subscriptionDataGridViewTextBoxColumn.DataPropertyName = "subscription";
            this.subscriptionDataGridViewTextBoxColumn.HeaderText = "subscription";
            this.subscriptionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.subscriptionDataGridViewTextBoxColumn.Name = "subscriptionDataGridViewTextBoxColumn";
            this.subscriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.subscriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heightDataGridViewTextBoxColumn.Width = 125;
            // 
            // workPlanDataGridViewTextBoxColumn
            // 
            this.workPlanDataGridViewTextBoxColumn.DataPropertyName = "workPlan";
            this.workPlanDataGridViewTextBoxColumn.HeaderText = "workPlan";
            this.workPlanDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.workPlanDataGridViewTextBoxColumn.Name = "workPlanDataGridViewTextBoxColumn";
            this.workPlanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.workPlanDataGridViewTextBoxColumn.Width = 125;
            // 
            // dietPlanDataGridViewTextBoxColumn
            // 
            this.dietPlanDataGridViewTextBoxColumn.DataPropertyName = "dietPlan";
            this.dietPlanDataGridViewTextBoxColumn.HeaderText = "dietPlan";
            this.dietPlanDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dietPlanDataGridViewTextBoxColumn.Name = "dietPlanDataGridViewTextBoxColumn";
            this.dietPlanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dietPlanDataGridViewTextBoxColumn.Width = 125;
            // 
            // gymMemberBindingSource
            // 
            this.gymMemberBindingSource.DataMember = "Gym_Member";
            this.gymMemberBindingSource.DataSource = this.projectfinalDataSet;
            // 
            // projectfinalDataSet
            // 
            this.projectfinalDataSet.DataSetName = "ProjectfinalDataSet";
            this.projectfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gym_MemberTableAdapter
            // 
            this.gym_MemberTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainerIDToolStripLabel,
            this.trainerIDToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1317, 27);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // trainerIDToolStripLabel
            // 
            this.trainerIDToolStripLabel.Name = "trainerIDToolStripLabel";
            this.trainerIDToolStripLabel.Size = new System.Drawing.Size(72, 24);
            this.trainerIDToolStripLabel.Text = "TrainerID:";
            // 
            // trainerIDToolStripTextBox
            // 
            this.trainerIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trainerIDToolStripTextBox.Name = "trainerIDToolStripTextBox";
            this.trainerIDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // TrainerWorkoutReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 483);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.advancedDataGridView1);
            this.Name = "TrainerWorkoutReport";
            this.Text = "TrainerWorkoutReport";
            this.Load += new System.EventHandler(this.TrainerWorkoutReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private ProjectfinalDataSet projectfinalDataSet;
        private System.Windows.Forms.BindingSource gymMemberBindingSource;
        private ProjectfinalDataSetTableAdapters.Gym_MemberTableAdapter gym_MemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wieghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel trainerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox trainerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}