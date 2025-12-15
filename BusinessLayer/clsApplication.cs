using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_DLVD;


namespace BusinessLayer
{
    public class clsApplication
    {
        public enum enMode { AddNew = 1, Update = 2 };
         public enum enStatus { New = 1, Cancelled = 2, Completed = 3  }
         public enum enApplicationType
        { 	NewLocalDrivingLicenseService = 1 ,RenewDrivingLicenseService = 2,	ReplacementforaLostDrivingLicense =3,	
            ReplacementforaDamagedDrivingLicense =4 ,ReleaseDetainedDrivingLicsense =5,
	        NewInternationalLicense =6,RetakeTest =7                               
        }

        public int ApplicationID { get; set; }
        public clsPerson PersonInfo;
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public string StatusText { 
            
            get
            {
                switch ((enStatus)ApplicationStatus)
                {
                    case enStatus.New:
                        return "New";
                    case enStatus.Cancelled:
                        return "Cancelled";
                    case enStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                        
                }
            }
                
                
                }

        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public string FullName
        {
            get {  return clsPerson.FindPerson(ApplicantPersonID).FullName; }
        }

       public  enMode Mode;

        public clsApplicationType ApplcationType;

        public clsUser CreateByUserInfo;

        public clsApplication()
        {
        
            this.Mode = enMode.AddNew;
        }
        public clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
           byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees,int CreatedByUserID)
        {
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

            Mode = enMode.Update;
        }

        static public clsApplication FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1;
           DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;

            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;

            int CreatedByUserID = -1;

            bool IsFound = clsApplicationAccess.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
               ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
            {
                return new clsApplication(ApplicationID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                    ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID);
            }
            return null;    
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationAccess.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }

        public  bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
        {
            return clsApplicationAccess.DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
        }

        static public int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType ApplicationType)
        {
            return clsApplicationAccess.GetActiveApplicationID(PersonID, (int)ApplicationType);
        }

        
        public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationType)
        {
            return clsApplicationAccess.GetActiveApplicationID(this.ApplicantPersonID, (int)ApplicationType);
        }

        static public int GetApplicationIDForLicenseClass(int ApplicantPersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationAccess.GetApplicationIDForLicenseClass(ApplicantPersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        static public bool IsExist(int ApplicationID)
        {
            return clsApplicationAccess.IsExist(ApplicationID);
        }


        private bool _AddNew()
        {
             this.ApplicationID = clsApplicationAccess.AddNewApplication(this.ApplicantPersonID,this.ApplicationDate, this.ApplicationTypeID,
                this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID > 0);
        }

        private bool _Update()
        {
            int RowsAffected = clsApplicationAccess.Update(this.ApplicationID,this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
               this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (RowsAffected > 0);
        }

        public bool Delete()
        {
            return clsApplicationAccess.Delete(this.ApplicationID) > 0;
        }

        public bool SetCancel()
        {
            return (clsApplicationAccess.UpdateStatus(this.ApplicationID, (int)enStatus.Cancelled) > 0);
        }

        public bool SetComplete()
        {
            return (clsApplicationAccess.UpdateStatus(this.ApplicationID, (int)enStatus.Completed) > 0);
        }
        public bool Save()
        {
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
