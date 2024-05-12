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
    public partial class MemberTrainerFeedback : Form
    {
        string userID;
        public MemberTrainerFeedback(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void MemberTrainerFeedback_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }

        private void FeedbackSubmitButton_Click(object sender, EventArgs e)
        {
            float rating = bunifuRating1.Value;
            string feedback = FeedbackTextBox.Text;
            if(feedback == "")
            {
                MessageBox.Show("Please enter feedback");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
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
                string query = "INSERT INTO Trainer_Feedback (trainerUName, memberUName, rating, comment) VALUES (@trainerUName, @memberUName, @rating, @feedback)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@trainerUName", trainerID);
                cmd.Parameters.AddWithValue("@memberUName", userID);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@feedback", feedback);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Feedback Submitted");
                con.Close();
            }
        }
    }
}
