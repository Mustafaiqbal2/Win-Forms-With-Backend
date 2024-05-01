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
            bunifuDataGridView1.AllowUserToAddRows = false;
            bunifuDataGridView1.AllowUserToDeleteRows = false;
        }

        private void gym_manage_Load(object sender, EventArgs e)
        {
            this.gymTableAdapter.Fill(this.pROJDataSet.Gym);

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
    }
}
