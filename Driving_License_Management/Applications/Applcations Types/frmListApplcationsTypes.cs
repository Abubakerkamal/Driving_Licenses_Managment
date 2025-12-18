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

namespace Driving_License_Management.Applcations.Applcations_Types
{
    public partial class frmListApplcationsTypes : Form
    {

        DataTable _dt;
        public frmListApplcationsTypes()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplcationTypes frm = new frmEditApplcationTypes((int)dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //_RefreshData();
            frmListApplcationsTypes_Load(null,null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _RefreshData()
        {
            _dt = clsApplicationType.GetAllAppTypes();
            dgv.DataSource = _dt;
            lbRecoreds.Text = dgv.Rows.Count.ToString();

        }
        private void frmListApplcationsTypes_Load(object sender, EventArgs e)
        {

            _RefreshData();

            if (dgv.Rows.Count > 0) {
                dgv.Columns[0].HeaderText = "ID";
                dgv.Columns[1].HeaderText = "Title";
                dgv.Columns[2].HeaderText = "Fees";

                dgv.Columns[0].Width = 100;
                dgv.Columns[1].Width = 250;
                dgv.Columns[2].Width = 150;
            }
        }
    }
}
