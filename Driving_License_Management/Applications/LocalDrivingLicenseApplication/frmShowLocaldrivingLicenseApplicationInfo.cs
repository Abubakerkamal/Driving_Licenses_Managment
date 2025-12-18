using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Applcations.LocalDrivingLicenseApplication
{
    public partial class frmShowLocaldrivingLicenseApplicationInfo : Form
    {
        int _LDLAplicationID;
        public frmShowLocaldrivingLicenseApplicationInfo(int lDLAplicationID)
        {
            InitializeComponent();
            _LDLAplicationID=lDLAplicationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowLocaldrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ucLocalDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LDLAplicationID);
        }
    }
}
