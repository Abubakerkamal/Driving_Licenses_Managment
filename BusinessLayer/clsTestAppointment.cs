using DataAccessLayer_DLVD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointment
    {
       enum enMode { AddNew = 0, Update = 1 }
       public int TestAppointmentID { get; set; }
       public clsTestType.enTestType TestTypeID {  get; set; }
       public int LocalDrivingLicenseApplicationID { get; set; }
       public DateTime AppointmentDate { get; set; }
       public decimal PaidFees { get; set; }
       public int RetakeTestApplicationID { get; set; }
       public clsApplication RetakeTestApplicationInfo { get; set; }
       public bool IsLocked { get; set; }
       public int CreatedByUserID   { get; set; }

       enMode _Mode = enMode.AddNew;

       public int TestID
        {
            get { return _GetTestID(); }
        }


       public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = clsTestType.enTestType.Vision;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            this.RetakeTestApplicationID = -1;
            RetakeTestApplicationInfo = null;
            _Mode = enMode.AddNew;

        }



        clsTestAppointment(int testAppointmentID, clsTestType.enTestType testTypeID, int localDrivingLicenseApplicationID, 
            DateTime appointmentDate, decimal paidFees, int retakeTestApplicationID, byte isLocked,
            int createdByUserID)
        {
            TestAppointmentID=testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID=localDrivingLicenseApplicationID;
            AppointmentDate=appointmentDate;
            PaidFees=paidFees;
            RetakeTestApplicationID=retakeTestApplicationID;
            RetakeTestApplicationInfo = clsApplication.FindBaseApplication(retakeTestApplicationID);
            IsLocked=(isLocked == 1) ? true : false ;
            CreatedByUserID=createdByUserID;
            _Mode=enMode.Update;

        }

        static public DataTable GetAllTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentAccess.GetAllTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, TestTypeID);
        }



        static public clsTestAppointment Find(int TestAppointmentID)
        {
          
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = - 1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            int RetakeTestApplicationID = -1;
            byte IsLocked = 0;
            int CreatedByUserID = -1;

            bool IsFound = clsTestAppointmentAccess.GetTestAppointmentByID(TestAppointmentID, ref TestTypeID,
                ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref RetakeTestApplicationID, ref IsLocked, ref CreatedByUserID);
            if (IsFound) { 
            return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID,
                LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,RetakeTestApplicationID,IsLocked,CreatedByUserID);
            }
            return null;
        }

        static public clsTestAppointment Find(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {

            int TestAppointmentID = -1;
          
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            int RetakeTestApplicationID = -1;
            byte IsLocked = 0;
            int CreatedByUserID = -1;

            bool IsFound = clsTestAppointmentAccess.GetTestAppointmentByTestTypeIDAndLDlApplicationID(TestTypeID, LocalDrivingLicenseApplicationID,
                ref  TestAppointmentID, ref AppointmentDate, ref PaidFees, ref RetakeTestApplicationID, ref IsLocked, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID,
                    LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, RetakeTestApplicationID,IsLocked, CreatedByUserID);
            }
            return null;
        }

        static public clsTestAppointment GetLastTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {

            int TestAppointmentID = -1;

            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            int RetakeTestApplicationID = -1;
            byte IsLocked = 0;
            int CreatedByUserID = -1;

            bool IsFound = clsTestAppointmentAccess.GetLastTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref RetakeTestApplicationID, ref IsLocked, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID,
                    LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, RetakeTestApplicationID,IsLocked, CreatedByUserID);
            }
            return null;
        }
        public static bool DoseApplicationHasActiveTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentAccess.DoseApplicationHasTestAppointment(LocalDrivingLicenseApplicationID, TestTypeID, 0);
        }

        public static bool DoseApplicationHasLockedTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentAccess.DoseApplicationHasTestAppointment(LocalDrivingLicenseApplicationID, TestTypeID, 1);
        }

        public static bool Lock(int TestAppointmentID)
        {
            return clsTestAppointmentAccess.LockTestAppointment(TestAppointmentID) > 0;
        }
        public  bool Lock()
        {
            return clsTestAppointmentAccess.LockTestAppointment(this.TestAppointmentID) > 0;
        }
        static public int TotalTrialPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentAccess.TotalTrialPerTest(LocalDrivingLicenseApplicationID , (int)TestTypeID);
        }


        int _GetTestID()
        {
            return clsTestAppointmentAccess.GetTestID(this.TestAppointmentID);
        }
        bool _AddNew()
        {
            TestAppointmentID = clsTestAppointmentAccess.AddNew((int)TestTypeID,
                LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,RetakeTestApplicationID);
            return (TestAppointmentID > 0);
        }

        bool _Update()
        {
            int RowAffected = clsTestAppointmentAccess.Update(TestAppointmentID,AppointmentDate);
            return (RowAffected > 0);
        }

        public bool Save() {

            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return _AddNew();
                case enMode.Update:
                    return _Update();
                default:
                    return false;
                    
            }

        }



    }

}
