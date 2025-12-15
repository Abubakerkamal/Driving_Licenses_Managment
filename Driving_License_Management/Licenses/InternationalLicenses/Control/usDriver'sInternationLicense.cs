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
using System.IO;

namespace Driving_License_Management.Licenses.InternationalLicenses.Control
{
    public partial class usDriver_sInternationLicense : UserControl
    {

        int _InterNationalLicenseID = -1;
        clsInternationalLicense _InternationalLicense;
        public usDriver_sInternationLicense()
        {
            InitializeComponent();
        }


        private void _LoadPersonImage()
        {
            string ImagePath;
            if (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0) {
                ImagePath = @"..\..\..\Storge\Icons\Icons\Male 512.png";
            }
            else {
               ImagePath = @"..\..\..\Storge\Icons\Icons\Female 512.png";
            }


            string PersonImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;
            if (PersonImagePath != "")
            {
                ImagePath = PersonImagePath;
            }

            if (File.Exists(ImagePath)) {

                pbPersonImage.Load(ImagePath);
            }
        }
        public void LoadDate(int InterNationalLicenseID)
        {
            _InterNationalLicenseID = InterNationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(_InterNationalLicenseID);

            if (_InternationalLicense == null) {

                MessageBox.Show("There is not International License  with ID = " + InterNationalLicenseID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            
            }

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblFullName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblIssueDate.Text =_InternationalLicense.IssueDate.ToShortDateString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();

            _LoadPersonImage();
        }
    }
}
