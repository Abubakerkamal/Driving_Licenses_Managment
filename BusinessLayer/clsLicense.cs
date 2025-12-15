using DataAccessLayer_DLVD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public clsDriver DriverInfo;
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public byte IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }
        public static string GetIssueReasonText(enIssueReason IssueReason)
                {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }

        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }    
        public int CreatedByUserID { set; get; }

        public clsDetainedLicense DetainedInfo;


        public clsLicense() {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = 0;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;
            this.DriverInfo = null;

            Mode = enMode.AddNew;
        }

        public clsLicense(int licenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, byte isActive, enIssueReason issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            DriverInfo = clsDriver.FindByDriverID(DriverID);
            LicenseClassID = licenseClassID;
            LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            DetainedInfo = clsDetainedLicense.FindByLicenseID(this.LicenseID);
        }

        bool _AddNew()
        {
            LicenseID = clsLicenseAccess.AddNew(ApplicationID, DriverID,
                LicenseClassID, IssueDate, ExpirationDate, Notes,PaidFees,IsActive,Convert.ToByte(IssueReason),CreatedByUserID);
            return (LicenseID > 0);
        }

        private bool _Update()
        {
            //call DataAccess Layer 

            return clsLicenseAccess.Update(this.ApplicationID, this.LicenseID, this.DriverID, this.LicenseClassID,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }
        static public bool IsLicenseExistWithApplicationID(int ApplicationID)
        {
            return clsLicenseAccess.IsLicenseExistWithApplicationID(ApplicationID);
        }
        static public clsLicense FindByApplicationID(int ApplicationID)
        {

            int LicenseID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees =0;
            byte IsActive = 0;
            byte IssueReason = 0;
            int CreatedByUserID = 0;

            bool IsFound = clsLicenseAccess.GetLicenseInfoByApplicationID(ApplicationID, ref LicenseID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
             ref Notes, ref PaidFees, ref IsActive, ref IssueReason,
             ref CreatedByUserID);

            if (IsFound)
            {
                return new clsLicense(LicenseID,ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate,  Notes, PaidFees, IsActive,(enIssueReason) IssueReason,CreatedByUserID);
            }
            return null;
        }

        static  public bool IsLicenceExistByPersonID(int PersonID, int ClassLicenseID) {
        
            return (clsLicenseAccess.GetActiveLicenseIDByPersonID(PersonID, ClassLicenseID) > -1);
        }
        static public clsLicense FindByLicenseID(int LicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            byte IsActive = 0;
            byte IssueReason = 0;
            int CreatedByUserID = 0;

            bool IsFound = clsLicenseAccess.GetLicenseInfoByLicenseID(LicenseID, ref  ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
             ref Notes, ref PaidFees, ref IsActive, ref IssueReason,
             ref CreatedByUserID);

            if (IsFound)
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,(enIssueReason)IssueReason, CreatedByUserID);
            }
            return null;
        }
        static public DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicenseAccess.GetDriverLicenses(DriverID);
        }


        public clsLicense RenewLicense(string Notes,int CreatedByUserID)
        {
            clsApplication RenwApplication = new clsApplication();

            RenwApplication.ApplicantPersonID = this.DriverInfo.PersonID;
            RenwApplication.ApplicationDate = DateTime.Now;
            RenwApplication.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            RenwApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.RenewDrivingLicenseService;
            RenwApplication.CreatedByUserID = CreatedByUserID;
            RenwApplication.LastStatusDate = DateTime.Now;
            RenwApplication.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicenseService).Fees;

            if (!RenwApplication.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = RenwApplication.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = 1;
            NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;


            if (!NewLicense.Save())
            {
                return null ;
            }

            DeactivateCurrentLicense();

            return NewLicense;
        }

        public clsLicense ReplaceLicense(enIssueReason IssueReason, int CreatedByUserID)
        {
            clsApplication RenwApplication = new clsApplication();

            RenwApplication.ApplicantPersonID = this.DriverInfo.PersonID;
            RenwApplication.ApplicationDate = DateTime.Now;
            RenwApplication.ApplicationStatus = (int)clsApplication.enStatus.Completed;
            RenwApplication.ApplicationTypeID = (IssueReason == enIssueReason.DamagedReplacement)? (int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense:
                (int)clsApplication.enApplicationType.ReplacementforaLostDrivingLicense;
   
            RenwApplication.PaidFees = clsApplicationType.Find(RenwApplication.ApplicationTypeID).Fees;
            RenwApplication.CreatedByUserID = CreatedByUserID;
            RenwApplication.LastStatusDate = DateTime.Now;

            if (!RenwApplication.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = RenwApplication.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = 1;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = CreatedByUserID;


            if (!NewLicense.Save())
            {
                return null;
            }

            DeactivateCurrentLicense();

            return NewLicense;
        }

        private bool DeactivateCurrentLicense()
        {
            return clsLicenseAccess.DeactivateLicense(this.LicenseID);
        }
        public bool IsExpired()
        {

            return (this.ExpirationDate < DateTime.Now);

        }

        public bool IsDetained()
        {
            return clsDetainedLicense.IsDetained(this.LicenseID);
        }

        public int Detain(float FineFess, int CreatedByUserID)
        {
            clsDetainedLicense DetainedLicense = new clsDetainedLicense();

            DetainedLicense.LicenseID = this.LicenseID;
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.FineFess = FineFess;
            DetainedLicense.CreatedByUserID = CreatedByUserID;

            if (!DetainedLicense.Save()) { return -1; }
            return DetainedLicense.DetainID;
        }

        public bool ReleaseDetained(int CreatedByUserID, ref int ApplicationID)
        {
            clsApplication Application = new clsApplication();
            clsApplicationType ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense);

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationStatus = 3; //Complated
            Application.CreatedByUserID = CreatedByUserID;
            Application.ApplicationTypeID = ApplicationType.ApplicationTypeID;
            Application.PaidFees = ApplicationType.Fees;
            Application.LastStatusDate = DateTime.Now;

            if (!Application.Save())
            {

                return false;
            }

            ApplicationID = Application.ApplicationID;

            if (!DetainedInfo.ReleaseLicense(CreatedByUserID,Application.ApplicationID))
            {

                return false;
            }
            return true;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNew();
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }

    }
}
