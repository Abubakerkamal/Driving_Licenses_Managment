using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.Controls
{
    public partial class ucPersonInfoWithFilter : UserControl
    {
        public ucPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnPersonSelected;

        protected virtual void  PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if(Handler != null)
            {
                Handler(PersonID);
            }
        }
        private void ucPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cmpFindby.SelectedIndex = 0;
        }

        bool _ShowBtnAddPerson = true;
        public bool ShowBtnAddPerson
        {
            get { return _ShowBtnAddPerson; }
            set
            {
                _ShowBtnAddPerson = value;
                btnAddNewPerson.Visible = _ShowBtnAddPerson;
            }
        }

        bool _FilterEnabeled = true;

        public bool FilterEnabeled
        {
            get { return _FilterEnabeled; }
            set
            {
                _FilterEnabeled = value;
                gbFilter.Enabled = _FilterEnabeled;
            }
        }

        private int _PersonID = -1;

        public int PersonID
        {
            get { return ucPersonInfo1.PersonID; }
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        public void BtnFindFocus()
        {
            btnFind.Focus();
        }
        public void LoadPersonInfo(int PersonID)
        {
            cmpFindby.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }

        void FindNow()
        {
            switch (cmpFindby.Text)
            {
                case "Person ID":
                    ucPersonInfo1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "National No":
                    ucPersonInfo1.LoadPersonInfo(txtFilterValue.Text.ToString());
                    break;
            }

            if(OnPersonSelected != null && FilterEnabeled)
            {
                OnPersonSelected (ucPersonInfo1.PersonID);
            }
        }

        private void cmpFindby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            FindNow();

        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += GetNewPersonInfo;
            frm.ShowDialog();

        }

        void GetNewPersonInfo(object sender, int PersonID)
        {
            cmpFindby.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)133)
            {
                btnFind.PerformClick();
            }

            if (cmpFindby.SelectedIndex == 0) {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }

     
    }
}
