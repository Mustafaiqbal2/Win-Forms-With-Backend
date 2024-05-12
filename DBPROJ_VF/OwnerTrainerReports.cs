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
    public partial class OwnerTrainerReports : Form
    {
    string UserID;
        

        public OwnerTrainerReports(string userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void OwnerTrainerReports_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Owner"].Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
    t.UName AS 'Trainer Username',
    t.fName AS 'First Name',
    t.lName AS 'Last Name',
    t.DOB AS 'Date of Birth',
    t.exp_lvl AS 'Experience Level',
    t.rating AS 'Rating',
    t.startDate AS 'Start Date',
    g.location AS 'Gym Location'
FROM 
    Trainer t
LEFT JOIN 
    Gym g ON t.gym_ID = g.id
WHERE 
    g.ownerUName = @UserID; -- Replace 'current_gym_owner_username' with the actual username of the current gym owner;";

            try
            {



                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    trainer_report.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void trainer_report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
