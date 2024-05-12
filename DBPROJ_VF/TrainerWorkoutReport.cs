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
    public partial class TrainerWorkoutReport : Form
    {
        string userID;
        public TrainerWorkoutReport(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TrainerWorkoutReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Gym_Member' table. You can move, or remove it, as needed.
         //   this.gym_MemberTableAdapter.Fill(this.projectfinalDataSet.Gym_Member);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gym_MemberTableAdapter.FillBy(this.projectfinalDataSet.Gym_Member, trainerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
