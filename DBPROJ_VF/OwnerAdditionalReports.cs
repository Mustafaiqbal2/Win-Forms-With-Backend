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
    public partial class OwnerAdditionalReports : Form
    {   
        string userID;
        public OwnerAdditionalReports(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void newmemReport_Click(object sender, EventArgs e)
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
            GYM_Attendance gma ON gm.UName = gma.memberUName
        LEFT JOIN 
            Gym g ON gm.gym_ID = g.id
        WHERE 
            DATEDIFF(MONTH, gm.reg_date, GETDATE()) <= 3
            AND g.ownerUName = @UserID;";

            try
            {



                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    reportDataGridView.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void MachineSubmit_Click(object sender, EventArgs e)
        {
            string machine1 = MachineDropdown.SelectedValue.ToString();
            string day = DayDropdown.Text;  // Replace "your_gym_id" with the actual gym ID
            string query = @"
           SELECT COUNT(DISTINCT gm.uname) AS member_count
        FROM Gym_Member gm
            WHERE gm.workPlan IN (
            SELECT DISTINCT EID.planFK
            FROM ExerciseInDay AS EID
            JOIN Exercise AS E ON EID.exerciseName = E.name
            WHERE E.machine = @machine1 AND EID.dayFK = @day 
);
                ";

            try
            {



                using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@day", day);
                    command.Parameters.AddWithValue("@machine1", machine1);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    reportDataGridView.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Owner"].Show();
        }

        private void OwnerAdditionalReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.exercise' table. You can move, or remove it, as needed.
            this.exerciseTableAdapter.Fill(this.projectfinalDataSet.exercise);

        }
    }
}
