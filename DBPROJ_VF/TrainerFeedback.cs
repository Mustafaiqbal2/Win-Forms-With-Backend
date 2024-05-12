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
    public partial class TrainerFeedback : Form
    {
        string userID;
        public TrainerFeedback(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            string gymMemberQuery = "SELECT m.rating,comment FROM Trainer_Feedback m " +
                                    "JOIN Trainer t ON t.UName = trainerUName " +
                                    "WHERE t.UName = @UserID";
            DataTable gymMemberDataTable = new DataTable();

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
            connection.Close();
            bunifuDataGridView1.DataSource = gymMemberDataTable;
            float overallRating = 0;
            object overallRatingObj;
            string query = "SELECT AVG(rating) FROM Trainer_Feedback WHERE trainerUName = @UserID";
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                overallRatingObj = command.ExecuteScalar();
            }
            if (overallRatingObj != DBNull.Value)
            {
                overallRating = Convert.ToSingle(overallRatingObj);
            }
            connection.Close();
            OverallRating.Text = overallRating.ToString();
        }

        private void TrainerFeedback_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TrainerMenu"].Show();
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
