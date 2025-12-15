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

namespace Driving_License_Management.Tests
{
    public partial class frmTakeTest : Form
    {

        private int _TestAppointmentID;
        private clsTestType.enTestType _TestType;

        private int _TestID = -1;
        private clsTest _Test;

       

   
        public frmTakeTest(int TestAppointmentID, clsTestType.enTestType TestType)
        {
            _TestAppointmentID = TestAppointmentID;
            _TestType = TestType;
            InitializeComponent();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {

                ucScheduled1.TestType = _TestType;
                ucScheduled1.LoadInfo(_TestAppointmentID);
                
                _TestID = ucScheduled1.TestID;
            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult == 1)
                    rbPass.Checked = true;

                else rbFaild.Checked = true;

                txbNotes.Text = _Test.Notes;

                rbFaild.Enabled = false;
                rbPass.Enabled = false;
            }

            else
                _Test = new clsTest();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
            )
            {
                return;
            }

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.Notes = txbNotes.Text;
            _Test.TestResult = Convert.ToByte((rbPass.Checked) ? 1 : 0);
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsTestAppointment.Lock(_TestAppointmentID);
                rbFaild.Enabled = false;
                rbPass.Enabled = false;
            
            }
            else
            {
                MessageBox.Show("Don't Saved Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
