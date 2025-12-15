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
    public partial class ucApplicationBasicInfo : UserControl
    {

        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }

        clsApplication _Application;

        public int ApplicationID;


        private void _FillApplicationInfo()
        {
            ApplicationID =  _Application.ApplicationID;
            lblApplicationID.Text = ApplicationID.ToString();
            lblApplicant.Text = _Application.ApplicantPersonID.ToString();
            lblCreatedByUser.Text = _Application.CreateByUserInfo.UserName.ToString();
            lblDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblFees.Text = _Application.PaidFees.ToString();
            lblStatus.Text = _Application.StatusText;
            lblStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            lblType.Text = _Application.ApplcationType.ApplicationTypeTitle;
            
        }

        public void ResetApplicationInfo()
        {
            ApplicationID = -1;

            lblApplicationID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblType.Text = "[????]";
            lblFees.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";

        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.FindBaseApplication(ApplicationID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
