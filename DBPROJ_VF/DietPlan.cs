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
    public partial class DietPlan : Form
    {
        string userID;

        public DietPlan(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            // Define your custom SQL query for Gym_Member table
            string gymMemberQuery = "SELECT * FROM Gym_Member m " +
                                    "JOIN Trainer t ON t.UName = trnUName " +
                                    "WHERE t.UName = @UserID";
            DataTable gymMemberDataTable = new DataTable();

            // Open the connection
            SqlConnection connection = new SqlConnection("Data Source=172.23.129.23;Initial Catalog=PROJ;User ID=Boys;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            connection.Open();

            // Execute the Gym Member query
            using (SqlCommand command = new SqlCommand(gymMemberQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                SqlDataReader reader = command.ExecuteReader();
                gymMemberDataTable.Load(reader);
            }
            connection.Close();
            MemberSelectDropDown.DataSource = gymMemberDataTable;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TrainerMenu"].Show();
        }

        private void DietPlan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet.Alergy' table. You can move, or remove it, as needed.
            this.alergyTableAdapter.Fill(this.pROJDataSet.Alergy);
            // TODO: This line of code loads data into the 'pROJDataSet.Gym_Member' table. You can move, or remove it, as needed.
            this.gym_MemberTableAdapter.Fill(this.pROJDataSet.Gym_Member);

        }

        private void DietPlanSubmitButton_Click(object sender, EventArgs e)
        {
            string[] names = new string[5];
            names[0] = MealNameInputMonday.Text;
            names[1] = MealNameInputTuesday.Text;
            names[2] = MealNameInputWednesday.Text;
            names[3] = MealNameInputThursday.Text;
            names[4] = Friday.Text;
            bool flag = false;
            SqlConnection con = new SqlConnection("Data Source=172.23.129.23;Initial Catalog=PROJ;User ID=Boys;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            con.Open();
            ///////////////DIET INSERTION
            string planName = PlanNameInput.Text;
            string purpose = PurposeInput.Text;
            string memberID = MemberSelectDropDown.SelectedValue.ToString();
            if(planName == "" || purpose == "" || memberID == "")
            {
                MessageBox.Show("Please fill all the fields");
                con.Close();
                return;
            }

            string queryd = "SELECT name FROM Diet_Plan Where name = @name";
            SqlCommand cmdD = new SqlCommand(queryd, con);
            cmdD.Parameters.AddWithValue("@name", planName);
            SqlDataReader drD = cmdD.ExecuteReader();
            if(drD.Read())
            {
                MessageBox.Show("Diet Plan Name already exists");
                con.Close();
                return;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (names[i] != "")
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Please fill atleast one meal name");
                    con.Close();
                    return;
                }
                //insert into diet plan
                string query = "INSERT INTO Diet_Plan(name, purpose, memUName,trainerUName) VALUES(@name, @purpose, @memberID,@trainer)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", planName);
                cmd.Parameters.AddWithValue("@purpose", purpose);
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@trainer", userID);
                cmd.ExecuteNonQuery();
            }
            //getPlanID
            string getPlanIDQ = "SELECT id FROM Diet_Plan Where name = @name";
            SqlCommand cmdP = new SqlCommand(getPlanIDQ, con);
            cmdP.Parameters.AddWithValue("@name", planName);
            SqlDataReader drP = cmdP.ExecuteReader();
            string planID = "";
            if (drP.Read())
            {
                planID = drP["id"].ToString();
            }

            /////MEAL INSERTION
            string portion = "";
            string protien = "";
            string carbs ="";
            string fats="";
            string fiber="";
            string day = "";
            string allergen = "";

            for (int i = 0; i < 5; i++)
            {

                if (names[i]!= "")
                {

                    switch(i)
                    {
                        case 0:
                            day = "Monday";
                            portion = portionInputMonday.Text;
                            protien = ProtienInputMonday.Text;
                            carbs = CarbsInputMonday.Text;
                            fats = FatInputMonday.Text;
                            fiber = FiberInputMonday.Text;
                            allergen = AllergenInputMonday.Text;
                            break;
                        case 1:
                            day = "Tuesday";
                            portion = portionInputTuesday.Text;
                            protien = ProtienInputTuesday.Text;
                            carbs = CarbsInputTuesday.Text;
                            fats = FatInputTuesday.Text;
                            fiber = FiberInputTuesday.Text;
                            allergen = AllergenInputTuesday.Text;
                            break;
                        case 2:
                            day = "Wednesday";
                            portion = portionInputWednesday.Text;
                            protien = ProtienInputWednesday.Text;
                            carbs = CarbsInputWednesday.Text;
                            fats = FatInputWednesday.Text;
                            fiber = FiberInputWednesday.Text;
                            allergen = AllergenInputWednesday.Text;
                            break;
                        case 3:
                            day = "Thursday";
                            portion = portionInputThursday.Text;
                            protien = ProtienInputThursday.Text;
                            carbs = CarbsInputThursday.Text;
                            fats = FatInputThursday.Text;
                            fiber = FiberInputThursday.Text;
                            allergen = AllergenInputThursday.Text;
                            break;
                        case 4:
                            day = "Friday";
                            portion = portionInputFriday.Text;
                            protien = ProtienInputFriday.Text;
                            carbs = CarbsInputFriday.Text;
                            fats = FatInputFriday.Text;
                            fiber = FiberInputFriday.Text;
                            allergen = AllergenInputFriday.Text;
                            break;
                    }


                    string query1 = "SELECT name FROM Meal Where name = @name";
                   
                    SqlCommand cmdA = new SqlCommand(query1, con);
                    cmdA.Parameters.AddWithValue("@name", names[i]);
                    SqlDataReader dr = cmdA.ExecuteReader();
                    if (dr.Read())
                    {
                        //do nothing
                    }
                    else
                    {
                        //insert into meal
                        string query2 = "INSERT INTO Meal(name, portionSize, protein, carbs, fat, fiber, Allergen) VALUES(@name, @portion, @protien, @carbs, @fats, @fiber, @allergen)";
                        SqlCommand cmdB = new SqlCommand(query2, con);
                        cmdB.Parameters.AddWithValue("@name", names[i]);
                        cmdB.Parameters.AddWithValue("@portion", portion);
                        cmdB.Parameters.AddWithValue("@protien", protien);
                        cmdB.Parameters.AddWithValue("@carbs", carbs);
                        cmdB.Parameters.AddWithValue("@fats", fats);
                        cmdB.Parameters.AddWithValue("@fiber", fiber);
                        cmdB.Parameters.AddWithValue("@allergen", allergen);
                        cmdB.ExecuteNonQuery();
                    }
                    //Insert Into Meal_In_Day
                    string query3 = "INSERT INTO MealInDay(dayFK, mealName,planFK) VALUES(@day, @mealName, @dietPlanID)";
                    SqlCommand cmdC = new SqlCommand(query3, con);
                    cmdC.Parameters.AddWithValue("@day", day);
                    cmdC.Parameters.AddWithValue("@mealName", names[i]);
                    cmdC.Parameters.AddWithValue("@dietPlanID", planID);
                    cmdC.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Diet Plan Submitted");
            con.Close();
        }
    }
}
