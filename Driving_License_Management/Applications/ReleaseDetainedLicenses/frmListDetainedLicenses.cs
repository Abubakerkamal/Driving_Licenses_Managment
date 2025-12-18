using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driving_License_Management.Licenses.DatinedLicenses;
using Driving_License_Management.People;
using Driving_License_Management.Licenses.LocalLicenses;
using Driving_License_Management.Licenses.LocalLicenses.Controls;
using Driving_License_Management.Licenses;
namespace Driving_License_Management.Applcations.ReleaseDetainedLicenses
{
    public partial class frmListDetainedLicenses : Form
    {
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        DataTable _dtDetainedLicenses = new DataTable();

        private void _LoadData()
        {
            _dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;
            lblTotalRecords.Text = _dtDetainedLicenses.Rows.Count.ToString();

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 90;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 90;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 160;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 110;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 110;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 160;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns[6].Width = 90;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 330;

                dgvDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
                dgvDetainedLicenses.Columns[8].Width = 150;

            }


        }
        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            cbFilterBy.SelectedIndex = 0;
            cbIsReleased.SelectedIndex = 0;
            _LoadData();

        }


        /*
         None
         Detain ID
         Is Released
         National No.
         Full Name
         Release Application ID
         */
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                cbIsReleased.Visible = false;
                txtFilterValue.Visible = false;
            }
            else if (cbFilterBy.Text == "Is Released")
            {
                cbIsReleased.Visible = true;
                txtFilterValue.Visible = false;
            }
            else
            {
                cbIsReleased.Visible = false;
                txtFilterValue.Visible = true;
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbIsReleased.Text)
            {
                case "All":
                    _dtDetainedLicenses.DefaultView.RowFilter = "";
                   
                    break;
                case "Yes":
                    _dtDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = 1";

                    break;
                case "No":
                    _dtDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = 0";
                    break;
                default:
                    break;
            }

            lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "";

            switch (cbFilterBy.Text) {

                case "None":
                    FilterColoumn = "None";
                    break;
                case "Detain ID":
                    FilterColoumn = "DetainID";
                    break;
                case "National No.":
                    FilterColoumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColoumn = "FullName";
                    break;
                case "Release Application ID":
                    FilterColoumn = "ReleaseApplicationID";
                    break;
            }

            if(string.IsNullOrWhiteSpace(txtFilterValue.Text) || FilterColoumn == "")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
            }

            else if(FilterColoumn == "DetainID" || FilterColoumn == "ReleaseApplicationID")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = $"[{FilterColoumn}] = {txtFilterValue.Text}";
            }
            else _dtDetainedLicenses.DefaultView.RowFilter = $"[{FilterColoumn}] LIKE '{txtFilterValue.Text}%'";

            lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenses frm = new frmDetainLicenses();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLisenses frm = new frmReleaseDetainedLisenses();
            frm.ShowDialog();
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled = !(bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value;
        }

        private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.FindByLicenseID(LicenseID).DriverInfo.PersonID;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.FindByLicenseID(LicenseID).DriverInfo.PersonID;
            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(PersonID);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            frmReleaseDetainedLisenses frm = new frmReleaseDetainedLisenses();
            frm.LoadLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
    }
}
