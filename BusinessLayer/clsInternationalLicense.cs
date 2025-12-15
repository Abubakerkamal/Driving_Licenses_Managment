using DataAccessLayer_DLVD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsInternationalLicense : clsApplication
    {
        public enum enMode { AddNew = 1, Update = 2};
        public enMode Mode = enMode.AddNew;


        public int InternationalLicenseID{ set; get; }
        public int DriverID { set; get; }

        public clsDriver DriverInfo;
        public int IssuedUsingLocalLicenseID { set; get; }
        public clsLicense LocalLicenseInfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
  
        public bool IsActive { set; get; }
        public int LicenseCreatedByUserID { set; get; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.LicenseCreatedByUserID = -1;
            this.DriverInfo = null;
            this.LocalLicenseInfo = null;

            Mode = enMode.AddNew;
        }

        public clsInternationalLicense(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
           byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID,int internationalLicenseID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate,  bool isActive, int createdByUserID)
        {



            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationTypeID = ApplicationTypeID;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;
            base.PersonInfo = clsPerson.FindPerson(ApplicantPersonID);


            this.InternationalLicenseID = internationalLicenseID;
            this.ApplicationID = base.ApplicationID;
            this.DriverID = driverID;
            this.DriverInfo = clsDriver.FindByDriverID(DriverID);
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.LocalLicenseInfo = clsLicense.FindByLicenseID(issuedUsingLocalLicenseID);
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.LicenseCreatedByUserID = createdByUserID;
            this.Mode = enMode.Update;
        }

        bool _AddNew()
        {
            InternationalLicenseID = clsInternationalLicenseAccsess.AddNew(ApplicationID, DriverID,
                IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, LicenseCreatedByUserID);
            return (InternationalLicenseID > 0);
        }

        private bool _Update()
        {

            return  clsInternationalLicenseAccsess.Update(InternationalLicenseID,ApplicationID, DriverID,
                IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, LicenseCreatedByUserID);
        }
       

        static public bool IsLicenceExistAndActiveByDriverID(int DriverID)
        {

            return (clsInternationalLicenseAccsess.GetActiveLicenseIDByDriverID(DriverID) > -1);
        }

        static public int GetActiveLicenseIDByDriverID(int DriverID)
        {
            return clsInternationalLicenseAccsess.GetActiveLicenseIDByDriverID(DriverID);
        }

        static public clsInternationalLicense Find(int InternationalLicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = 0;

            bool IsFound = clsInternationalLicenseAccsess.GetLicenseInfoByLicenseID( InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
           ref IsActive,  ref CreatedByUserID);

            if (IsFound)
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                if(Application != null)
                {
                    return new clsInternationalLicense(Application.ApplicationID, Application.ApplicantPersonID, Application.ApplicationDate,
                    Application.ApplicationTypeID, Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID,
                    InternationalLicenseID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
                }

            }

            return null;
        }

        static public DataTable GetDriverLicenses(int DriverID)
        {
            return clsInternationalLicenseAccsess.GetDriverLicenses(DriverID);
        }

        static public DataTable GetAllLicenses()
        {
            return clsInternationalLicenseAccsess.GetAllLicenses();
        }
       
      
        public bool IsExpired()
        {

            return (this.ExpirationDate < DateTime.Now);

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
                    return _AddNew();
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }

    }
}

