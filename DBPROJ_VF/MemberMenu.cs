using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJ_VF
{
    public partial class MemberMenu : Form
    {
        string userID;
        public MemberMenu(string username)
        {
            InitializeComponent();
            userID = username;
        }

        private void CreateWorkout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberWorkoutPlan createWorkout = new MemberWorkoutPlan(userID);
            createWorkout.Show();
        }

        private void ChooseDiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberDeitPlanSelect dietPlan = new MemberDeitPlanSelect(userID);
            dietPlan.Show();
        }

        private void Rate_Click(object sender, EventArgs e)
        {
            MemberTrainerFeedback feedback = new MemberTrainerFeedback(userID);
            feedback.Show();
            this.Close();
        }

        private void SessionBook_Click(object sender, EventArgs e)
        {
            MemberScheduleSession member = new MemberScheduleSession(userID);
            member.Show();
            this.Close();
        }

        private void DeitPlanning_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberDietPlan dietPlan = new MemberDietPlan(userID);
            dietPlan.Show();
        }
    }
}
