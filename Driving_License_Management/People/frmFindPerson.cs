using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management.People
{
    public partial class frmFindPerson : Form
    {
        public frmFindPerson()
        {
            InitializeComponent();
        }

        public delegate void DataBakEventHandler(object sender, int PersonID);
        public event DataBakEventHandler DataBack;

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack.Invoke(this, ucPersonInfoWithFilter1.PersonID);
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
