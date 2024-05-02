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
        public TrainerFeedback()
        {
            InitializeComponent();
        }

        private void TrainerFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet2.Trainer_Feedback' table. You can move, or remove it, as needed.
            this.trainer_FeedbackTableAdapter.Fill(this.pROJDataSet2.Trainer_Feedback);

        }
    }
}
