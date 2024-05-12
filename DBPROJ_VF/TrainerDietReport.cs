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
    public partial class TrainerDietReport : Form
    {   
        string userID;
        public TrainerDietReport(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TrainerMenu"].Show();
        }
        private void TrainerDietReport_Load(object sender, EventArgs e)
        {
            // Assuming there's a relationship between trainers and members based on a foreign key column like 'trainerID'
            // Adjust the SQL query or LINQ expression accordingly

            // Example SQL query:
            string query = @"
        SELECT    UName,FName, LName , DOB , wieght , reg_date  , goal ,gender ,subscription, height , workplan , dietplan

        FROM Gym_Member 
        WHERE trnUName = @TrainerID;";

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TrainerID", userID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    advancedDataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.gymMemberBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            // what
            this.gymMemberBindingSource.Filter = this.advancedDataGridView1.FilterString;

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
