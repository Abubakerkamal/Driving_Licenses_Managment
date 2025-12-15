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
using Driving_License_Management.Applcations.Applcations_Types;
using Driving_License_Management.Applcations.LocalDrivingLicenseApplication;
using Driving_License_Management.Applcations.RenewLocalDrivingLicense;
using Driving_License_Management.Applcations.ReplaceLostOrDamagedLicense;
using Driving_License_Management.Applcations.ReleaseDetainedLicenses;
using Driving_License_Management.GlobalClasses;
using Driving_License_Management.Tests.TestTypes;
using Driving_License_Management.Users;
using Driving_License_Management.Drivers;
using Driving_License_Management.Licenses.DatinedLicenses;
using Driving_License_Management.Applcations.InternationalLicenseApplication;
using Driving_License_Management.Login;


namespace Driving_License_Management
{
    public partial class frmMain : Form
    {
        int UserID = -1;
        frmLogin _LoginScreen;
        clsUser _User = clsGlobal.CurrentUser;

        public frmMain(frmLogin LoginScreen)
        {
            _LoginScreen = LoginScreen;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.AutoScaleMode = AutoScaleMode.Dpi;


            if (_User != null) {
            lbPersonName.Text = _User.Person.FirstName + " " + _User.Person.SecondName;
                if (_User.Person.ImagePath != null) {
                    pBPersonPhoto.ImageLocation = _User.Person.ImagePath;
                }
            
            }

        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleList form2 = new frmPeopleList();
            form2.ShowDialog();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
       
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersLists frm = new frmUsersLists();
            frm.ShowDialog();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(_User.UserID);
            frm.ShowDialog();
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1))
            {
                _LoginScreen.Show();
                clsGlobal.CurrentUser = null;
                this.Close();
            }
        }

        private void manageApplicationsTypsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplcationsTypes frm = new frmListApplcationsTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdataLocalDrivingLicenseApplications frm = new frmAddUpdataLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenwLocalDrivingLicense frm = new frmRenwLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void replacemrntForLosOrDamegedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicense frm = new frmReplaceLostOrDamagedLicense();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frm = new frmAddInternationalLicense();
            frm.ShowDialog();   
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplication frm = new frmListLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicenses frm = new frmListInternationalLicenses();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicenses frm = new frmDetainLicenses();
            frm.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLisenses frm = new frmReleaseDetainedLisenses();
            frm.ShowDialog();   
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplication frm = new frmListLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void reaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLisenses frm = new frmReleaseDetainedLisenses();
            frm.ShowDialog();
        }
    }
}
