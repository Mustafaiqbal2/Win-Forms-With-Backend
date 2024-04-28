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
    public partial class OwnerReg : Form
    {
        public OwnerReg()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            dob.CustomFormat = "yyyy-MM-dd";
            dob.Format = DateTimePickerFormat.Custom;
            string dob1 = dob.Text;
            string fna = fname.Text;
            string lna = lname.Text;
            string ema = email.Text;
            string pas = pword.Text;
            if(fna == "" || lna == "" || ema == "" || pas == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=172.23.129.23;Initial Catalog=PROJ;User ID=Boys;Password=12345678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
                con.Open();
                string quearyA = "select * from GYM_OWNER where UName = '" + ema + "'";
                SqlCommand cmdA = new SqlCommand(quearyA, con);
                SqlDataReader dr = cmdA.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Username/Email already exists");
                    cmdA.Dispose();
                    con.Close();
                    dr.Close();
                    return;
                }
                string query = "insert into GYM_OWNER(UName,pWord,fName,lName,DOB)" +
                    " values(" +
                    "'" + ema + "'," +
                    "'" + pas + "'," +
                    "'" + fna + "'," +
                    "'" + lna + "'," +
                    "'" + dob1 + "'" +
                    ")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Registration Successful");
            }
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
