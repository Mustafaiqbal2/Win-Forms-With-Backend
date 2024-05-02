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
    public partial class AddTrainers : Form
    {
        string userID;
        public AddTrainers(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void AddTrainers_Load(object sender, EventArgs e)
        {

        }
    }
}
