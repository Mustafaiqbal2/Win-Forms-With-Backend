﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.OpenForms["Owner"].Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            dob.CustomFormat = "yyyy-MM-dd";
            join.CustomFormat = "yyyy-MM-dd";
            join.Format = DateTimePickerFormat.Custom;
            dob.Format = DateTimePickerFormat.Custom;
            string dob1 = dob.Text;
            string start1 = join.Text;
            string fna = fname.Text;
            string lna = lname.Text;
            string em = email.Text;
            string pass = password.Text;
            string exp1 = exp.Text;
            string gend = gender.Text;
            MessageBox.Show(dob1);
            if (fna == "" || lna == "" || em == "" || pass == "" || exp1 == "" || gend == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-E15Q53Q\\SQLEXPRESS; Initial Catalog = Projectfinal; Integrated Security = True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
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
                string query = "INSERT INTO Trainer (UName, pWord, fName, lName, gender, DOB, exp_lvl, startDate, gym_ID) " +
                "VALUES (@UName, @pWord, @fName, @lName, @gender, @DOB, @exp_lvl, @startDate, (SELECT id FROM Gym WHERE ownerUname = @userID))";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UName", em);
                cmd.Parameters.AddWithValue("@pWord", pass);
                cmd.Parameters.AddWithValue("@fName", fna);
                cmd.Parameters.AddWithValue("@lName", lna);
                cmd.Parameters.AddWithValue("@gender", gend);
                cmd.Parameters.AddWithValue("@DOB", dob1);
                cmd.Parameters.AddWithValue("@exp_lvl", exp1);
                cmd.Parameters.AddWithValue("@startDate", start1);
                cmd.Parameters.AddWithValue("@userID", userID);

                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Trainer Registered Successfully");
                Application.OpenForms["Owner"].Show();
                this.Close();
            }
        }
    }
}
