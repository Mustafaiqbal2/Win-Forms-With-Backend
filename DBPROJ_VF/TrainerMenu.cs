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
    public partial class TrainerMenu : Form
    {
        string userID;
        public TrainerMenu(string uname)
        {
            InitializeComponent();
            userID = uname;
        }

        

        private void CreateDietPlanButton_Click(object sender, EventArgs e)
        {
            DietPlan dietPlan = new DietPlan(userID);
            dietPlan.Show();
            this.Hide();
        }

        private void CreateWorkoutButton_Click(object sender, EventArgs e)
        {
            WorkoutPlan workout = new WorkoutPlan(userID);
            workout.Show();
            this.Hide();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            TrainerAppointment trainer = new TrainerAppointment(userID);
            trainer.Show();
            this.Hide();
        }

        private void DietReportsButton_Click(object sender, EventArgs e)
        {
          
        }

        private void WorkoutReportsButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewFeedbackButton_Click(object sender, EventArgs e)
        {
            TrainerFeedback feedback = new TrainerFeedback(userID);
            feedback.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
