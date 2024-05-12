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
    public partial class TrainerAppointment : Form
    {
        string userID;
        public void refreshGrid()
        {
            string gymSessionQuery = "SELECT * FROM Training_Session m " +
                                    "JOIN Trainer t ON t.UName = m.TrainerUName " +
                                    "WHERE t.UName = @UserID";
            // TODO: This line of code loads data into the 'pROJDataSet.Training_Session' table. You can move, or remove it, as needed.
            string gymMemberQuery = "SELECT sessionID as ID,start_time as Start_Time, end_time as End_Time,MemberUName as Member FROM Training_Session m " +
                                    "JOIN Trainer t ON t.UName = TrainerUName " +
                                    "WHERE t.UName = @UserID";
            DataTable gymMemberDataTable = new DataTable();
            DataTable gymMemberDataTable2 = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(gymMemberQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            //////
            using (SqlCommand command = new SqlCommand(gymSessionQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable2.Load(reader);
            }
            DeleteSessionDropdown.DataSource = gymMemberDataTable2;
            ///////////////////////

            connection.Close();
            bunifuDataGridView1.DataSource = gymMemberDataTable;
        }
        public TrainerAppointment(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            
            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            string gymMemberQuery = "SELECT m.UName FROM Gym_Member m " +
                                   "JOIN Trainer t ON t.UName = trnUName " +
                                   "WHERE t.UName = @UserID";
            DataTable gymMemberDataTable2 = new DataTable();
            using (SqlCommand command = new SqlCommand(gymMemberQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable2.Load(reader);
            }
            ScheduleSessionDropDown.DataSource = gymMemberDataTable2;
            connection.Close();
            refreshGrid();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TrainerMenu"].Show();
        }

        private void TrainerAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Training_Session' table. You can move, or remove it, as needed.
            this.training_SessionTableAdapter1.Fill(this.projectfinalDataSet.Training_Session);
            // TODO: This line of code loads data into the 'projectfinalDataSet.Gym_Member' table. You can move, or remove it, as needed.
            this.gym_MemberTableAdapter1.Fill(this.projectfinalDataSet.Gym_Member);

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteSessionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteSessionButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();
            string deleteSessionQuery = "DELETE FROM Training_Session WHERE sessionID = @sessionID";
            using (SqlCommand command = new SqlCommand(deleteSessionQuery, connection))
            {
                command.Parameters.AddWithValue("@sessionID", DeleteSessionDropdown.SelectedValue);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Session Deleted");
            //DELETE FROM DATA GRID VIEW
            refreshGrid();
            connection.Close();
            
        }

        private void ScheduleSessionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentSubmitButton_Click(object sender, EventArgs e)
        {
            string sTime = StartTimePicker.Value.ToString("HH:mm:ss");
            string eTime = EndTimePicker.Value.ToString("HH:mm:ss");
            string member = ScheduleSessionDropDown.SelectedValue.ToString();

            if(sTime == "" || eTime == "" || member == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                string query = "INSERT INTO Training_Session (start_time, end_time, TrainerUName, MemberUName) VALUES (@sTime, @eTime, @trainer, @member)";
                SqlConnection connection = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sTime", sTime);
                    command.Parameters.AddWithValue("@eTime", eTime);
                    command.Parameters.AddWithValue("@trainer", userID);
                    command.Parameters.AddWithValue("@member", member);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Session Scheduled");
                refreshGrid();
                connection.Close();
            }
        }
    }
}
