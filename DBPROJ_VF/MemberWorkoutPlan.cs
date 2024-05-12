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
    public partial class MemberWorkoutPlan : Form
    {
        string userID;
        public MemberWorkoutPlan(string username)
        {
            InitializeComponent();
            userID = username;
        }

        private void WorkoutPlanSubmitButton_Click(object sender, EventArgs e)
        {
            string[] names = new string[5];
            names[0] = ExerciseNameInputMonday.Text;
            names[1] = ExerciseNameInputTuesday.Text;
            names[2] = ExerciseNameInputWednesday.Text;
            names[3] = ExerciseNameInputThursday.Text;
            names[4] = ExerciseNameInputFriday.Text;
            bool flag = false;
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            con.Open();
            ///////////////DIET INSERTION
            string planName = PlanNameInput.Text;
            if (planName == "")
            {
                MessageBox.Show("Please fill all the fields");
                con.Close();
                return;
            }

            string queryd = "SELECT name FROM Workout_Plan Where name = @name";
            SqlCommand cmdD = new SqlCommand(queryd, con);
            cmdD.Parameters.AddWithValue("@name", planName);
            SqlDataReader drD = cmdD.ExecuteReader();
            if (drD.Read())
            {
                MessageBox.Show("Workout Plan Name already exists");
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
                    MessageBox.Show("Please fill atleast one day");
                    con.Close();
                    return;
                }
                //insert into diet plan
                string trainerID = "";
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
                string query = "INSERT INTO Workout_Plan(name) VALUES(@name)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", planName);
                cmd.ExecuteNonQuery();
            }
            //getPlanID
            string getPlanIDQ = "SELECT id FROM Workout_Plan Where name = @name";
            SqlCommand cmdP = new SqlCommand(getPlanIDQ, con);
            cmdP.Parameters.AddWithValue("@name", planName);
            SqlDataReader drP = cmdP.ExecuteReader();
            string planID = "";
            if (drP.Read())
            {
                planID = drP["id"].ToString();
            }
            string query4 = "UPDATE Gym_Member SET workPlan = @PlanID WHERE UName = @memberID";
            SqlCommand cmdE = new SqlCommand(query4, con);
            cmdE.Parameters.AddWithValue("@PlanID", planID);
            cmdE.Parameters.AddWithValue("@memberID", userID);
            /////MEAL INSERTION
            string machine = "";
            string sets = "";
            string reps = "";
            string rest = "";
            string day = "";

            for (int i = 0; i < 5; i++)
            {

                if (names[i] != "")
                {

                    switch (i)
                    {
                        case 0:
                            day = "Monday";
                            machine = MachineNameInputMonday.Text;
                            sets = SetsInputMonday.Text;
                            reps = RepsInputMonday.Text;
                            rest = RestIntervalInputMonday.Text;
                            break;
                        case 1:
                            day = "Tuesday";
                            machine = MachineNameInputTuesday.Text;
                            sets = SetsInputTuesday.Text;
                            reps = RepsInputTuesday.Text;
                            rest = RestIntervalInputTuesday.Text;
                            break;
                        case 2:
                            day = "Wednesday";
                            machine = MachineNameInputWednesday.Text;
                            sets = SetsInputWednesday.Text;
                            reps = RepsInputwednesday.Text;
                            rest = RestIntervalInputWednesday.Text;
                            break;
                        case 3:
                            day = "Thursday";
                            machine = MachineNameInputThursday.Text;
                            sets = SetsInputThursday.Text;
                            reps = RepsInputThursday.Text;
                            rest = RestIntervalInputThursday.Text;
                            break;
                        case 4:
                            day = "Friday";
                            machine = MachineNameInputFriday.Text;
                            sets = SetsInputFriday.Text;
                            reps = RepsInputFriday.Text;
                            rest = RestIntervalInputFriday.Text;
                            break;
                    }


                    string query1 = "SELECT name FROM exercise Where name = @name";

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
                        string query2 = "INSERT INTO exercise(name, machine,Setss,Reps,RestInterval) VALUES(@name, @machine,@sets,@reps,@rest)";
                        SqlCommand cmdB = new SqlCommand(query2, con);
                        cmdB.Parameters.AddWithValue("@name", names[i]);
                        cmdB.Parameters.AddWithValue("@machine", machine);
                        cmdB.Parameters.AddWithValue("@sets", sets);
                        cmdB.Parameters.AddWithValue("@reps", reps);
                        cmdB.Parameters.AddWithValue("@rest", rest);

                        cmdB.ExecuteNonQuery();
                    }
                    //Insert Into Meal_In_Day
                    string query3 = "INSERT INTO ExerciseInDay(dayFK, exerciseName,planFK) VALUES(@dayFK, @EName, @PlanID)";
                    SqlCommand cmdC = new SqlCommand(query3, con);
                    cmdC.Parameters.AddWithValue("@dayFK", day);
                    cmdC.Parameters.AddWithValue("@EName", names[i]);
                    cmdC.Parameters.AddWithValue("@PlanID", planID);
                    cmdC.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Workout Plan Submitted");
            con.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }
    }
}
