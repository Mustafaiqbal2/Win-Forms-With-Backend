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
    public partial class TrainerReg : Form
    {
        public TrainerReg()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string gym_id = GymSelect.Text;
            dob.CustomFormat = "yyyy-MM-dd";
            start.CustomFormat = "yyyy-MM-dd";
            start.Format = DateTimePickerFormat.Custom;
            dob.Format = DateTimePickerFormat.Custom;
            string dob1 = dob.Text;
            string start1 = start.Text;
            string fna = fname.Text;
            string lna = lname.Text;
            string em = email.Text;
            string pass = password.Text;
            string exp1 = exp.Text;
            string gend = gender.Text;
            MessageBox.Show(dob1);
            if (fna == "" || lna == "" || em == "" || pass == "" || exp1 == "" || gend == "" || gym_id == "")
            {
                MessageBox.Show("Please fill all the fields");
                MessageBox.Show(gym_id);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-M12NPKF\\SQLEXPRESS;Initial Catalog=PROJ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
                con.Open();
                string queryA = "select * from Trainer where UName = '" + em + "'";
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
                string query = "INSERT INTO Trainer(UName,pWord,fName,lName,gender,DOB,exp_lvl,startDate ,gym_ID)" +
                    " values(" +
                    "'" + em + "'," +
                    "'" + pass + "'," +
                    "'" + fna + "'," +
                    "'" + lna + "'," +
                    "'" + gend + "'," +
                    "'" + dob1 + "'," +
                    "" + exp1 + "," +
                    "'" + start1 + "'," +
                    ""  + gym_id + "" + 
                    ")";
                MessageBox.Show(query);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Trainer Registered Successfully");
                Application.OpenForms["Login"].Show();
                this.Close();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Login"].Show();
        }

        private void TrainerReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.projectfinalDataSet.Gym);

        }
    }
}
