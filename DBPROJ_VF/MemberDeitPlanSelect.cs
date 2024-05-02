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
    public partial class MemberDeitPlanSelect : Form
    {
        public MemberDeitPlanSelect()
        {
            InitializeComponent();
        }

        private void MemberDeitPlanSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet.Diet_Plan' table. You can move, or remove it, as needed.
            this.diet_PlanTableAdapter1.Fill(this.pROJDataSet.Diet_Plan);
            // TODO: This line of code loads data into the 'pROJDataSet2.Diet_Plan' table. You can move, or remove it, as needed.
            this.diet_PlanTableAdapter.Fill(this.pROJDataSet2.Diet_Plan);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
