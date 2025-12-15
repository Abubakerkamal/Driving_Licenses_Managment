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
using Driving_License_Management.GlobalClasses;

namespace Driving_License_Management
{
    public partial class frmPeopleList : Form
    {
        public frmPeopleList()
        {
            InitializeComponent();
        }



        DataTable _dt;

        private void _RefreshPepoleData()
        {
            DataTable AllData = clsPerson.GetAllPeople();

            // Select only the data you want to show
            _dt = AllData.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gendor", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
            dgv.DataSource = _dt;

            lbRecords.Text = dgv.RowCount.ToString();

        }
        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            _RefreshPepoleData();

            cmpFilterBy.SelectedIndex = 0;
            txbFilter.Visible = false;

            if (dgv.Rows.Count > 0) {

                dgv.Columns[0].HeaderText = "Person ID";
                dgv.Columns[0].Width = 80;

                dgv.Columns[1].HeaderText = "National No.";
                dgv.Columns[1].Width = 120;


                dgv.Columns[2].HeaderText = "First Name";
                dgv.Columns[2].Width = 120;

                dgv.Columns[3].HeaderText = "Second Name";
                dgv.Columns[3].Width = 140;


                dgv.Columns[4].HeaderText = "Third Name";
                dgv.Columns[4].Width = 120;

                dgv.Columns[5].HeaderText = "Last Name";
                dgv.Columns[5].Width = 120;

                dgv.Columns[6].HeaderText = "Gendor";
                dgv.Columns[6].Width = 50;

                dgv.Columns[7].HeaderText = "Date Of Birth";
                dgv.Columns[7].Width = 140;

                dgv.Columns[8].HeaderText = "Nationality";
                dgv.Columns[8].Width = 120;


                dgv.Columns[9].HeaderText = "Phone";
                dgv.Columns[9].Width = 120;


                dgv.Columns[10].HeaderText = "Email";
                dgv.Columns[10].Width = 170;
             

            }

        }

        private void cmpFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txbFilter.Visible = (cmpFilterBy.Text != "None");

            if (txbFilter.Visible) {
                txbFilter.Text = "";
                txbFilter.Focus();
            }
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn = "";

            // Map selected filter to real column name
            switch (cmpFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.

            if (txbFilter.Text.Trim() == "" || FilterColumn == "None")
                {
                    _dt.DefaultView.RowFilter = "";
                    lbRecords.Text =  dgv.Rows.Count.ToString();
                    return;
                }

              
               else if (FilterColumn == "PersonID")
                {
                     //In this case we deal with integer
                    _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txbFilter.Text.Trim());

                }

                else {

                //In this case we deal with string
                _dt.DefaultView.RowFilter = string.Format("[{0}] LIKE  '{1}%'", FilterColumn, txbFilter.Text.Trim());

                }

                lbRecords.Text = dgv.RowCount.ToString();

            

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            _RefreshPepoleData();
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];
                
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgv.CurrentRow.Cells[0].Value;

            int CurrentRow = (int)dgv.CurrentRow.Index;
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefreshPepoleData();     
            // Focus on Updated Row
             dgv.CurrentCell = dgv.Rows[CurrentRow].Cells[0];
        }

        private void showDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails((int)dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _RefreshPepoleData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonID = (int)dgv.CurrentRow.Cells[0].Value;
            int CurrentIndex = (int)dgv.CurrentRow.Index;

            if ((MessageBox.Show($"Are you sure you want delete this Person[{PersonID}]", "Conferm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes))
            {

                if (clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Deleted Successfuly", "Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _RefreshPepoleData();

                    clsUtil.FoucsOnPreviousRow(ref dgv, CurrentIndex);

                }
                else
                {
                    MessageBox.Show("Deleted Faild, You can not delete this Person Because it has Data likned to it", "Delete",MessageBoxButtons.OK,MessageBoxIcon.Error);

                } 
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(cmpFilterBy.Text == "Person ID")
            {
                //  only number and control received from the keyboard
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            int PersonID = (int)dgv.CurrentRow.Cells[0].Value;
            Form frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();
        }
    }
}
