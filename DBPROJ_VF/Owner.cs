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

        }

        private void memReport_Click(object sender, EventArgs e)
        {

        }

        private void add_trainer_Click(object sender, EventArgs e)
        {
            AddTrainers add = new AddTrainers(userID);
            add.Show();
            this.Close();
        }

        private void manage_account_Click(object sender, EventArgs e)
        {
            deleteAccounts del = new deleteAccounts(userID);
            del.Show();
            this.Close();
        }
    }
}
