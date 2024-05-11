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
    public partial class ReportTesting : Form
    {
        public ReportTesting()
        {
            InitializeComponent();
        }

        private void ReportTesting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectfinalDataSet.Gym_Member' table. You can move, or remove it, as needed.
            this.gym_MemberTableAdapter.Fill(this.projectfinalDataSet.Gym_Member);
         

        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
           // this.gYMOWNERBindingSource.Sort = this.advancedDataGridView.SortString;
          this.gymMemberBindingSource .Sort = this.advancedDataGridView.SortString;
        }
        
        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
           // this.gYMOWNERBindingSource.Filter = this.advancedDataGridView.FilterString;
            this.gymMemberBindingSource.Filter = this.advancedDataGridView.FilterString;
        }

        private void gYMOWNERBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotal.Text = string.Format("Total Members: {0}", this.projectfinalDataSet.Gym_Member.Rows.Count);
        }

       

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
