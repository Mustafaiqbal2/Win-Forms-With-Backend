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
    public partial class gym_manage : Form
    {
        public gym_manage()
        {
            InitializeComponent();
        }

        private void gym_manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet.Gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.pROJDataSet.Gym);

        }
    }
}
