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

namespace Driving_License_Management.Licenses
{
    public partial class frmPersonLicensesHistory : Form
    {
        int _PersonID = -1;

        public frmPersonLicensesHistory()
        {
            InitializeComponent();
        }
        public frmPersonLicensesHistory(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ucDriverLicenses1.CLear();
            }
            else
                ucDriverLicenses1.LoadData(_PersonID);

        }

        private void frmPersonLicensesHistory_Load(object sender, EventArgs e) {

         if (_PersonID != -1) {

                ucDriverLicenses1.LoadData(_PersonID);
                ucPersonInfoWithFilter1.LoadPersonInfo(_PersonID);
                ucPersonInfoWithFilter1.FilterEnabeled = false;
         }
            else
            {
                ucPersonInfoWithFilter1.Enabled = true;
                ucPersonInfoWithFilter1.FilterFocus();
            }

        }
        
    }
}
