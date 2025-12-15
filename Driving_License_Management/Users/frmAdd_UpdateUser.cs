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

namespace Driving_License_Management.Login
{
    public partial class frmAdd_UpdateUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;


        int _UserID;
        clsUser _User;

        public frmAdd_UpdateUser()
        {
            InitializeComponent();

            _User = new clsUser();
            _Mode = enMode.AddNew;


        }

        public frmAdd_UpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;

        }
        private void _ReastDefualtValues()
        {
            if (_Mode == enMode.AddNew) {

                lbHeader.Text = "Add New User";
                this.Text = lbHeader.Text;
                _User = new clsUser();
                ucPersonInfoWithFilter1.FilterFocus();

            }

            else if (_Mode == enMode.Update) {

                lbHeader.Text = "   Update User";
                this.Text = this.Text = "Update User";
                ucPersonInfoWithFilter1.FilterFocus();
                ucPersonInfoWithFilter1.FilterEnabeled = false;
                _User = clsUser.Find(_UserID);
                _LoadData();
            }
            btnSave.Enabled = false;


        }


        private void _LoadData()
        {
            if (_User == null) { return; }
            ucPersonInfoWithFilter1.LoadPersonInfo(_User.Person.PersonID);
            lbUserID.Text = _User.UserID.ToString();
            txbUsername.Text = _User.UserName;
            txbPassword.Text = _User.Password;
            txbConfirmPassword.Text = _User.Password;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

        

            if(_Mode == enMode.Update)
            {
                // go to the next tab
                tabControl1.SelectedIndex++;
                btnSave.Enabled = true;
            }

            if (ucPersonInfoWithFilter1.PersonID != -1)
            {

                if (!clsUser.IsUserExistWithPersonID(ucPersonInfoWithFilter1.PersonID))
                {
                    // go to the next tab
                    tabControl1.SelectedIndex++;
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show("The person you selected is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else { 
                MessageBox.Show("You Must Choose or Add Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            
            
            
            
        
            

        }

        private void frmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _ReastDefualtValues();

            // For Taps Design
            this.Size = new System.Drawing.Size(880, 560);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            

            

        
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           
                // Go to the previous tap
                tabControl1.SelectedIndex--;
                btnSave.Enabled = false;

        }

        private void txbUsername_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbUsername, "This field requaierd!");
                return;
            }

            if (txbUsername.Text.Contains(" "))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbUsername, "Username must not contain a space!");
                return;
            }


            if (_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserExist(txbUsername.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txbUsername, "Username Already Exist!");
                    return;
                }

            }
            else
            {
                // Update mode

                if (txbUsername.Text != _User.UserName)
                {
                    if (clsUser.IsUserExist(txbUsername.Text))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txbUsername, "Username Already Exist!");
                        return;
                    }
                    errorProvider1.SetError(txbUsername, null);

                }
            }

        }



        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbPassword, "This field requaierd!");
                return;
            }
            errorProvider1.SetError(txbPassword, null);


        }

        private void txbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbConfirmPassword, "This field requaierd!");
                return;
            }


            if (txbConfirmPassword.Text != txbPassword.Text) {

                e.Cancel = true;
                errorProvider1.SetError(txbConfirmPassword, "Not Matching!");
                return;
            }

            errorProvider1.SetError(txbConfirmPassword, null);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                return;
            }

            _User.UserName = txbUsername.Text.ToString();
            _User.Password = txbPassword.Text;
            _User.IsActive = chkIsActive.Checked;
            _User.Person = clsPerson.FindPerson(ucPersonInfoWithFilter1.PersonID);

            if (_User.Save())
            {
                _Mode = enMode.Update;
                lbHeader.Text = "   Update User";
                lbUserID.Text = _User.UserID.ToString();

                MessageBox.Show("Data Saved Successfuly","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("An error, Occurred");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
