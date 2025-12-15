using BusinessLayer;
using Driving_License_Management.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusinessLayer.clsApplication;

namespace Driving_License_Management.Controls
{
    public partial class ucSchedule : UserControl
    {
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 }

        enCreationMode _CreationMode  = enCreationMode.FirstTimeSchedule;

        clsTestAppointment _TestAppointment;
        int _TestAppointmentID = -1;

        clsLocalDrivingLicenseApplication LDLApplication;
        int _LDLApplicationID = -1;

        clsTestType.enTestType _TestType = clsTestType.enTestType.Vision;


        public clsTestType.enTestType TestType {
            get { return _TestType; }
            set {

                _TestType = value;

                switch (_TestType)
                {
                    case clsTestType.enTestType.Vision:
                        lblTitle.Text = "Vision Test";
                        gbTestType.Text = "Vision Test";
                        pbTestTypeImage.ImageLocation = @"..\..\..\Storge\Icons\Icons\Vision 512.png";
                        break;
                    case clsTestType.enTestType.Written:
                        lblTitle.Text = "Written Test";
                        gbTestType.Text = "Written Test";
                        pbTestTypeImage.ImageLocation = @"..\..\..\Storge\Icons\Icons\Written Test 512.png";
                        break;
                    case clsTestType.enTestType.Street:
                        lblTitle.Text = "Street Test";
                        gbTestType.Text = "Street Test";
                        pbTestTypeImage.ImageLocation = @"..\..\..\Storge\Icons\Icons\driving-test 512.png";
                        break;
                    default:
                        break;
                }
            }
        }


        public ucSchedule()
        {
            InitializeComponent();
        }



        public void LoadInfo(int LocalDrivingLicenseApplicationID, int TestAppointmentID = -1)
        {
            _LDLApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = TestAppointmentID;

            if (_TestAppointmentID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else { 
                _Mode= enMode.Update;
            }

            LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LDLApplicationID);
            if (LDLApplication == null)
            {

                MessageBox.Show("No Local Driving License Application ID with ID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }


            if (LDLApplication.DoseAttendTestType(_TestType))
            {
                _CreationMode = enCreationMode.RetakeTestSchedule;
            }
            else _CreationMode = enCreationMode.FirstTimeSchedule;

            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {

                gbRetakeTestInfo.Enabled = true;
                lblRetakeAppFees.Text = ((int)clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).Fees).ToString();
                lblTitle.Text = "Scheduale Retake Test";
                lblRetakeTestAppID.Text = "0";
            }
            else {

                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Scheduale Test";
                lblRetakeTestAppID.Text = "N/A";
            }

            lblLocalDrivingLicenseAppID.Text = _LDLApplicationID.ToString();
            lblDrivingClass.Text = LDLApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = LDLApplication.FullName;

            lblTrial.Text = clsTestAppointment.TotalTrialPerTest(_LDLApplicationID, TestType).ToString();
            
            if(_Mode == enMode.AddNew)
            {
                dtpTestDate.Value = DateTime.Now;
                lblFees.Text = ((int)clsTestType.Find((int)_TestType).Fees).ToString();

                _TestAppointment = new clsTestAppointment();
            }
            else
            {
                if (!_LoadTestAppointmentData()) { return; }
            }

            lblTotalFees.Text = (Convert.ToInt32(lblFees.Text) + Convert.ToInt32(lblRetakeAppFees.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint()) { 
             return;
            }

            if (!_HandleLockedTestAppointmentConstraint()) { 
             return;
            }
            if (!_HandlePreviousTestConstraint()) { 
             return;
            }



        }



        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null) {

                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            if(DateTime.Compare(DateTime.Today, _TestAppointment.AppointmentDate) > 0)
            {
                dtpTestDate.Value = DateTime.Today;
            }
            else dtpTestDate.Value = _TestAppointment.AppointmentDate;

            if(_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                gbRetakeTestInfo.Enabled = true ;
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                lblTitle.Text = "Schedule Retake Test";

            }
            return true;
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {
            if(_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveTestApointments(_LDLApplicationID, TestType))
            {
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }

            return true;
        }

        private bool _HandleLockedTestAppointmentConstraint()
        {
            if (_Mode == enMode.Update && _TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else lblUserMessage.Visible = false;
            return true;
        }

        private bool _HandlePreviousTestConstraint()
        {

            switch (_TestType)
            {
                case clsTestType.enTestType.Vision:
                    lblUserMessage.Visible = false;
                    return true;
                case clsTestType.enTestType.Written:
                    if (clsLocalDrivingLicenseApplication.DoesPassTestType(_LDLApplicationID, clsTestType.enTestType.Vision))
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                        return true;
                    }
                    lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                    lblUserMessage.Visible = true;
                    btnSave.Enabled = false;
                    dtpTestDate.Enabled = false;
                    return false;
                case clsTestType.enTestType.Street:
                    if (clsLocalDrivingLicenseApplication.DoesPassTestType(_LDLApplicationID, clsTestType.enTestType.Written))
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                        return true;
                    }
                    lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                    lblUserMessage.Visible = true;
                    btnSave.Enabled = false;
                    dtpTestDate.Enabled = false;
                    return false;
                default:
                    return false;
            }
            if (_Mode == enMode.Update && _TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else lblUserMessage.Visible = false;
            return true;
        }

        private bool _HandleRetakeTestApplication()
        {
            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {

                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = LDLApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.ApplicationStatus = Convert.ToByte(clsApplication.enStatus.Completed);
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).Fees;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (!Application.Save())
                {
                    MessageBox.Show("Faild to create application ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;

            }
            return true;
        }
        private void _ResetInfo()
        {
            lblLocalDrivingLicenseAppID.Text = "[????]";
            lblLocalDrivingLicenseAppID.Text = "[????]";
            lblDrivingClass.Text = "[????]";
            lblFullName.Text = "[????]";
            lblTrial.Text = "[????]";
            lblFees.Text = "[????]";
            dtpTestDate.MinDate = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           
            if(!_HandleRetakeTestApplication()) return;

            _TestAppointment.TestTypeID = _TestType;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLApplicationID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);

            
            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
    }

