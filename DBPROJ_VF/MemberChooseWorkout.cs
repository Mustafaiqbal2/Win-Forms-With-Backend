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
    public partial class MemberChooseWorkout : Form
    {
        string userID;
        public void gridRefresh()
        {
            string workID = WorkSelectDropDown.SelectedValue.ToString();
            string DietDetailQuery = "SELECT * FROM Workout_Plan " +
                                    "WHERE name = @name";

            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(DietDetailQuery, connection))
            {
                command.Parameters.AddWithValue("@name", workID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            ///////////////////////
            connection.Close();
            bunifuDataGridView1.DataSource = gymMemberDataTable;
        }
        public MemberChooseWorkout(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            string WorkPlanQuery = "SELECT * FROM Workout_Plan m ";
            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(WorkPlanQuery, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            connection.Close();
            WorkSelectDropDown.DataSource = gymMemberDataTable;
            //gridRefresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }

        private void MemberChooseWorkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Workout_Plan' table. You can move, or remove it, as needed.
            this.workout_PlanTableAdapter.Fill(this.projectfinalDataSet.Workout_Plan);
            // TODO: This line of code loads data into the 'projectfinalDataSet.Workout_Plan' table. You can move, or remove it, as needed.

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridRefresh();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            con.Open();
            //update the diet plan of the user
            string planID = "";
            string DietPlanQuery = "SELECT id FROM Workout_Plan m WHERE name = @name";
            SqlCommand cmd = new SqlCommand(DietPlanQuery, con);
            cmd.Parameters.AddWithValue("@name", WorkSelectDropDown.SelectedValue.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                planID = reader["id"].ToString();
            }


            string query4 = "UPDATE Gym_Member SET workPlan = @PlanID WHERE UName = @memberID";
            SqlCommand cmdE = new SqlCommand(query4, con);
            cmdE.Parameters.AddWithValue("@PlanID", planID);
            cmdE.Parameters.AddWithValue("@memberID", userID);
            cmdE.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Diet Plan Updated");
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
