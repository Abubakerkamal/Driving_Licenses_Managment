using DataAccessLayer_DLVD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDetainedLicense
    {
       public int DetainID { set; get; }
       public int LicenseID { set; get; }
       public DateTime DetainDate{ set; get; }
       public int CreatedByUserID{ set; get; }
       public float FineFess{ set; get; }
       public bool IsReleased{ set; get; }
       public int ReleasedByUserID{ set; get; }
       public DateTime ReleaseDate{ set; get; }
       public int ReleaseApplicationID { set; get; }

        public clsUser CreatedByUserInfo;
       public enum enMode { AddNew =  0, Update = 1 }
        enMode Mode;
       public clsDetainedLicense() { 
        
            DetainID = -1;
            LicenseID = -1;
            CreatedByUserID = -1;
            ReleaseApplicationID = -1;
            Mode = enMode.AddNew;
        }

        public clsDetainedLicense(int detainID, int licenseID, DateTime detainDate, int createdByUserID, float fineFess, bool isReleased, int releasedByUserID, DateTime releaseDate, int releaseApplicationID)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            CreatedByUserID = createdByUserID;
            FineFess = fineFess;
            IsReleased = isReleased;
            ReleasedByUserID = releasedByUserID;
            ReleaseDate = releaseDate;
            ReleaseApplicationID = releaseApplicationID;
            CreatedByUserInfo = clsUser.Find(CreatedByUserID);

            Mode = enMode.Update;

        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseAccess.GetAllDetainedLicenses();
        }


        public static clsDetainedLicense Find(int DetainID)
        {
            int LicenseID             = -1;
            DateTime DetainDate       = DateTime.Now;
            int CreatedByUserID       = -1;
            float FineFess            = 0;
             bool IsReleased          = false;
            int ReleasedByUserID      = -1;
            DateTime ReleaseDate      = DateTime.Now;
            int ReleaseApplicationID  = -1;


            bool IsFound = clsDetainedLicenseAccess.GetDetainedLicenseInfoByID(DetainID, ref LicenseID, ref DetainDate,  ref FineFess, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
            {
                return new clsDetainedLicense(DetainID,LicenseID,DetainDate,
                                            CreatedByUserID,FineFess,IsReleased,ReleasedByUserID
                                            ,ReleaseDate,ReleaseApplicationID);
            }
            return null;
        }

        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            int CreatedByUserID = -1;
            float FineFess = 0;
            bool IsReleased = false;
            int ReleasedByUserID = -1;
            DateTime ReleaseDate = DateTime.Now;
            int ReleaseApplicationID = -1;


            bool IsFound = clsDetainedLicenseAccess.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFess, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (IsFound)
            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate,
                                            CreatedByUserID, FineFess, IsReleased, ReleasedByUserID
                                            , ReleaseDate, ReleaseApplicationID);
            }
            return null;
        }



        bool _AddNew()
        {
            DetainID = clsDetainedLicenseAccess.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFess, this.CreatedByUserID);
            return (DetainID > -1);
        }

        bool _Update()
        {
            return clsDetainedLicenseAccess.UpdateDetainedLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFess, this.CreatedByUserID);
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
       
        static public bool IsDetained(int LicenseID)
        {
            return clsDetainedLicenseAccess.IsLicenseDetained(LicenseID) ;
        }

        public bool ReleaseLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
           return clsDetainedLicenseAccess.ReleaseDetainedLicense(this.DetainID, ReleasedByUserID, ReleaseApplicationID);
        }

    }


}
