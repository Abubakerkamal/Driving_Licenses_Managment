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
using Driving_License_Management.Licenses.InternationalLicenses;
using Driving_License_Management.Licenses;

namespace Driving_License_Management.Applcations.InternationalLicenseApplication
{

     
    public partial class frmAddInternationalLicense : Form
    {

        int _InternationalLicenseID;
        public frmAddInternationalLicense()
        {
            InitializeComponent();
        }

        

        private void frmAddInternationalLicense_Load(object sender, EventArgs e)
        {
              lblApplicationDate.Text = DateTime.Now.ToShortDateString();
              lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
              lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
              lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ucDriverLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int LocalLicenseID = obj;
            llShowLicenseHistory.Enabled = (LocalLicenseID != -1);
            lblLocalLicenseID.Text = LocalLicenseID.ToString();

            if (LocalLicenseID == -1)
            {
                return;
            }

            clsLicense LocalLicense = ucDriverLicenseWithFilter1.SelectedLicense;


            if (LocalLicense == null) {

                MessageBox.Show("There is no local license with ID = " + LocalLicenseID, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (LocalLicense.IsActive == 0)
            {
                MessageBox.Show("This Local License is not Active, Choose another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ordinary Class ID = 3
            //if (!clsLicense.IsLicenceExistByPersonID(LocalLicense.DriverInfo.PersonID, 3))
            //{
            //    MessageBox.Show("This Person Dose not Have an Ordinary License,To Issue International License You must Have an Ordinary License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // Ordinary Class ID = 3
            if (LocalLicense.LicenseClassID  != 3)
            {
                MessageBox.Show("Selected License Should be Class 3, Choose Another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ActiveInternationalLicenseID = clsInternationalLicense.GetActiveLicenseIDByDriverID(LocalLicense.DriverID);

            //if (clsInternationalLicense.IsLicenceExistAndActiveByDriverID(LocalLicense.DriverID))
            //{
            //    MessageBox.Show("This Driver Already Have An Active International License " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (ActiveInternationalLicenseID != -1)
            {
                MessageBox.Show("This Driver Already Have An Active International License with ID = "+ActiveInternationalLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = ActiveInternationalLicenseID;
                llShowLicenseInfo.Enabled = true;
                return;
            }
            
                
            


            btnIssueLicense.Enabled = true;

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(_InternationalLicenseID);
            
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(ucDriverLicenseWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        


        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            clsInternationalLicense NewIntaernationalLicense = new clsInternationalLicense();

            // fill NewIntaernationalLicense Info
            NewIntaernationalLicense.IssuedUsingLocalLicenseID = ucDriverLicenseWithFilter1.LicenseID;
            NewIntaernationalLicense.DriverID = ucDriverLicenseWithFilter1.SelectedLicense.DriverID;
            NewIntaernationalLicense.IssueDate = DateTime.Now;
            NewIntaernationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            NewIntaernationalLicense.IsActive = true;
            NewIntaernationalLicense.LicenseCreatedByUserID = clsGlobal.CurrentUser.UserID;

            // fill IntaernationalLicense application Info
           NewIntaernationalLicense.ApplicantPersonID = ucDriverLicenseWithFilter1.SelectedLicense.DriverInfo.PersonID;
           NewIntaernationalLicense.ApplicationDate = DateTime.Now;
           NewIntaernationalLicense.ApplicationStatus = (int)clsApplication.enStatus.Completed;
           NewIntaernationalLicense.LastStatusDate = DateTime.Now;
           NewIntaernationalLicense.ApplicationTypeID = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationTypeID;
           NewIntaernationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees;
            NewIntaernationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            if (!NewIntaernationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("International License Issued Successfully with ID=" + NewIntaernationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblInternationalLicenseID.Text = NewIntaernationalLicense.InternationalLicenseID.ToString();
            lblApplicationID.Text = NewIntaernationalLicense.ApplicationID.ToString();

            _InternationalLicenseID = NewIntaernationalLicense.InternationalLicenseID;
            btnIssueLicense.Enabled = false;
            ucDriverLicenseWithFilter1.FilterEnabeld = false;
            llShowLicenseInfo.Enabled = true;


        }
    }
}
