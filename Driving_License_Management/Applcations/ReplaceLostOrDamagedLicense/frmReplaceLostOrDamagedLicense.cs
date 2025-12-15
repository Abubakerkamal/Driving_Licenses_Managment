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
using Driving_License_Management.Licenses;
using Driving_License_Management.Licenses.LocalLicenses;
//using static BusinessLayer.clsLicense;

namespace Driving_License_Management.Applcations.ReplaceLostOrDamagedLicense
{
    public partial class frmReplaceLostOrDamagedLicense : Form
    {

        int _NewLicenseID = -1;
        public frmReplaceLostOrDamagedLicense()
        {
            InitializeComponent();
        }


        private clsLicense.enIssueReason _GetIssueReason()
        {
            if (rbDamagedLicense.Checked)
            {
                return clsLicense.enIssueReason.DamagedReplacement;
            }
            else return clsLicense.enIssueReason.LostReplacement;

        }

        private void frmReplaceLostOrDamagedLicense_Load(object sender, EventArgs e)
        {

            this.Height = 600;
            rbDamagedLicense.Checked = true;
            lblApplicationDate.Text = DateTime.Today.ToShortDateString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

        }
        private int _GetApplicationTypeID()
        {
            if (rbDamagedLicense.Checked)
            {
                return (int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense;
            }
            return (int)clsApplication.enApplicationType.ReplacementforaLostDrivingLicense;

        }
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {

            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();    
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacment for Losted License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();
        }

        private void ucDriverLicenseWithFilter1_OnLicenseSelected(int obj)
        {

            int OldLicenseID = obj;

            lblOldLicenseID.Text = OldLicenseID.ToString();

            llShowLicenseHistory.Visible = (OldLicenseID != -1);

            if(ucDriverLicenseWithFilter1.SelectedLicense.IsActive == 0)
            {
                MessageBox.Show("Selected License is not active, choose an active License", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            llShowLicenseHistory.Enabled = true;
            btnIssueReplacement.Enabled = true;
           
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to issue License?","Conferm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                return;
            }

            clsLicense NewLicense = ucDriverLicenseWithFilter1.SelectedLicense.ReplaceLicense(_GetIssueReason(), clsGlobal.CurrentUser.UserID);
            llShowLicenseInfo.Visible = (NewLicense != null);
            if (NewLicense == null) {

                MessageBox.Show("The License Issuance failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ; 
                return;
            }

            _NewLicenseID = NewLicense.LicenseID;
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            lblRreplacedLicenseID.Text = NewLicense.LicenseID.ToString();
            btnIssueReplacement.Enabled = false ;
            llShowLicenseInfo.Enabled = true;
            ucDriverLicenseWithFilter1.FilterEnabeld = false;

        }



        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(ucDriverLicenseWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

    
    }
}
