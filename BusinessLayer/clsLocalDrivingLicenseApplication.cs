using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer_DLVD;


namespace BusinessLayer
{

    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        enum enMode { AddNew = 1, Update = 2 };

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo;

        enMode Mode = enMode.AddNew;
        public clsLocalDrivingLicenseApplication()
        {
            Mode = enMode.AddNew;
        }
         clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,int LicenseClassID,
             int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
           byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            PersonInfo = clsPerson.FindPerson(ApplicantPersonID);
            CreateByUserInfo = clsUser.Find(CreatedByUserID);
            ApplcationType = clsApplicationType.Find(ApplicationTypeID);
            LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);

            Mode = enMode.Update;

        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationAccess.GetAllLocalDrivigLicenseApplications();
        }

        public static bool DosePersonHaveAnActiveApplication(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationAccess.DosePersonHaveAnActiveApplication(ApplicantPersonID, LicenseClassID);
        }
        static public clsLocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LisenseClass = -1;



            bool IsFound = clsLocalDrivingLicenseApplicationAccess.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LisenseClass);

            if (IsFound)
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LisenseClass,
                    Application.ApplicationID, Application.ApplicantPersonID,Application.ApplicationDate,
                    Application.ApplicationTypeID, Application.ApplicationStatus,Application.LastStatusDate,
                    Application.PaidFees,Application.CreatedByUserID
                    );
            }
            return null;
        }

        static public clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            int LisenseClass = -1;



            bool IsFound = clsLocalDrivingLicenseApplicationAccess.GetLocalDrivingLicenseApplicationByApplicationID(ApplicationID, ref LocalDrivingLicenseApplicationID, ref LisenseClass);

            if (IsFound)
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, LisenseClass,
                    Application.ApplicationID, Application.ApplicantPersonID, Application.ApplicationDate,
                    Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID
                    );
            }
            return null;
        }

        public bool DoseAttendTestType(clsTestType.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationAccess.DoseAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestType);
        }

        public static bool IsThereAnActiveTestApointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationAccess.IsThereAnActiveTestApointment(LocalDrivingLicenseApplicationID, (int)TestType);
        }

        public  bool IsThereAnActiveTestApointments(clsTestType.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationAccess.IsThereAnActiveTestApointment(this.LocalDrivingLicenseApplicationID, (int)TestType);
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationAccess.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestType);
        }
        public bool DoesPassTestType(clsTestType.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationAccess.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestType);
        }

        public bool DosePassAllTest()
        {
            return clsTest.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }
        public int GetActiveLicenseID()
        {
            return clsLicenseAccess.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
        public clsTest GetLastTestPerTestType(clsTestType.enTestType TestType)
        {
            return clsTest.FindTestByPersonIDAndLicenseClass(this.LocalDrivingLicenseApplicationID,this.ApplicantPersonID, this.LicenseClassID, TestType);
        }

        public int TotalTrialPerTest(clsTestType.enTestType TestType)
        {
            return clsTestAppointment.TotalTrialPerTest(this.LocalDrivingLicenseApplicationID, TestType);
        }

        public int IssueLicenseForFirstTime(string Notes, int CreatedByUserID)
        {
            int DriverID;
            clsDriver Driver = clsDriver.FindByPersonID(this.PersonInfo.PersonID);

            if (Driver == null)
            {
                Driver.PersonID = this.PersonInfo.PersonID;
                Driver.CreatedTime = DateTime.Now;
                Driver.CreatedByUserID = CreatedByUserID;

                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else return -1;
            }

            else DriverID = Driver.DriverID;

            clsLicense License  = new clsLicense();

            License.DriverID = DriverID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(LicenseClassInfo.DefaultValidityLength);
            License.ApplicationID = this.ApplicationID;
            License.IssueReason = clsLicense.enIssueReason.FirstTime;
            License.LicenseClassID = this.LicenseClassID;
            License.PaidFees = LicenseClassInfo.ClassFees;
            License.CreatedByUserID = CreatedByUserID;
            License.IsActive = 1;
            License.Notes = Notes;
            if (License.Save())
            {
                this.SetComplete();
                return License.LicenseID;
            }
            return -1;


        }
        private bool _AddNew()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationAccess.AddNewLocalDrivingLicenseApplication(
                this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID > 0);
        }
        private bool _Update()
        {
            int RowAffected = clsLocalDrivingLicenseApplicationAccess.UpdateLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID,this.ApplicationID,this.LicenseClassID
                );

            return (RowAffected > 0);
        }
        public bool Delete()
        {
            int IsLocalDrivingLicenseApplicationDeleted = clsLocalDrivingLicenseApplicationAccess.DeleteLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID);
            if(IsLocalDrivingLicenseApplicationDeleted > 0)
            {
                return base.Delete();
            }
            return false;
        }
        public bool Save()
        {
            base.Mode = (clsApplication.enMode)Mode;
            if (!base.Save()) { 
            return false;   
            }
            switch (Mode)
            {
                case enMode.AddNew:
                    Mode = enMode.Update;
                    return _AddNew();

                case enMode.Update:
                    return _Update();
                default:
                   return false;
            }

        }
    }
}
