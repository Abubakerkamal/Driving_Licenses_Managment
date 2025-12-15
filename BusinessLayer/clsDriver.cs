using DataAccessLayer_DLVD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayer.clsApplication;

namespace BusinessLayer
{
    public class clsDriver
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsPerson PersonInfo;

        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public int CreatedByUserID { set; get; }

        public DateTime CreatedTime { set; get; }

        public clsDriver() {

            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;    

        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdTime)
        {
            this.DriverID = driverID;
            this.PersonID = personID;
            this.PersonInfo = clsPerson.FindPerson(PersonID);
            this.CreatedByUserID = createdByUserID;
            this.CreatedTime = createdTime;
            Mode = enMode.Update;
        }

        static public DataTable GetAllDrivers()
        {
            return clsDriverAccess.GetAllDrivers();
        }


        static public bool IsExistByPersonID(int PersonID)
        {
            return clsDriverAccess.IsDriverExistByPersonID(PersonID);
        }

        static public clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedTime = DateTime.Now;

            bool IsFound = clsDriverAccess.GetDriverByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedTime);

            if (IsFound)
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedTime);
            }
            else return null;
        }
        bool _AddNew()
        {
            DriverID = clsDriverAccess.AddNewDriver(PersonID,
                CreatedByUserID, CreatedTime);
            return (DriverID > 0);
        }

        private bool _Update()
        {
            //call DataAccess Layer 

            return clsDriverAccess.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID);
        }


        static public clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedTime = DateTime.Now;

            bool IsFound = clsDriverAccess.GetDriverByDriverID(DriverID,ref PersonID,ref CreatedByUserID, ref CreatedTime);

            if (IsFound)
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedTime);
            }
            else return null;
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
                    break;
            }
            return false;
        }

    }
}
