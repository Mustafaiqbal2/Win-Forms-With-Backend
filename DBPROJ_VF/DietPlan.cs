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
    public partial class DietPlan : Form
    {
        string userID;
        public DietPlan(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["TrainerMenu"].Show();
        }

    }
}
