using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Driving_License_Management.Applcations.Applcations_Types;
using Driving_License_Management.Applcations.LocalDrivingLicenseApplication;
using Driving_License_Management.Applcations.RenewLocalDrivingLicense;
using Driving_License_Management.Applcations.ReplaceLostOrDamagedLicense;
using Driving_License_Management.Login;
using Driving_License_Management.People;
using Driving_License_Management.Users;
using Driving_License_Management.Licenses;
using Driving_License_Management.Applcations.InternationalLicenseApplication;

namespace Driving_License_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetCompatibleTextRenderingDefault(false);

           
            Application.Run(new frmLogin());    
        }
    }
}
