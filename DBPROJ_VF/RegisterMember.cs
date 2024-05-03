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
    public partial class RegisterMember : Form
    {
        public RegisterMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fnamereg_mem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            join.CustomFormat = "yyyy-MM-dd";
            dob.CustomFormat = "yyyy-MM-dd";
            dob.Format = DateTimePickerFormat.Custom;
            join.Format = DateTimePickerFormat.Custom;
            string fname = bunifuTextBox1.Text;
            string lname = bunifuTextBox2.Text;
            string ema = email.Text;
            string dob1 = dob.Text;
            string joinDate = join.Text;
            string gend = gender.Text;
            string subs = bunfuDropdown2.Text;
            string alerg = alergies.Text;
            string goa = goal.Text;
            string weigh = weight.Text;
            string heigh = height.Text;
            string pass = password.Text;
            if (fname == "" || lname == "" || ema == "" || dob1 == "" || joinDate == "" || gend == "" || subs == "" || goa == "" || weigh == "" || heigh == "" || pass == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-M12NPKF\\SQLEXPRESS;Initial Catalog=PROJ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
                con.Open();
                string queryA = "SELECT * FROM Gym_Member WHERE Uname = '" + ema + "'";
                SqlCommand cmdA = new SqlCommand(queryA, con);
                SqlDataReader dr = cmdA.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Username/Email already exists");
                    cmdA.Dispose();
                    con.Close();
                    dr.Close();
                    return;
                }
                string query = "INSERT INTO Gym_Member(Uname,pWord,fName,lName,DOB,wieght,reg_date,goal,gender,subscription,height)" +
                    " VALUES(" +
                    "'" + ema + "'," +
                    "'" + pass + "'," +
                    "'" + fname + "'," +
                    "'" + lname + "'," +
                    "'" + dob1 + "'," +
                    "" + weigh + "," +
                    "'" + joinDate + "'," +
                    "'" + goa + "'," +
                    "'" + gend + "'," +
                    "'" + subs + "'," +
                    "" + heigh + "" +
                    ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                foreach (string var in alerg.Split(' '))
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Alergy(Uname,alergy) VALUES('" + ema + "','" + var + "')", con);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                }
                con.Close();
                MessageBox.Show("Member Registered Successfully");
                Application.OpenForms["Form1"].Show();
                this.Close();
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void join_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alergies_TextChanged(object sender, EventArgs e)
        {

        }

        private void goal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void height_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Form1"].Show();
            this.Close();
        }
    }
}
