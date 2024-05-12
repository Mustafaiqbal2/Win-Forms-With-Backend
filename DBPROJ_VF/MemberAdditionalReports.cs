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
    public partial class MemberAdditionalReports : Form
    {
        string userID;
        public MemberAdditionalReports(string uname)
        {
            InitializeComponent();
            uname = userID;
        }

        private void MachineSubmit_Click(object sender, EventArgs e)
        {

        }

        private void breakfast_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT DISTINCT dp.id AS 'Plan ID',
                dp.name AS 'Diet Plan Name'
        FROM Diet_Plan dp
        INNER JOIN MealInDay mid ON dp.id = mid.planFK
        INNER JOIN Meal m ON mid.mealName = m.name
        WHERE mid.dayFK = 'Breakfast'
      AND m.protein + m.carbs + m.fat < 500;";

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

        private void reportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carbsintakebutton_Click(object sender, EventArgs e)
        {

            //done
            string query = @"
        SELECT DISTINCT dp.id AS 'Plan ID',
                dp.name AS 'Diet Plan Name'
        FROM Diet_Plan dp
        INNER JOIN MealInDay mid ON dp.id = mid.planFK
        INNER JOIN Meal m ON mid.mealName = m.name
        WHERE  m.carbs  < 500;";

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

        private void dietplanwopeanut_Click(object sender, EventArgs e)
        {

            string query = @"
        SELECT DISTINCT dp.id AS 'Plan ID',
                dp.name AS 'Diet Plan Name'
FROM Diet_Plan dp
LEFT JOIN MealInDay mid ON dp.id = mid.planFK
LEFT JOIN Meal m ON mid.mealName = m.name
LEFT JOIN MealInDay md ON dp.id = md.planFK
LEFT JOIN Alergy a ON md.mealName = a.UName
WHERE a.alergy IS NULL OR a.alergy != 'peanuts';
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }
        private void MemberAdditionalReports_Load(object sender, EventArgs e)
        {

        }
    }
}