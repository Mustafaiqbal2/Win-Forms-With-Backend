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
    public partial class Login : Form
    {
        public static string regis = "";
        public Login()
        {
            InitializeComponent();
        }
        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Label_uname_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void regDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            regis = regDrop.Text;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            if(regis == "")
            {
                MessageBox.Show("Please select the registration type");
            }
            else if (regis == "Member")
            {
                this.Hide();
                RegisterMember cr = new RegisterMember();
                cr.Show();
            }
            else if (regis == "Owner")
            {
                this.Hide();
                OwnerReg vr = new OwnerReg();
                vr.Show();
            }
            else if(regis =="Trainer")
            {
                this.Hide();

                TrainerReg tr = new TrainerReg();
            }
        }
    }
}
