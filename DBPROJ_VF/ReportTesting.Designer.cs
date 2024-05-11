namespace DBPROJ_VF
{
    partial class ReportTesting
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
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.projectfinalDataSet = new DBPROJ_VF.ProjectfinalDataSet();
            this.gymMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gym_MemberTableAdapter = new DBPROJ_VF.ProjectfinalDataSetTableAdapters.Gym_MemberTableAdapter();
            this.uNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wieghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trnUNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToAddRows = false;
            this.advancedDataGridView.AutoGenerateColumns = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNameDataGridViewTextBoxColumn,
            this.pWordDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.wieghtDataGridViewTextBoxColumn,
            this.regdateDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.subscriptionDataGridViewTextBoxColumn,
            this.trnUNameDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.gymIDDataGridViewTextBoxColumn,
            this.workPlanDataGridViewTextBoxColumn,
            this.dietPlanDataGridViewTextBoxColumn});
            this.advancedDataGridView.DataSource = this.gymMemberBindingSource;
            this.advancedDataGridView.DateWithTime = false;
            this.advancedDataGridView.Location = new System.Drawing.Point(2, 26);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.RowHeadersWidth = 51;
            this.advancedDataGridView.RowTemplate.Height = 24;
            this.advancedDataGridView.Size = new System.Drawing.Size(1398, 335);
            this.advancedDataGridView.TabIndex = 0;
            this.advancedDataGridView.TimeFilter = false;
            this.advancedDataGridView.SortStringChanged += new System.EventHandler(this.advancedDataGridView_SortStringChanged);
            this.advancedDataGridView.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_FilterStringChanged);
            this.advancedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(476, 379);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total rows ; 0 ";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // projectfinalDataSet
            // 
            this.projectfinalDataSet.DataSetName = "ProjectfinalDataSet";
            this.projectfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymMemberBindingSource
            // 
            this.gymMemberBindingSource.DataMember = "Gym_Member";
            this.gymMemberBindingSource.DataSource = this.projectfinalDataSet;
            // 
            // gym_MemberTableAdapter
            // 
            this.gym_MemberTableAdapter.ClearBeforeFill = true;
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
            // pWordDataGridViewTextBoxColumn
            // 
            this.pWordDataGridViewTextBoxColumn.DataPropertyName = "pWord";
            this.pWordDataGridViewTextBoxColumn.HeaderText = "pWord";
            this.pWordDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pWordDataGridViewTextBoxColumn.Name = "pWordDataGridViewTextBoxColumn";
            this.pWordDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pWordDataGridViewTextBoxColumn.Width = 125;
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
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dOBDataGridViewTextBoxColumn.Width = 125;
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
            // trnUNameDataGridViewTextBoxColumn
            // 
            this.trnUNameDataGridViewTextBoxColumn.DataPropertyName = "trnUName";
            this.trnUNameDataGridViewTextBoxColumn.HeaderText = "trnUName";
            this.trnUNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.trnUNameDataGridViewTextBoxColumn.Name = "trnUNameDataGridViewTextBoxColumn";
            this.trnUNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.trnUNameDataGridViewTextBoxColumn.Width = 125;
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
            // gymIDDataGridViewTextBoxColumn
            // 
            this.gymIDDataGridViewTextBoxColumn.DataPropertyName = "gym_ID";
            this.gymIDDataGridViewTextBoxColumn.HeaderText = "gym_ID";
            this.gymIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gymIDDataGridViewTextBoxColumn.Name = "gymIDDataGridViewTextBoxColumn";
            this.gymIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gymIDDataGridViewTextBoxColumn.Width = 125;
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
            // ReportTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.advancedDataGridView);
            this.Name = "ReportTesting";
            this.Text = "Advanced data grid";
            this.Load += new System.EventHandler(this.ReportTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectfinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMemberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private System.Windows.Forms.Label lblTotal;
        private ProjectfinalDataSet projectfinalDataSet;
        private System.Windows.Forms.BindingSource gymMemberBindingSource;
        private ProjectfinalDataSetTableAdapters.Gym_MemberTableAdapter gym_MemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wieghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trnUNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietPlanDataGridViewTextBoxColumn;
    }
}