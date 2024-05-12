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
    public partial class Owner : Form
    {
        string userID;
        public Owner(string uname)
        {
            InitializeComponent();
            userID = uname;
        }

        private void traiRep_Click(object sender, EventArgs e)
        {
            OwnerTrainerReports mem = new OwnerTrainerReports(userID);
            mem.Show();
            this.Hide();
        }

        private void memReport_Click(object sender, EventArgs e)
        {
            OwnerMemberReport mem = new OwnerMemberReport(userID);
            mem.Show();
            this.Hide();
        }

        private void add_trainer_Click(object sender, EventArgs e)
        {
            AddTrainers add = new AddTrainers(userID);
            add.Show();
            this.Hide();
        }

        private void manage_account_Click(object sender, EventArgs e)
        {
            deleteAccounts del = new deleteAccounts(userID);
            del.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void AdditionalReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerAdditionalReports rep = new OwnerAdditionalReports(userID);
            rep.Show();

        }
    }
}
