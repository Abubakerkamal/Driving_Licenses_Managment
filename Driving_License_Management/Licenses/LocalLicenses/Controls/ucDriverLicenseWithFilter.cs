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

namespace Driving_License_Management.Licenses.LocalLicenses.Controls
{
    public partial class ucDriverLicenseWithFilter : UserControl
    {

        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> Handler = OnLicenseSelected;

            if(Handler != null)
            {
                Handler(LicenseID);
            }
        }


        public ucDriverLicenseWithFilter()
        {
            
            InitializeComponent();
        }

        bool _FilterEnabeld = true;

        public bool FilterEnabeld
        {
            get { return _FilterEnabeld; }
            set {  _FilterEnabeld = value;
                gbFilters.Enabled = _FilterEnabeld;
            }
        }

        int _LicenseID = -1;

        public int LicenseID { get { return _LicenseID; } set { _LicenseID = value; } }
        public clsLicense SelectedLicense { get { return ucLocalDriver_sLicense1.SelectedLicense; } }


        public void LoadLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            txtLicenseID.Text = _LicenseID.ToString();
            ucLocalDriver_sLicense1.LoadLicenseInfoByLicenseID(_LicenseID);

            if(OnLicenseSelected != null && FilterEnabeld && ucLocalDriver_sLicense1.SelectedLicense != null)
            {
                OnLicenseSelected(LicenseID);
            }


        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                MessageBox.Show("You must Enter LicenseID First","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);   
                txtLicenseID.Focus();
                return;
            }
            _LicenseID = int.Parse(txtLicenseID.Text);
            LoadLicenseInfo(_LicenseID);
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e){
        
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if(e.KeyChar == 13)
            {
                btnFind.PerformClick();
            }

        }

    }
}
