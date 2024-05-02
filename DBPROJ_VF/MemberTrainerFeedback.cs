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
    public partial class MemberTrainerFeedback : Form
    {
        string userID;
        public MemberTrainerFeedback(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void MemberTrainerFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
