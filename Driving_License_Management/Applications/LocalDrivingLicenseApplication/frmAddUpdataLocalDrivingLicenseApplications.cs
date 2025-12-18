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

namespace Driving_License_Management.Applcations.LocalDrivingLicenseApplication
{
    public partial class frmAddUpdataLocalDrivingLicenseApplications : Form
    {
        enum enMode { AddNew = 1, Update =2}
        enMode _Mode = enMode.AddNew;

        int _LocalDrivingLicenseApplicationID;
        clsLocalDrivingLicenseApplication _LDLApplication;
        int _SelectedPersonID = -1;
        public frmAddUpdataLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdataLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }
        private void _FillLicenseClassesInComoboBox()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClases();

            foreach (DataRow r in dt.Rows)
            {
                cmbLicenseClass.Items.Add(r["ClassName"]);
            }

        }

        private void _ResatDefaultValues()
        {
            // This will initialize the default values.
            _FillLicenseClassesInComoboBox();


            if (_Mode == enMode.AddNew)
            {
                _LDLApplication = new clsLocalDrivingLicenseApplication();
                lbApplicationDate.Text = DateTime.Now.ToShortDateString();
                lbApplicationFees.Text = ((int)(clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocalDrivingLicenseService)).Fees).ToString();
                lbCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                cmbLicenseClass.SelectedIndex = 2;
                ucPersonInfoWithFilter1.FilterFocus();
                return;
            }

            if (_Mode == enMode.Update) {

                this.Text = "Update Local Driving License Applications";
                lbHeader.Text = "Update Local Driving License Applications";
                ucPersonInfoWithFilter1.FilterEnabeled = false;

                _LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            }


        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ucPersonInfoWithFilter1.PersonID == -1)
            {
                MessageBox.Show("You Must Choose or Add Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count - 1)
            {

                tabControl1.SelectedIndex++;
                btnSave.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {

                tabControl1.SelectedIndex--;
                btnSave.Enabled = false;

            }
        }

        private void frmAddUpdataLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            // For Design
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //-----

            _ResatDefaultValues();
            if (_Mode == enMode.Update) {
                _LoadData();
            }

        }

        
        private void _LoadData()
        {
            if (_LDLApplication == null) {
                MessageBox.Show("No Local driving license application with ID = " + _LocalDrivingLicenseApplicationID);
                return;
            }

            lbDLApplicationID.Text = _LDLApplication.LocalDrivingLicenseApplicationID.ToString();
            lbApplicationDate.Text = _LDLApplication.ApplicationDate.ToString();
            lbApplicationFees.Text = _LDLApplication.PaidFees.ToString();
            clsUser CreatedByUser = clsUser.Find(_LDLApplication.CreatedByUserID);
            lbCreatedBy.Text = CreatedByUser.UserName;

            cmbLicenseClass.SelectedIndex = cmbLicenseClass.FindString(clsLicenseClass.Find(_LDLApplication.LicenseClassID).ClassName);
            ucPersonInfoWithFilter1.LoadPersonInfo(_LDLApplication.ApplicantPersonID);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int LicenseClassID = clsLicenseClass.Find(cmbLicenseClass.Text).LicenseClassID;

            //check if user already have issued license of the same driving  class.
            if (clsLicense.IsLicenceExistByPersonID(ucPersonInfoWithFilter1.PersonID, LicenseClassID))
            {

                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LDLApplication.ApplicantPersonID = ucPersonInfoWithFilter1.PersonID;
            _LDLApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.NewLocalDrivingLicenseService;
            _LDLApplication.ApplicationDate = DateTime.Now;
            _LDLApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LDLApplication.ApplicationStatus = Convert.ToByte(clsApplication.enStatus.New);
            _LDLApplication.LastStatusDate = DateTime.Now;
            _LDLApplication.LicenseClassID = LicenseClassID;
            _LDLApplication.PaidFees = Convert.ToDecimal(lbApplicationFees.Text);
            


            if (_LDLApplication.Save())
            {
                _Mode = enMode.Update;
                this.Text = "Update Local Driving License Applications";
                lbHeader.Text = "Update Local Driving License Applications";
                ucPersonInfoWithFilter1.FilterEnabeled = false;
                MessageBox.Show("Data Saved Successfully.", "Infotmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cmbLicenseClass_Validating(object sender, CancelEventArgs e)
        {
            // The ID of current selected Licnese class
            int LicenseClassID = clsLicenseClass.Find(cmbLicenseClass.Text).LicenseClassID;

            // Chech if selected person has an active application for this class
            if (clsLocalDrivingLicenseApplication.DosePersonHaveAnActiveApplication(ucPersonInfoWithFilter1.PersonID, LicenseClassID))
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbLicenseClass, "This person already has an active application for this class");
                return;
            }
            errorProvider1.SetError(cmbLicenseClass, null);

        }

        private void frmAddUpdataLocalDrivingLicenseApplications_Activated(object sender, EventArgs e)
        {
            ucPersonInfoWithFilter1.FilterFocus();
        }
    }
}
