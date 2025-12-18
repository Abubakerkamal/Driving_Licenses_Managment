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
using Driving_License_Management.Licenses.InternationalLicenses;
using Driving_License_Management.Licenses;

namespace Driving_License_Management.Applcations.InternationalLicenseApplication
{
    public partial class frmListInternationalLicenses : Form
    {
        DataTable _dtInternationalLicenses;
        public frmListInternationalLicenses()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _dtInternationalLicenses = clsInternationalLicense.GetAllLicenses();
            dgv.DataSource = _dtInternationalLicenses;
            cmbFilterBy.SelectedIndex = 0;  
           lblInternationalLicensesRecords.Text = dgv.RowCount.ToString();

            if (dgv.Rows.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Int.License ID";
                dgv.Columns[0].Width = 160;

                dgv.Columns[1].HeaderText = "Application ID";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "Driver ID";
                dgv.Columns[2].Width = 130;

                dgv.Columns[3].HeaderText = "L.License ID";
                dgv.Columns[3].Width = 130;

                dgv.Columns[4].HeaderText = "Issue Date";
                dgv.Columns[4].Width = 180;

                dgv.Columns[5].HeaderText = "Expiration Date";
                dgv.Columns[5].Width = 180;

                dgv.Columns[6].HeaderText = "Is Active";
                dgv.Columns[6].Width = 120;

            }
        }
        private void frmListInternationalLicenses_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.SelectedIndex == 0) { 
                txbFilter.Visible =false;
                cmbIsReleased.Visible=false;
                return;
            }

            if (cmbFilterBy.SelectedIndex == 5)
            {
                txbFilter.Visible =false;
                cmbIsReleased.Visible = true;
                cmbIsReleased.SelectedIndex = 0;
                return;
            }

            txbFilter.Visible = true;
            cmbIsReleased.Visible = false;

        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "";

            switch (cmbFilterBy.Text)
            {
                case "None":
                    FilterColoumn = "None";
                    break;
                case "International License ID":
                    FilterColoumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterColoumn = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterColoumn = "DriverID";
                    break;
                case "Local License ID":
                    FilterColoumn = "IssuedUsingLocalLicenseID";
                    break;
                case "Is Active":
                    FilterColoumn = "IsActive";
                    break;

           
            }



            if(FilterColoumn == "None" || txbFilter.Text == "")
            {
                _dtInternationalLicenses.DefaultView.RowFilter = "";
                lblInternationalLicensesRecords.Text = _dtInternationalLicenses.Rows.Count.ToString();
                return;
            }

            _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColoumn,txbFilter.Text.Trim());
            lblInternationalLicensesRecords.Text = _dtInternationalLicenses.Rows.Count.ToString();




        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

        private void cmbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "IsActive";
            string FilterbValue = cmbIsReleased.Text;

            switch (FilterbValue)
            {
                case "All":
                    break ;
                case "Yes":
                    FilterbValue = "1";
                    break;
                 case "No":
                    FilterbValue = "0";
                    break ;
                default:
                    break;
            }


            if (FilterbValue == "All")
            {
                _dtInternationalLicenses.DefaultView.RowFilter = "";
                lblInternationalLicensesRecords.Text =  _dtInternationalLicenses.Rows.Count.ToString() ;
            }
            else 
            {
                _dtInternationalLicenses.DefaultView.RowFilter = $"[{FilterColoumn}] = {FilterbValue}";
                lblInternationalLicensesRecords.Text = _dtInternationalLicenses.Rows.Count.ToString();

            }
           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frmAddInternationalLicense = new frmAddInternationalLicense();
            frmAddInternationalLicense.ShowDialog();
            this.frmListInternationalLicenses_Load(null, null);
        }

        private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgv.CurrentRow.Cells[2].Value;
            int PersonID = clsDriver.FindByDriverID (DriverID).PersonID;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int IntrantionalLicenseID = (int)dgv.CurrentRow.Cells[0].Value;
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(IntrantionalLicenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgv.CurrentRow.Cells[2].Value;
            int PersonID = clsDriver.FindByDriverID(DriverID).PersonID;
            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(PersonID);
            frm.ShowDialog();
        }
    }
    }

