using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBPROJ_VF
{
    public partial class gym_manage : Form
    {
        string userID;
        public gym_manage(string username)
        {
            InitializeComponent();
            bunifuDataGridView1.AllowUserToAddRows = false;
            bunifuDataGridView1.AllowUserToDeleteRows = false;
            userID = username;
        }

        private void gym_manage_Load(object sender, EventArgs e)
        {
            this.gymTableAdapter.Fill(this.pROJDataSet.Gym);
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
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
        private void revoke_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM Gym WHERE id = @id";
            SqlConnection connection = new SqlConnection("Data Source=172.23.129.23;Initial Catalog=PROJ;User ID=Boys;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
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
        }
    }
}
