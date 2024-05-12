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
    public partial class Admin : Form
    {
        string userID;
        public Admin(string uname)
        {
            InitializeComponent();
            userID = uname;
        }

        private void gym_man_Click(object sender, EventArgs e)
        {
            gym_manage gym_ = new gym_manage(userID);
            gym_.Show();
            this.Hide();
        }

        private void gym_req_Click(object sender, EventArgs e)
        {
            requests req = new requests(userID);
            req.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void AdditionalReports_Click(object sender, EventArgs e)
        {
            //one report left comparisons of total members of gyms in past 6 months
            ReportTesting rep = new ReportTesting();
            rep.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void comparison_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            AdminComparison comp = new AdminComparison();
            comp.Show();
        }
    }
}
