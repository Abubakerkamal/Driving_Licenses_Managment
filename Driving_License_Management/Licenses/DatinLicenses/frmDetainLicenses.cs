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
using Driving_License_Management.GlobalClasses;
using Driving_License_Management.Licenses.LocalLicenses;
using Driving_License_Management.Licenses;

namespace Driving_License_Management.Licenses.DatinedLicenses
{
    public partial class frmDetainLicenses : Form
    {

        int _LicenseID;
        int _DetainID;
        public frmDetainLicenses()
        {
            InitializeComponent();
        }

        private void frmDetainLicenses_Load(object sender, EventArgs e)
        {
            this.Height = 515;
            btnDetain.Enabled = false;
            llShowLicenseHistory.Enabled = false;
            llShowLicenseHistory.Enabled = false;
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName.ToString();
        }


        private void ucDriverLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;

            lblLicenseID.Text = LicenseID.ToString();
            llShowLicenseHistory.Enabled = (LicenseID != -1);

            if (ucDriverLicenseWithFilter1.SelectedLicense.IsDetained()) {

                MessageBox.Show("This License Already Detaiend","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                    return;
            }
            btnDetain.Enabled = true;
            llShowLicenseInfo.Enabled = true;
        }


        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to detained this license detained", "Conferm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _LicenseID = ucDriverLicenseWithFilter1.LicenseID;
            _DetainID = ucDriverLicenseWithFilter1.SelectedLicense.Detain(float.Parse(txtFineFees.Text), clsGlobal.CurrentUser.UserID);

            if (_DetainID == -1) {

                MessageBox.Show("Failed to detained this license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License detained successfully with DetainedID = " + _DetainID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucDriverLicenseWithFilter1.FilterEnabeld = false;
            btnDetain.Enabled = false;

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(ucDriverLicenseWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            ucDriverLicenseWithFilter1.txtLicenseIDFocus();
        }
        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFineFees.Text)){
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "This Field Recuired");
                return;
            }

            errorProvider1.SetError(txtFineFees, null);
        }
    }
}
