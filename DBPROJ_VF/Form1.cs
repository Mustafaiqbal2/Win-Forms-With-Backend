using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                tr.Show(); 
            }
        }
        private bool valLogin(string table)
        {
            string uname = Username.Text;
            string pass = Password.Text;
            if (uname == "" || pass == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
                con.Open();
                string queryA = "SELECT * FROM "+ table +" where UName = '" + uname + "'";
                MessageBox.Show(queryA);
                SqlCommand cmdA = new SqlCommand(queryA, con);
                SqlDataReader dr = cmdA.ExecuteReader();
                if (dr.Read())
                {
                    Object obj = dr["pWord"];
                    string pass1 = obj.ToString();
                    if (pass1 != pass)
                    {
                        MessageBox.Show("Invalid Password");
                        cmdA.Dispose();
                        con.Close();
                        dr.Close();
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Login Succesful");
                        cmdA.Dispose();
                        con.Close();
                        dr.Close();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Username/Email does not exist");
                    cmdA.Dispose();
                    con.Close();
                    dr.Close();
                    return false;
                }
            }
        }
        private void Admin_Click(object sender, EventArgs e)
        {
            string uname = Username.Text;
            if(valLogin("Gym_Admin"))
            {
                this.Hide();
                Admin ad = new Admin(uname);
                ad.Show();
            }
        }

        private void member_Click(object sender, EventArgs e)
        {
            string uname = Username.Text;
            if (valLogin("Gym_Member"))
            {
                this.Hide();
                MemberMenu me = new MemberMenu(uname);
                me.Show();
            }
        }

        private void trainer_Click(object sender, EventArgs e)
        {
            string uname = Username.Text;

            if (valLogin("Trainer"))
            {
                this.Hide();
                TrainerMenu tr = new TrainerMenu(uname);
                tr.Show();
            }
        }

        private void owner_Click(object sender, EventArgs e)
        {
            string uname = Username.Text;
            if (valLogin("GYM_OWNER"))
            {
                this.Hide();
                Owner ow = new Owner(uname);
                ow.Show();
            }
        }
    }
}
