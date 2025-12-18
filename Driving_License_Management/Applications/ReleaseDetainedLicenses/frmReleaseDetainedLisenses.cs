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
using Driving_License_Management.GlobalClasses;
using Driving_License_Management.Licenses;
using Driving_License_Management.Licenses.LocalLicenses;
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_Management.Applcations.ReleaseDetainedLicenses
{
    public partial class frmReleaseDetainedLisenses : Form
    {
        int _LicenseID;
        clsDetainedLicense DetainedLicense;
        clsApplicationType ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense);

        public frmReleaseDetainedLisenses()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseID)
        {
            ucDriverLicenseWithFilter1.LoadLicenseInfo(LicenseID);
            ucDriverLicenseWithFilter1.FilterEnabeld = false;
        }
        private void frmReleaseDetainedLisenses_Load(object sender, EventArgs e)
        {
            this.Height = 515;
        }

        private void ucDriverLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            lblLicenseID.Text = _LicenseID.ToString();
            llShowLicenseHistory.Enabled = (_LicenseID != -1);
            
            if(!ucDriverLicenseWithFilter1.SelectedLicense.IsDetained())
            {
                MessageBox.Show("This License is not detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblDetainID.Text = ucDriverLicenseWithFilter1.SelectedLicense.DetainedInfo.DetainID.ToString();
            lblDetainDate.Text = ucDriverLicenseWithFilter1.SelectedLicense.DetainedInfo.DetainDate.ToString();

            lblFineFees.Text = ucDriverLicenseWithFilter1.SelectedLicense.DetainedInfo.FineFess.ToString();
            lblApplicationFees.Text = ((float)clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees).ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            lblCreatedByUser.Text = ucDriverLicenseWithFilter1.SelectedLicense.DetainedInfo.CreatedByUserInfo.UserName.ToString(); ;

            btnRelease.Enabled = true;
            llShowLicenseInfo.Enabled = true;


        }

        private void btnRelease_Click(object sender, EventArgs e)
        {


            if(MessageBox.Show("Are you sure you want to release this license detained","Conferm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;

            bool IsReleased = ucDriverLicenseWithFilter1.SelectedLicense.ReleaseDetained(clsGlobal.CurrentUser.UserID, ref ApplicationID);

           
            if (!IsReleased) {


                MessageBox.Show("Faild to released License Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License Released Successfully", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblApplicationID.Text = ApplicationID.ToString();
            btnRelease.Enabled = false;
            ucDriverLicenseWithFilter1.FilterEnabeld = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
