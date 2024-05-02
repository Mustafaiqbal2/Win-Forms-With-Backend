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
            this.Close();
        }

        private void gym_req_Click(object sender, EventArgs e)
        {
            requests req = new requests(userID);
            req.Show();
            this.Close();
        }
    }
}
