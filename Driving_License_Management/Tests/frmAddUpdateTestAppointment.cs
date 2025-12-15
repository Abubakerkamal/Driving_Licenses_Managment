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

namespace Driving_License_Management.Tests
{
    public partial class frmAddUpdateTestAppointment : Form
    {
        int _TestAppointmentID;
        int _LocalDrivingLicenseApplicationID;
        clsTestType.enTestType _TestType;

        public frmAddUpdateTestAppointment(int LocalDrivingLicenseApplicationID,
      clsTestType.enTestType TestType,
      int TestAppointmentID = -1)
        {
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType= TestType;
            _TestAppointmentID = TestAppointmentID;

            InitializeComponent();

        }

        private void frmAddTestAppointment_Load(object sender, EventArgs e)
        {
            ucSchedule1.TestType = _TestType;
            ucSchedule1.LoadInfo(_LocalDrivingLicenseApplicationID, _TestAppointmentID);
        }
    }
}
