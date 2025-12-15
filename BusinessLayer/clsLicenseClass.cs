using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_DLVD;

namespace BusinessLayer
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LicenseClassID { get; set; }
       public string ClassName { get; set; }
       public string ClassDescription { get; set; }
       public byte MinimumAllowedAge { get; set; }
       public byte DefaultValidityLength { get; set; }
       public decimal ClassFees { get; set; }

        public clsLicenseClass(int LicenseClassID, string ClassName,
            string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)

        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }

        static public DataTable GetAllLicenseClases() {
            return clsLicenseClassAccess.GetAllLicenseClases();
        }
        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; decimal ClassFees = 0;

            if (clsLicenseClassAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }

        public static clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; decimal ClassFees = 0;

            if (clsLicenseClassAccess.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }

        private bool _AddNewLicenseClass()
        {

            this.LicenseClassID = clsLicenseClassAccess.AddNewLicenseClass(this.ClassName, this.ClassDescription,
                this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);


            return (this.LicenseClassID != -1);
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassAccess.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription,
                this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicenseClass();

            }

            return false;
        }

    }
}
