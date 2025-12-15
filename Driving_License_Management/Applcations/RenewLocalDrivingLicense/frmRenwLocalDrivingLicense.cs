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
using Driving_License_Management.Licenses.LocalLicenses;
using Driving_License_Management.Licenses;

namespace Driving_License_Management.Applcations.RenewLocalDrivingLicense
{

    public partial class frmRenwLocalDrivingLicense : Form
    {
        int _NewLicenseID = -1;
        clsLicense _NewLicense;
        public frmRenwLocalDrivingLicense()
        {
            InitializeComponent();
        }
        
        private void frmRenwLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            this.Height = 600;
            //---------------

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicenseService).Fees.ToString();
            lblExpirationDate.Text = "[???]";
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
            ucDriverLicenseWithFilter1.txtLicenseIDFocus();

        }

        private void ucDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int OldLicenseID = obj;
            lblOldLicenseID.Text = (OldLicenseID != -1) ? OldLicenseID.ToString() : "[???]";
            llShowLicenseHistory.Enabled = (OldLicenseID != -1);
            if (OldLicenseID == -1) {
                    return;
            }
            lblLicenseFees.Text = ucDriverLicenseWithFilter1.SelectedLicense.PaidFees.ToString();
            txtNotes.Text = ucDriverLicenseWithFilter1.SelectedLicense.Notes.ToString();

            int DefaultValidatylength = ucDriverLicenseWithFilter1.SelectedLicense.LicenseClassInfo.DefaultValidityLength;
            //lblExpirationDate.Text = (DateTime.Now.AddYears(DefaultValidatylength)).ToShortDateString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();

            if (!ucDriverLicenseWithFilter1.SelectedLicense.IsExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " +(ucDriverLicenseWithFilter1.SelectedLicense.ExpirationDate).ToShortDateString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error); btnRenewLicense.Enabled = false;
                return;

            }

            if (ucDriverLicenseWithFilter1.SelectedLicense.IsActive == 0)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license." , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
                return;
            }

            btnRenewLicense.Enabled = true;

        }
        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(ucDriverLicenseWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense NewLicense = ucDriverLicenseWithFilter1.SelectedLicense.RenewLicense(txtNotes.Text, clsGlobal.CurrentUser.UserID);

            if (NewLicense != null) {

                _NewLicenseID = NewLicense.LicenseID;
                MessageBox.Show("The License Has been renewed with ID = " + NewLicense.LicenseID, "License issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationID.Text = NewLicense.ApplicationID.ToString();
                lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();
                lblExpirationDate.Text = NewLicense.ExpirationDate.ToShortDateString();

                btnRenewLicense.Enabled = false;
                ucDriverLicenseWithFilter1.FilterEnabeld = false;
                llShowLicenseInfo.Enabled = true;
                return;

            }

            MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
