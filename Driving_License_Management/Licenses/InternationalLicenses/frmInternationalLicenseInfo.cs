using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Licenses.InternationalLicenses
{
    public partial class frmInternationalLicenseInfo : Form
    {
        int _InternationalLicenseID;
        public frmInternationalLicenseInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            usDriver_sInternationLicense1.LoadDate(_InternationalLicenseID);
        }
    }
}
