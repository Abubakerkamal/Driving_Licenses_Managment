using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Driving_License_Management.Applcations.Applcations_Types;

namespace Driving_License_Management.Tests.TestTypes
{
    public partial class frmListTestTypes : Form
    {
        DataTable _dt;
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            _dt = clsTestType.GetAllTestTypes();
            dgv.DataSource = _dt;
            lbRecoreds.Text = dgv.Rows.Count.ToString();

        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshData();

            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].HeaderText = "ID";
                dgv.Columns[1].HeaderText = "Title";
                dgv.Columns[2].HeaderText = "Description";
                dgv.Columns[3].HeaderText = "Fees";

                dgv.Columns[0].Width = 50;
                dgv.Columns[1].Width = 150;
                dgv.Columns[2].Width = 250;
                dgv.Columns[3].Width = 100;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((int)dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //_RefreshData();
            frmListTestTypes_Load(null, null);
        }


    }
}
