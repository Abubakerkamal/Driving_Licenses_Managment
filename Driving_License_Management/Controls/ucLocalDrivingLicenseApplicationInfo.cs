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

namespace Driving_License_Management.Controls
{
    public partial class ucLocalDrivingLicenseApplicationInfo : UserControl
    {
        clsLocalDrivingLicenseApplication LDLApplication;
        int LocalDrivingLicenseApplicationID;
        public ucLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
        {
            LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
            if (LDLApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        public void LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            LDLApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);
            if (LDLApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }
        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            LocalDrivingLicenseApplicationID = LDLApplication.LocalDrivingLicenseApplicationID;
            lblLocalDrivingLicenseApplicationID.Text = LocalDrivingLicenseApplicationID.ToString();
            lblAppliedFor.Text = clsLicenseClass.Find(LDLApplication.LicenseClassID).ClassName ;
            lblPassedTests.Text = clsTest.GetPassedTestCount(LDLApplication.LocalDrivingLicenseApplicationID).ToString();
            ucApplicationBasicInfo1.LoadApplicationInfo(LDLApplication.ApplicationID);
        }
        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            LocalDrivingLicenseApplicationID = -1;
            ucApplicationBasicInfo1.ResetApplicationInfo();
            lblLocalDrivingLicenseApplicationID.Text = "[????]";
            lblAppliedFor.Text = "[????]";


        }

        private void llShowLicenceInfo_Click(object sender, EventArgs e)
        {
            if (!clsLicense.IsLicenseExistWithApplicationID(LDLApplication.ApplicationID)) {

                MessageBox.Show("An erro occurred, Not has Licence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LDLApplication.ApplicationID);
            frm.ShowDialog();
        }
    }
}
