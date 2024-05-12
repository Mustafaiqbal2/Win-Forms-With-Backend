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
    public partial class AdminComparison : Form
    {
        public AdminComparison()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Admin"].Show();
        }
        private void AdminComparison_Load(object sender, EventArgs e)
        {

        }

        private void MachineSubmit_Click(object sender, EventArgs e)
        {

            //done
            string query = @"
        SELECT 
    g.location AS 'Gym Location',
    COUNT(gm.UName) AS 'Total Members'
FROM 
    Gym g
LEFT JOIN 
    Gym_Member gm ON g.id = gm.gym_ID
WHERE 
    gm.reg_date >= DATEADD(MONTH, -6, GETDATE()) -- Members registered in the past 6 months
GROUP BY 
    g.location;
";

            using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //  command.Parameters.AddWithValue("@CurrentID", userID); // Assuming CurrentID is the ID of the current member
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                reportDataGridView.DataSource = table;
            }
        }
    }
}
