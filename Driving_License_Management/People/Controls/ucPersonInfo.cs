using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Driving_License_Management.Properties;

namespace Driving_License_Management
{
    public partial class ucPersonInfo : UserControl
    {

        private clsPerson _Person;
        private int _PersonID = -1;

        public clsPerson SelectedPerson{
            get { return _Person; }
        }

        public int PersonID
        {
            get { return _PersonID; }
        }

        // Default images
        string _MaleImagePath = @"..\..\..\Storge\Icons\Icons\Male 512.png";
        string _FemaleImagePath = @"..\..\..\Storge\Icons\Icons\Female 512.png";

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.FindPerson(PersonID);

            if (_Person == null)
            {
                _RestDefualtValues();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
                   
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.FindPerson(NationalNo);

            if (_Person == null)
            {
                _RestDefualtValues();
                MessageBox.Show("No Person with NtionalNo = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();

        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            this.lblPersonID.Text = _Person.PersonID.ToString();
            this.lblFullName.Text = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}";
            this.lblNationalNo.Text = _Person.NationalNo;
            this.lblGendor.Text = (_Person.Gendor == 0) ? "Male" : "Famle";
            
            this.lblAddress.Text = _Person.Address;
            this.lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            this.lblPhone.Text = _Person.Phone;
            this.lblCountry.Text = _Person.CountryInfo.CountryName;
            this.lblEmail.Text = _Person.Email;
            this.linkLabel1.Visible = true;

            

            // For pesonal photo
            if (_Person.ImagePath != "")
            {
                if (File.Exists(_Person.ImagePath))
                {
                    this.pBox.ImageLocation = _Person.ImagePath;
                }
                else {
                    if (_Person.Gendor == 0) {
                        pBox.ImageLocation = _MaleImagePath;
                    }
                    else pBox.ImageLocation = _FemaleImagePath;

                    MessageBox.Show("Could not find this image: = " + _Person.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                       ;
                }
            }
    

        }

         private void _RestDefualtValues()
        {
            _PersonID = -1;
            this.lblPersonID.Text = "[???]";
            this.lblFullName.Text = "[???]";
            this.lblNationalNo.Text = "[???]";
            this.lblGendor.Text = "[???]";
            this.pBoxGendor.ImageLocation = _MaleImagePath;
            this.lblAddress.Text = "[???]";
            this.lblDateOfBirth.Text = "[???]";
            this.lblPhone.Text = "[???]";
            this.lblCountry.Text = "[???]";
            this.lblEmail.Text = "[???]";
            this.pBox.ImageLocation = _FemaleImagePath;
            this.linkLabel1.Visible = false;
        }
        public ucPersonInfo()
        {
            InitializeComponent();
        }

     

        private void ucPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID); 
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }

        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }



    }
}
