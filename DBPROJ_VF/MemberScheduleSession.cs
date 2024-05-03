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
    public partial class MemberScheduleSession : Form
    {
        string userID;
        public MemberScheduleSession(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void MemberFeedback_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }

        private void AppointmentSubmitButton_Click(object sender, EventArgs e)
        {
            string startTime = StartTimePicker.Value.ToString("HH:mm:ss");
            string endTime = EndTimePicker.Value.ToString("HH:mm:ss");

            SqlConnection con = new SqlConnection("Data Source=172.23.129.23;Initial Catalog=PROJ;User ID=Boys;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            con.Open();
            string trainerID;
            string queryT = "SELECT trnUName FROM Gym_Member Where UName = @username";
            SqlCommand cmdT = new SqlCommand(queryT, con);
            cmdT.Parameters.AddWithValue("@username", userID);
            SqlDataReader drT = cmdT.ExecuteReader();
            if (drT.Read())
            {
                trainerID = drT["trnUName"].ToString();
            }
            else
            {
                MessageBox.Show("Error in fetching Trainer ID");
                con.Close();
                return;
            }
            string query = "INSERT INTO Training_Session (start_time,end_time,TrainerUName,MemberUName) VALUES (@start,@end,@trn,@mem)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@start", startTime);
            cmd.Parameters.AddWithValue("@end", endTime);
            cmd.Parameters.AddWithValue("@trn", trainerID);
            cmd.Parameters.AddWithValue("@mem", userID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Session Scheduled");
            con.Close();

        }
    }
}
