using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Driving_License_Management.Licenses.LocalLicenses.Controls
{
    public partial class ucLocalDriver_sLicense : UserControl
    {

        int _LicenseID;
        clsLicense _License;

        public int LicenseID{ get { return _LicenseID; } }
        public clsLicense SelectedLicense{ get { return _License; } }

        public ucLocalDriver_sLicense()
        {
            InitializeComponent();
        }

        private void _LoadDriverImage()
        {
            string ImagePath;
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
            {
                ImagePath = @"..\..\..\Storge\Icons\Icons\Male 512.png";
            }
            else ImagePath = @"..\..\..\Storge\Icons\Icons\Female 512.png";

            string DriverImagePath = _License.DriverInfo.PersonInfo.ImagePath;
            if (DriverImagePath != "")
            {
                ImagePath = DriverImagePath;
            }

            if (File.Exists(ImagePath))
            {
                pbPersonImage.Load(ImagePath);
            }
        }
     

        public void LoadLicenseInfoByLicenseID(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.FindByLicenseID(_LicenseID);

            if (_License == null)
            {
                MessageBox.Show("Could Not Find License with ID = " + _LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblClass.Text = _License.LicenseClassInfo.ClassName;
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblFullName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblGendor.Text = (SelectedLicense.DriverInfo.PersonInfo.Gendor == 0) ? "Male" : "Female";
            lblIsActive.Text = (_License.IsActive == 1) ? "Yes" : "No";
            lblIsDetained.Text = (_License.IsDetained()) ? "Yes" : "No";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblIssueReason.Text = SelectedLicense.IssueReasonText;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblNotes.Text = _License.Notes.ToString();
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            
            _LoadDriverImage();
        }

    }
}
