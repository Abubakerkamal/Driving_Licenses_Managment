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

namespace Driving_License_Management.Licenses.LocalLicenses
{
    public partial class frmIssueDrivingLicenceFirstTime : Form
    {
   
        int _LocalDrivingLicenseApplication;
        clsLocalDrivingLicenseApplication _LDLApplication;
        public frmIssueDrivingLicenceFirstTime()
        {
            InitializeComponent();
        }
        public frmIssueDrivingLicenceFirstTime(int LocalDrivingLicenseApplication)
        {
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
            InitializeComponent();

        }

        private void LoadData()
        {
            _LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplication);

            if (_LDLApplication == null) { 
            
              MessageBox.Show("Local Driving License Application Not Found with ID = " + _LocalDrivingLicenseApplication, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
              txtNotes.Enabled = false;
              btnIssueLicense.Enabled = false;
              return;
            }

            if (!_LDLApplication.DosePassAllTest())
            {
                MessageBox.Show("This person doesn't pass all Tests", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicencseID = _LDLApplication.GetActiveLicenseID();  
            if (LicencseID > -1)
            {
                MessageBox.Show("This person already has a license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucLocalDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplication);



        }
        private void frmIssueDrivingLicenceFirstTime_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = _LDLApplication.IssueLicenseForFirstTime(txtNotes.Text, clsGlobal.CurrentUser.UserID);

            if (LicenseID > -1) {
                MessageBox.Show("The License Was Successfully Issued", "Complated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
