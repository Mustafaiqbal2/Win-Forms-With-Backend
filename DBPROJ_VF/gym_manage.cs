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
        string userID;
        public gym_manage(string username)
        {
            InitializeComponent();
            bunifuDataGridView1.AllowUserToAddRows = false;
            bunifuDataGridView1.AllowUserToDeleteRows = false;
            userID = username;
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
