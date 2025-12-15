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

namespace Driving_License_Management.Tests.TestTypes
{
    public partial class frmEditTestType : Form
    {

        clsTestType _TestType;
        public frmEditTestType(int ID)
        {
            _TestType = clsTestType.Find(ID);
            InitializeComponent();
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
            _TestType.TestTypeTitle = txbTitle.Text;
            _TestType.TestTypeDescription = txbDescription.Text;
            _TestType.Fees = Convert.ToDecimal(txbFees.Text);

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Faild.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            if (_TestType != null)
            {
                lbTestID.Text = _TestType.TestTypeID.ToString();
                txbTitle.Text = _TestType.TestTypeTitle;
                txbDescription.Text = _TestType.TestTypeDescription;
                txbFees.Text = ((int)_TestType.Fees).ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
