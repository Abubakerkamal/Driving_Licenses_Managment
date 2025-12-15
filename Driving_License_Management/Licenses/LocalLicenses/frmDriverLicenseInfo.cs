using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Licenses.LocalLicenses
{
    public partial class frmDriverLicenseInfo : Form
    {
        int _LicenseID;
        public frmDriverLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
        }

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ucLocalDriver_sLicense1.LoadLicenseInfoByLicenseID(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
