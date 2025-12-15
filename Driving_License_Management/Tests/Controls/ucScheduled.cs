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

namespace Driving_License_Management.Controls
{
    public partial class ucScheduled : UserControl
    {

        int _TestAppointmentID;


        clsTestAppointment _TestAppointment;
        
        clsTestType.enTestType _TestType = clsTestType.enTestType.Vision;
        public clsTestType.enTestType TestType
        {
            get { return _TestType; }
            set
            {

                _TestType = value;

                switch (_TestType)
                {
                    case clsTestType.enTestType.Vision:
                        lblTitle.Text = "Vision Test";
                        pbTestTypeImage.ImageLocation = @"..\..\..\Storge\Icons\Icons\Vision 512.png";
                        break;
                    case clsTestType.enTestType.Written:
                        lblTitle.Text = "Written Test";
                        pbTestTypeImage.ImageLocation = @"..\..\..\Storge\Icons\Icons\Written Test 512.png";
                        break;
                    case clsTestType.enTestType.Street:
                        lblTitle.Text = "Street Test";
                        pbTestTypeImage.ImageLocation = @"..\..\..\Storge\Icons\Icons\driving-test 512.png";
                        break;
                    default:
                        break;
                }
            }
        }

        int _LDLApplicationID;
        clsLocalDrivingLicenseApplication _LDLApplication;

        int _TestID = -1;

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }
        public int TestID
        {
            get { return _TestID; }
        }

        public ucScheduled()
        {
            InitializeComponent();
        }


        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            if (_TestAppointment == null)
            {

                MessageBox.Show("No Test Appointment with TestAppointmentID = " + TestAppointmentID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            _FillInfo();

        }
        private void _FillInfo()
        {

            _LDLApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            lblTestID.Text = _TestAppointment.TestID.ToString();


            _LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LDLApplicationID);

            
            if (_LDLApplication == null) {
                MessageBox.Show("No Test Local Driving License Application with ID = " + TestAppointmentID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            lblLocalDrivingLicenseAppID.Text =_LDLApplicationID.ToString();
            lblDrivingClass.Text = _LDLApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = _LDLApplication.FullName;

            lblTrial.Text = _LDLApplication.TotalTrialPerTest(TestType).ToString();
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblDate.Text = _TestAppointment.AppointmentDate.ToShortDateString();
            lblTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();

        }

    }


}
