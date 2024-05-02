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
            this.Close(); 
            MemberMenu menu = new MemberMenu(userID);
            menu.Show();
        }
    }
}
