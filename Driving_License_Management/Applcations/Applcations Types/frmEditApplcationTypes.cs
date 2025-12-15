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

namespace Driving_License_Management.Applcations.Applcations_Types
{
    public partial class frmEditApplcationTypes : Form
    {

        clsApplicationType _AppType;
        public frmEditApplcationTypes(int ID)
        {
            _AppType = clsApplicationType.Find(ID);
            InitializeComponent();
        }

        private void frmEditApplcationTypes_Load(object sender, EventArgs e)
        {
            if (_AppType != null)
            {
                lbAppID.Text = _AppType.ApplicationTypeID.ToString();
                txbTitle.Text = _AppType.ApplicationTypeTitle;
                txbFees.Text = ((int)_AppType.Fees).ToString();
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox Temp = ((System.Windows.Forms.TextBox)sender);

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
            // TextBox Temp = ((TextBox)sender);
        }
        private void txbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.');
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Invalid Data", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _AppType.ApplicationTypeTitle = txbTitle.Text;
            _AppType.Fees = Convert.ToDecimal(txbFees.Text);

            if (_AppType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Faild.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
