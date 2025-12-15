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

namespace Driving_License_Management.Login
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "";
            string Password = "";


            if (clsGlobal.GetStoredCredintial(ref Username, ref Password)) {

                txtUserName.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;
            }
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
         

            clsUser _User = clsUser.FindByUsernameAndPassword(txtUserName.Text,txtPassword.Text);

            if (_User == null) {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!_User.IsActive))
            {


                txtUserName.Focus();
                MessageBox.Show("Your account is not Active, Contact Admin.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (chkRememberMe.Checked)
                // store Username and password
                clsGlobal.RememberMeUsernameAndPassword(txtUserName.Text, txtPassword.Text);

            // store empty Username and password

            else clsGlobal.RememberMeUsernameAndPassword("", "");





            clsGlobal.CurrentUser = _User;
            this.Hide();
            frmMain frm = new frmMain(this);
            frm.ShowDialog();

            // if you logout you will back to the login screen if you close the form without logout you will finsh the program 
            if(clsGlobal.CurrentUser == null)
            {
                return;
            }
            this.Close();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
