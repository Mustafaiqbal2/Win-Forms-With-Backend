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
    public partial class deleteAccounts : Form
    {
        public deleteAccounts()
        {
            InitializeComponent();
        }

        private void deleteAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet.Trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.pROJDataSet.Trainer);
            // TODO: This line of code loads data into the 'pROJDataSet.Gym_Member' table. You can move, or remove it, as needed.
            this.gym_MemberTableAdapter.Fill(this.pROJDataSet.Gym_Member);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gym_MemberTableAdapter.FillBy(this.pROJDataSet.Gym_Member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    
    }
}
