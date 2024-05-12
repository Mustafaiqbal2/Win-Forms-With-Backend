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
    public partial class requests : Form
    {
        string userID;
        public requests(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void requests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Franchise_Application' table. You can move, or remove it, as needed.
            this.franchise_ApplicationTableAdapter.Fill(this.projectfinalDataSet.Franchise_Application);

        }

        private void applications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string prop = applications.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                MessageBox.Show(prop);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Admin"].Show();
        }
        bool convertToBool(string val)
        {
            if (val == "1")
            { return true; }
            else
            { return false; }
        }
        private void approve_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM Franchise_Application WHERE id = @id";
            string query2 = "INSERT INTO Gym(location,ownerUName) VALUES(@location,@owner)";
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();
            foreach (DataGridViewRow row in applications.Rows)
            {
                // Check if the checkbox in the first column is checked
                if (row.Cells[0].Value != null && convertToBool(row.Cells[0].Value.ToString()))
                {
                    // Get the userID from the second column
                    string userID = row.Cells[1].Value.ToString();
                    string location = row.Cells[2].Value.ToString();
                    string owner = row.Cells[5].Value.ToString();
                    // Delete the row from the DataGridView
                    applications.Rows.Remove(row);

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@id", userID);
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@location", location);
                        command.Parameters.AddWithValue("@owner", owner);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void reject_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM Franchise_Application WHERE id = @id";
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();
            foreach (DataGridViewRow row in applications.Rows)
            {
                // Check if the checkbox in the first column is checked
                if (row.Cells[0].Value != null && convertToBool(row.Cells[0].Value.ToString()))
                {
                    // Get the userID from the second column
                    string userID = row.Cells[1].Value.ToString();
                    // Delete the row from the DataGridView
                    applications.Rows.Remove(row);

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@id", userID);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
