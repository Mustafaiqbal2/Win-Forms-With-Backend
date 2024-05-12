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
    public partial class MemberDeitPlanSelect : Form
    {
        string userID; 

        public void gridRefresh()
        {
            string dietID= DietSelectDropDown.SelectedValue.ToString();
            string DietDetailQuery = "SELECT * FROM Diet_Plan " +
                                    "WHERE name = @name";
           
            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(DietDetailQuery, connection))
            {
                command.Parameters.AddWithValue("@name", dietID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            ///////////////////////
            connection.Close();
            bunifuDataGridView1.DataSource = gymMemberDataTable;
        }
        public MemberDeitPlanSelect(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            //initialize dropdown
            string DietPlanQuery = "SELECT * FROM Diet_Plan m ";
            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(DietPlanQuery, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            connection.Close();
            DietSelectDropDown.DataSource = gymMemberDataTable;
        //    gridRefresh();
        }

        private void MemberDeitPlanSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Diet_Plan' table. You can move, or remove it, as needed.
            this.diet_PlanTableAdapter1.Fill(this.projectfinalDataSet.Diet_Plan);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            con.Open();
            //update the diet plan of the user
            string planID = "";
            string DietPlanQuery = "SELECT id FROM Diet_Plan m WHERE name = @name";
            SqlCommand cmd = new SqlCommand(DietPlanQuery, con);
            cmd.Parameters.AddWithValue("@name", DietSelectDropDown.SelectedValue.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                planID = reader["id"].ToString();
            }


            string query4 = "UPDATE Gym_Member SET dietPlan = @PlanID WHERE UName = @memberID";
            SqlCommand cmdE = new SqlCommand(query4, con);
            cmdE.Parameters.AddWithValue("@PlanID", planID);
            cmdE.Parameters.AddWithValue("@memberID", userID);
            cmdE.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Diet Plan Updated");
        }

        private void DietSelectDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridRefresh();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            id AS 'Plan ID',
            name AS 'Workout Plan Name'
        FROM 
            Workout_Plan;";

            try
            {



                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
         
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    bunifuDataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
