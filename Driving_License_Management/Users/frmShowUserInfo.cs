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

namespace Driving_License_Management.Users
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int ID)
        {
            InitializeComponent();
            ucUserInformation1.LoadUserInfo(ID);
        }
    }
}
