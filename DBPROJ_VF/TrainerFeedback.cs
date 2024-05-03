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
    public partial class TrainerFeedback : Form
    {
        string userID;
        public TrainerFeedback(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void TrainerFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet2.Trainer_Feedback' table. You can move, or remove it, as needed.
            this.trainer_FeedbackTableAdapter.Fill(this.pROJDataSet2.Trainer_Feedback);

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TraienrMenu"].Show();
            this.Close();
        }
    }
}
