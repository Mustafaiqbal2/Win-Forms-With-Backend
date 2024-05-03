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
    public partial class WorkoutPlan : Form
    {
        string userID;
        public WorkoutPlan(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExerciseNameInputTuesday_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExerciseNameInputMonday_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TrainerMenu"].Show();
        }
    }
}
