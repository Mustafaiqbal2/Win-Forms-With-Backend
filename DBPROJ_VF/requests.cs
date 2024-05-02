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
    public partial class requests : Form
    {
        public requests()
        {
            InitializeComponent();
        }

        private void requests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROJDataSet1.Franchise_Application' table. You can move, or remove it, as needed.
            this.franchise_ApplicationTableAdapter.Fill(this.pROJDataSet1.Franchise_Application);

        }

        private void applications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string prop = applications.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                MessageBox.Show(prop);
            }
        }
    }
}
