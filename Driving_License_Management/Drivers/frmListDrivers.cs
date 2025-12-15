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
using Driving_License_Management.Licenses;

namespace Driving_License_Management.Drivers
{
    public partial class frmListDrivers : Form
    {
        DataTable _dtDrivers;
        public frmListDrivers()
        {
            InitializeComponent();
        }
          void _RefreshData()
        {
            _dtDrivers = clsDriver.GetAllDrivers();

            dgvDrivers.DataSource = _dtDrivers;
           
            lblRecordsCount.Text = _dtDrivers.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
            
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
           _RefreshData();
            if (dgvDrivers.Rows.Count > 0)
            {

                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 80;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 80;

                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 140;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 280;


                dgvDrivers.Columns[4].HeaderText = "Created Date";
                dgvDrivers.Columns[4].Width = 90;
                
                dgvDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers.Columns[5].Width = 60;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string CurrentColumn = "";

            switch (cbFilterBy.Text)
            {
                case "None":
                CurrentColumn = "None";
                break;
                case "Driver ID":
                CurrentColumn = "DriverID";
                break;
                case "Person ID":
                CurrentColumn = "PersonID";
                break;
                case "National No.":
                CurrentColumn = "NationalNo";
                break;
                case "Full Name":
                CurrentColumn = "FullName";
                break;
                default:
                    CurrentColumn = "None";
                    break;
            }

            if (CurrentColumn == "None") {

                _dtDrivers.DefaultView.RowFilter = "";
            }
           else if (CurrentColumn == "DriverID" || CurrentColumn == "PersonID")
            {
                if (string.IsNullOrWhiteSpace(txtFilterValue.Text)){
                    _dtDrivers.DefaultView.RowFilter = "";

                }
                else _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", CurrentColumn, txtFilterValue.Text.Trim());
            }
            else {
                if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
                {
                    _dtDrivers.DefaultView.RowFilter = "";

                }
                else
                {
                    try
                    {
                        _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", CurrentColumn, txtFilterValue.Text.Trim());

                    }
                    catch (Exception)
                    {
                        _dtDrivers.DefaultView.RowFilter = "1=0";

                    }

                }

            }
            lblRecordsCount.Text = _dtDrivers.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
            {
                txtFilterValue.Visible = false;
            }
            else
            {
                txtFilterValue.Visible = true;

            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Driver ID" ||  cbFilterBy.Text == "Person ID")
            {
                e.Handled =  !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            frmPersonLicensesHistory frm = new frmPersonLicensesHistory(PersonID);
            frm.ShowDialog();

        }
    }
}
