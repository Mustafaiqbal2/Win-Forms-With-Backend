using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJ_VF
{
    public partial class MemberMachineReport : Form
    {
        string userID;
               public MemberMachineReport(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }
        public void gridRefresh()
        {   
            if(bunifuDropdown1.SelectedValue == null)
            {
                return;
            }
            string machineID = bunifuDropdown1.SelectedValue.ToString();
            string WorkoutPlanQuery = @"
        SELECT DISTINCT wp.name AS 'Workout Plan'
        FROM Workout_Plan wp
        LEFT JOIN ExerciseInDay eid ON wp.id = eid.planFK
        LEFT JOIN Exercise e ON eid.exerciseName = e.name
        WHERE e.machine IS NULL OR e.machine != @machineID";

            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(WorkoutPlanQuery, connection))
            {
                command.Parameters.AddWithValue("@machineID", machineID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            ///////////////////////
            connection.Close();
            bunifuDataGridView.DataSource = gymMemberDataTable;
        }

        private void MemberMachineReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.exercise' table. You can move, or remove it, as needed.
            this.exerciseTableAdapter.Fill(this.projectfinalDataSet.exercise);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridRefresh();
        }

        private void bunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
