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
    public partial class OwnerMemberReport : Form
    {
        string userID;
        public OwnerMemberReport(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void OwnerMemberReport_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
    gm.UName AS 'Member Username',
    gm.fName AS 'First Name',
    gm.lName AS 'Last Name',
    gm.DOB AS 'Date of Birth',
    gm.reg_date AS 'Registration Date',
    DATEDIFF(MONTH, gm.reg_date, GETDATE()) AS 'Membership Duration (Months)',
    gm.subscription AS 'Membership Type',
    gm.goal AS 'Member Goal',
    wp.name AS 'Workout Plan',
    dp.name AS 'Diet Plan',
    gma.attendance AS 'Attendance Percentage'
FROM 
    Gym_Member gm
LEFT JOIN 
    Workout_Plan wp ON gm.workPlan = wp.id
LEFT JOIN 
    Diet_Plan dp ON gm.dietPlan = dp.id
LEFT JOIN 
    GYM_Attendance gma ON gm.UName = gma.memberUName;
";

            try
            {



                using (SqlConnection connection = new SqlConnection("Data Source=172.23.129.23;Initial Catalog=PROJ;User ID=Boys;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    memberreport.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void memberreport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Owner"].Show();
        }

    }
}
