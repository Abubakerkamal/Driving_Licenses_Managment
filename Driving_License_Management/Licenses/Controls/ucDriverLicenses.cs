using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driving_License_Management.Licenses.LocalLicenses;
using Driving_License_Management.Licenses.InternationalLicenses;

namespace Driving_License_Management.Licenses.Controls
{
    public partial class ucDriverLicenses : UserControl
    {
        int _DriverID;
        clsDriver _Driver;
        DataTable _dtLocalDrivingLicenses;
        DataTable _dtInternationalDrivingLicense;
        public ucDriverLicenses()
        {
            InitializeComponent();
        }

        private void LoadLocalLicenses()
        {
            _dtLocalDrivingLicenses = clsLicense.GetDriverLicenses(_Driver.DriverID);
            _dtInternationalDrivingLicense = clsInternationalLicense.GetDriverLicenses(_Driver.DriverID);

            dgvLocalLicensesHistory.DataSource = _dtLocalDrivingLicenses;
            dgvInternationalLicensesHistory.DataSource = _dtInternationalDrivingLicense;

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 100;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 170;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 75;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 75;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 50;
            }
        
            lblLocalLicensesRecords.Text = _dtLocalDrivingLicenses.Rows.Count.ToString();
            lblInternationalLicensesRecords.Text = _dtInternationalDrivingLicense.Rows.Count.ToString();
            


        }

        public void LoadData(int PersonID)
        {
            
             _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("No Driver with Person ID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DriverID = _Driver.DriverID;

            LoadLocalLicenses();


        }

        public void LoadDataByDriverID(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("No Driver with ID = " + DriverID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            LoadLocalLicenses();


        }


        public void CLear()
        {
            _dtLocalDrivingLicenses.Clear();
            _dtInternationalDrivingLicense.Clear();
        }
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e) {

            int ID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(ID);
            frm.ShowDialog();
            
        }

        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value;
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(ID);
            frm.ShowDialog();
        }
    }
}
