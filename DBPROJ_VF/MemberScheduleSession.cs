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
    public partial class MemberScheduleSession : Form
    {
        string userID;
        public MemberScheduleSession(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void MemberFeedback_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["MemberMenu"].Show();
        }
    }
}
