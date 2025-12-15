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
using Driving_License_Management.Properties;

namespace Driving_License_Management.Controls
{
    public partial class ucUserInformation : UserControl
    {
        public ucUserInformation()
        {
            InitializeComponent();
        }

        private clsUser _User;
        private int _UserID = -1;

        public clsUser SelectedUser
        {
            get { return _User; }
        }

        public int UserID
        {
            get { return _UserID; }
        }
        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();

        }

        private void _FillUserInfo()
        {
            _UserID = _User.UserID;
            lbUserID.Text = _UserID.ToString();
            lbUsername.Text = _User.UserName;
            lbIsActive.Text = (_User.IsActive)? "Yes":"No";
           ucPersonInfo1.LoadPersonInfo(_User.Person.PersonID);
        }

     
    }
}
