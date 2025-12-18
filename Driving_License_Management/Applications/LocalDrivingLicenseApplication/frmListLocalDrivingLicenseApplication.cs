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
using Driving_License_Management.Tests;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Driving_License_Management.Licenses.LocalLicenses;
using Driving_License_Management.Licenses;

namespace Driving_License_Management.Applcations.LocalDrivingLicenseApplication
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {

        DataTable _dt;

        public frmListLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _dt = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgv.DataSource = _dt;
            cmbFilterBy.SelectedIndex = 0;
            txbFilter.Visible = false;
        }

        private void frmListLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            _LoadData();
            lbRecords.Text = dgv.Rows.Count.ToString();

            if (dgv.Rows.Count > 0)
            {

                dgv.Columns[0].HeaderText = "L.D.L.AppID";
                dgv.Columns[0].Width = 80;

                dgv.Columns[1].HeaderText = "Driving Class";
                dgv.Columns[1].Width = 200;

                dgv.Columns[2].HeaderText = "National No.";
                dgv .Columns[2].Width = 100;

                dgv.Columns[3].HeaderText = "Full Name";
                dgv.Columns[3].Width = 350;

                dgv.Columns[4].HeaderText = "Application Date";
                dgv.Columns[4].Width = 170;

                dgv.Columns[5].HeaderText = "Passed Tests";
                dgv.Columns[5].Width = 50;
            }


        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdataLocalDrivingLicenseApplications frm = new frmAddUpdataLocalDrivingLicenseApplications();
            frm.ShowDialog();

            //Refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedIndex == 0) { 
               txbFilter.Visible = false;
            }
            else txbFilter.Visible = true;

        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
         
            string CurrentFilter = "";
            switch (cmbFilterBy.Text)
            {
                    case "L.D.L.AppID":
                    CurrentFilter = "LocalDrivingLicenseApplicationID";
                    break;
                    case "National No.":
                    CurrentFilter = "NationalNo";
                    break;
                    case "Full Name":
                    CurrentFilter = "FullName";
                    break;
                    case "Status":
                    CurrentFilter = "Status";
                    break;

                    default:
                    CurrentFilter = "None";
                    break;
            }

            if(CurrentFilter == "None" || CurrentFilter == "" || string.IsNullOrWhiteSpace(txbFilter.Text))
            {
                _dt.DefaultView.RowFilter = "";
                lbRecords.Text = dgv.Rows.Count.ToString();
                return;
            }

            if(CurrentFilter == "LocalDrivingLicenseApplicationID")
            {
                    _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", CurrentFilter, txbFilter.Text.Trim());   
            }
            else
            {
 
                    _dt.DefaultView.RowFilter = string.Format("[{0}]  LIKE '{1}%'", CurrentFilter, txbFilter.Text.Trim());

            }
            lbRecords.Text = dgv.Rows.Count.ToString();

        }

        private void canceledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LDLApplicationID);


            if (clsApplication.FindBaseApplication(LDLApplication.ApplicationID).SetCancel())
            {
                MessageBox.Show("Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadData();
                return;

            }

            MessageBox.Show("Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            frmAddUpdataLocalDrivingLicenseApplications frm = new frmAddUpdataLocalDrivingLicenseApplications(ID);
            frm.ShowDialog();
            _LoadData();
        }

        private void showDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            frmShowLocaldrivingLicenseApplicationInfo frm = new frmShowLocaldrivingLicenseApplicationInfo(ID);
            frm.ShowDialog();
            _LoadData();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(ID);

            if (LDLApplication.Delete()) {


                MessageBox.Show("Successfuly", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadData();
                return;

            }

            MessageBox.Show("Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LDLApplicationID = (int)dgv.CurrentRow.Cells[0].Value;


            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LDLApplicationID);

            int TotalPassedTests = clsTest.GetPassedTestCount(LDLApplicationID);

            // Allow to Edit if The status is new and Person did not pass any test
            editToolStripMenuItem.Enabled = (LDLApplication.ApplicationStatus == (int)clsLocalDrivingLicenseApplication.enStatus.New) && (TotalPassedTests == 0);

            deleteToolStripMenuItem.Enabled = (LDLApplication.ApplicationStatus == (int)clsLocalDrivingLicenseApplication.enStatus.New);
            cancelToolStripMenuItem.Enabled = (LDLApplication.ApplicationStatus == (int)clsLocalDrivingLicenseApplication.enStatus.New);


            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LDLApplication.DoesPassTestType(clsTestType.enTestType.Vision); 
            bool PassedWrittenTest = LDLApplication.DoesPassTestType(clsTestType.enTestType.Written);
            bool PassedStreetTest = LDLApplication.DoesPassTestType(clsTestType.enTestType.Street);

            scheduleTestToolStrip.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LDLApplication.ApplicationStatus == (int)clsApplication.enStatus.New);


            if (scheduleTestToolStrip.Enabled)
            {
                //To Allow Schedule vision test,  Person  must not passed the same test before
                scheduleVisionTestToolStrip.Enabled = !PassedVisionTest;
                //To Allow Schedule Written test,  Person must passed the vision test and must not passed the same test before  
                scheduleWrittenTestToolStrip.Enabled = PassedVisionTest && !PassedWrittenTest;
                //To Allow Schedule Street test,  Person must passed the vision test * the Written test and must not passed the same test before  
                scheduleStreetTestToolStrip.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }

            bool LicenseExist = clsLicense.IsLicenseExistWithApplicationID(LDLApplication.ApplicationID);

            // Enable only if person passed all tests and Does not have License
            issueToolStrip.Enabled = !LicenseExist && (TotalPassedTests == 3);

            showLicenseToolStrip.Enabled = LicenseExist;



        }

       

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;

            frmListTestAppointments frm = new frmListTestAppointments(ID,clsTestType.enTestType.Vision) ;
           
            frm.ShowDialog() ;

            //Refresh
            frmListLocalDrivingLicenseApplication_Load(null,null);

        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;

            frmListTestAppointments frm = new frmListTestAppointments(ID, clsTestType.enTestType.Written);

            frm.ShowDialog();

            //Refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);



        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;

            frmListTestAppointments frm = new frmListTestAppointments(ID, clsTestType.enTestType.Street);

            frm.ShowDialog();

            //Refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);


        }

        private void issueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            frmIssueDrivingLicenceFirstTime frm = new frmIssueDrivingLicenceFirstTime(ID);
            frm.ShowDialog();
            //Refresh
            frmListLocalDrivingLicenseApplication_Load(null, null);

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(ID);

            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LDLApplication.GetActiveLicenseID());
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgv.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(ID);

            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(LDLApplication.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "L.D.L.AppID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
