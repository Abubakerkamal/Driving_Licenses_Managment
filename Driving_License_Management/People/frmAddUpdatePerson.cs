using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Driving_License_Management.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.ConstrainedExecution;
using Driving_License_Management.GlobalClasses;


namespace Driving_License_Management
{
    public partial class frmAddUpdatePerson : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        int _PersonID = -1;
        enMode _Mode;
        clsPerson _Person;

        //This Default Images
         string _MaleImagePath = @"..\..\..\Storge\Icons\Icons\Male 512.png";
         string _FemaleImagePath = @"..\..\..\Storge\Icons\Icons\Female 512.png";

        public delegate void DataBakEventHandler(object sender, int PersonID);

        public event DataBakEventHandler DataBack;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdatePerson(int ID)
        {
            InitializeComponent();

            _PersonID = ID;
            _Mode = enMode.Update;
           
        }

        private void _FillcmbCountrey()
        {
            DataTable dt = clsCountry.GetAllCountries();

            foreach (DataRow item in dt.Rows)
            {
                cmbCountries.Items.Add(item["CountryName"]);
            }
        }

        //for maxmium and minimum birth Date
        private void BirthDateSetting()
        {
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-100);


        }


        private void _ResetDefultValues()
        {
            _FillcmbCountrey();
            BirthDateSetting();

            if (_Mode == enMode.AddNew)
            {
                cmbCountries.SelectedIndex = cmbCountries.FindString("Sudan");
                lblTitle.Text = "Add New Person";
                this.Text = lblTitle.Text;
            }

            _Person = new clsPerson();

            rbMale.Checked = true;
            pBoxPersonImage.ImageLocation = _MaleImagePath;
            txbFirstN.Text = "";
            txbSecondN.Text = "";
            txbThirdN.Text = "";
            txbLastN.Text = "";
            txbNationalNo.Text = "";
            txbEmail.Text = "";
            txbPhone.Text = "";
            txbAddress.Text = ""; 

            // Dont Show the bottum if the image is the default image or there is no image
            lblRemove.Visible = (pBoxPersonImage.ImageLocation != _MaleImagePath && pBoxPersonImage.ImageLocation != _FemaleImagePath && pBoxPersonImage.ImageLocation != null);

            
        }
        private void _LoadData()
        {
            

                _Person = clsPerson.FindPerson(_PersonID);



                if (_Person != null)
                {
                    
                    lblTitle.Text = " Update Person";
                this.Text = lblTitle.Text;

                    lblPersonID.Text = _PersonID.ToString();
                    txbFirstN.Text = _Person.FirstName;
                    txbSecondN.Text = _Person.SecondName;
                    txbThirdN.Text = _Person.ThirdName;
                    txbLastN.Text = _Person.LastName;
                    txbNationalNo.Text = _Person.NationalNo;


                    if (_Person.Gendor == 0)
                    {
                        rbMale.Checked = true;
                    }
                    else rbFamale.Checked = true;

                    txbEmail.Text = _Person.Email;
                    txbAddress.Text = _Person.Address;
                    dtpDateOfBirth.Value = _Person.DateOfBirth;
                    txbPhone.Text = _Person.Phone;
                    cmbCountries.SelectedValue = _Person.NationalityCountryID;

                    cmbCountries.SelectedIndex = cmbCountries.FindString(_Person.CountryInfo.CountryName);

                if(_Person.ImagePath != null)  pBoxPersonImage.ImageLocation = _Person.ImagePath;

                lblRemove.Visible = (_Person.ImagePath != null);

            }




        }
        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            
                _ResetDefultValues();
                if (_Mode == enMode.Update) _LoadData();
            
        }


   

        //for set Personal Image
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Title";
            openFileDialog1.DefaultExt = "jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pBoxPersonImage.ImageLocation = openFileDialog1.FileName;
            }
            lblRemove.Visible = true;


        }
        //for remove the personal image
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(rbMale.Checked) pBoxPersonImage.ImageLocation = _MaleImagePath;

            else pBoxPersonImage.ImageLocation = _FemaleImagePath;

            lblRemove.Visible =false;   
        }

     


        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pBoxPersonImage.ImageLocation == null || pBoxPersonImage.ImageLocation == _FemaleImagePath)
            {
                pBoxPersonImage.ImageLocation = _MaleImagePath;
            }
        }

        private void rbFamale_CheckedChanged(object sender, EventArgs e)
        {
            if (pBoxPersonImage.ImageLocation == null || pBoxPersonImage.ImageLocation == _MaleImagePath) {
                pBoxPersonImage.ImageLocation = _FemaleImagePath;
            }
        }



        //For Inputs validate
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox Temp = ((System.Windows.Forms.TextBox)sender);

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txbNationalNoValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNationalNo, "This field is required");
            }


            else if (txbNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsExist(txbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNationalNo, "This National Number Already Exist");
            }
            else
            {
                errorProvider1.SetError(txbNationalNo, null);
            }
        }

        private void txbEmailValidating(object obj, CancelEventArgs e)
        {
            if (txbEmail.Text.Trim() == "")
                return;
            if (!clsValidation.IsValidEmail(txbEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txbEmail, null);
            };
        }



       



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pBoxPersonImage.ImageLocation) {

                if (_Person.ImagePath != null) {

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {

                    }
                }
            
            }

            if (pBoxPersonImage.ImageLocation != _MaleImagePath && pBoxPersonImage.ImageLocation != _FemaleImagePath && pBoxPersonImage.ImageLocation != null) { 
            
            
                string sourceFile = pBoxPersonImage.ImageLocation.ToString();

                if (clsUtil.CopeyFileToProjectFolder(ref sourceFile))
                {
                    pBoxPersonImage.ImageLocation = sourceFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Invalid Data", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage()) return; 


            _Person.NationalNo = txbNationalNo.Text.Trim();
            _Person.FirstName = txbFirstN.Text.Trim();
            _Person.SecondName = txbSecondN.Text.Trim();
            _Person.ThirdName = txbThirdN.Text.Trim();
            _Person.LastName = txbLastN.Text.Trim();
            _Person.Address = txbAddress.Text.Trim();
            _Person.Email = txbEmail.Text.Trim();
            _Person.Phone = txbPhone.Text.Trim();
            _Person.Gendor = (rbMale.Checked) ? Convert.ToByte(0) : Convert.ToByte(1);
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.NationalityCountryID = cmbCountries.SelectedIndex + 1;
            _Person.ImagePath = pBoxPersonImage.ImageLocation; //pB = pictureBox

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblTitle.Text = " Update Person";
                this.Text = "Update Person";
                _PersonID = _Person.PersonID;
                lblPersonID.Text = _PersonID.ToString();

                DataBack?.Invoke(this, _PersonID);
            }
            else
            {
                MessageBox.Show("Data Saved Faild.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
        private void txbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
