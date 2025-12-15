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

namespace Driving_License_Management
{
    public partial class frmPersonDetails : Form
    {

        int _PersonID;
     
        public frmPersonDetails(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ucPersonInfo1.LoadPersonInfo(_PersonID);
        }

        


       
    }
}
