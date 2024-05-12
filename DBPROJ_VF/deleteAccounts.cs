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
    public partial class deleteAccounts : Form
    {
        string userID;
        public deleteAccounts(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void deleteAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.projectfinalDataSet.Trainer);
            // TODO: This line of code loads data into the 'projectfinalDataSet.Gym_Member' table. You can move, or remove it, as needed.
            this.gym_MemberTableAdapter1.Fill(this.projectfinalDataSet.Gym_Member);
            string trainerQuery = "SELECT * FROM Trainer " +
                                 "JOIN Gym g ON g.id = gym_ID " +
                                 "WHERE g.ownerUName = @UserID";

            // Define your custom SQL query for Gym_Member table
            string gymMemberQuery = "SELECT * FROM Gym_Member " +
                                    "JOIN Gym g ON g.id = gym_ID " +
                                    "WHERE g.ownerUName = @UserID";
            DataTable trainerDataTable = new DataTable();
            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Trainer query
            using (SqlCommand command = new SqlCommand(trainerQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = command.ExecuteReader();
                trainerDataTable.Load(reader);
            }

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(gymMemberQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }

            connection.Close();

            bunifuDataGridView1.DataSource = gymMemberDataTable;
            bunifuDataGridView2.DataSource = trainerDataTable;
        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                    this.gym_MemberTableAdapter1.Fill(this.projectfinalDataSet.Gym_Member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Owner"].Show();
        }
        bool convertToBool(string val)
        {
            if (val == "1") 
            { return true;}
            else
            { return false; }
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM Gym_Member WHERE UName = @id";
            string query2 = "DELETE FROM Trainer WHERE UName = @id";
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();
            foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
            {
                // Check if the checkbox in the first column is checked
                if (row.Cells[0].Value != null && convertToBool(row.Cells[0].Value.ToString()))
                {
                    // Get the userID from the second column
                    string userID = row.Cells[1].Value.ToString();
                    // Delete the row from the DataGridView
                    bunifuDataGridView1.Rows.Remove(row);

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@id", userID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            foreach (DataGridViewRow row in bunifuDataGridView2.Rows)
            {
                // Check if the checkbox in the first column is checked
                if (row.Cells[0].Value != null && convertToBool(row.Cells[0].Value.ToString()))
                {
                    // Get the userID from the second column
                    string userID = row.Cells[1].Value.ToString();
                    // Delete the row from the DataGridView
                    bunifuDataGridView2.Rows.Remove(row);

                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@id", userID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            connection.Close();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
