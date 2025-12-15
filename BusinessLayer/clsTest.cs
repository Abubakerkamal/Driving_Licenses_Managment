using DataAccessLayer_DLVD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTest
    {
        public enum enTestType{ Vision = 1,Written = 2,Street = 3}
        enum enMode { AddNew = 0, Update = 1 }


       public int TestID { get; set; }
       public int TestAppointmentID { get; set; }
        public byte TestResult{ get; set; }
       public string Notes{ get; set; }
       public int CreatedByUserID{ get; set; }
       public clsTestAppointment TestAppointmentInfo;
       enMode _Mode;

        public clsTest()

        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = 0;
            this.Notes = "";
            this.CreatedByUserID = -1;

            _Mode = enMode.AddNew;

        }

        public clsTest(int TestID, int TestAppointmentID,
            byte TestResult, string Notes, int CreatedByUserID)

        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestAppointmentInfo = clsTestAppointment.Find(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.Update;
        }
      

       public static int GetPassedTestCount(int LocalDrivingApplicationID)
        {
             return clsTestAccess.GetPassedTestCount(LocalDrivingApplicationID);
        }

        bool _AddNew()
        {
            TestID = clsTestAccess.TakeTest(TestAppointmentID,
                TestResult, Notes, CreatedByUserID);
            return (TestID > 0);
        }

        bool _Update()
        {
             
            return clsTestAccess.UpdateTest(TestID, TestAppointmentID,
                TestResult, Notes, CreatedByUserID);
        }
        public bool Save()
        {

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

        public static bool DoseApplicationPassTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAccess.DoseApplicationPassTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = -1;
            byte TestResult = 0; string Notes = ""; int CreatedByUserID = -1;

            if (clsTestAccess.GetTestInfoByID(TestID,
            ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))

                return new clsTest(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            else
                return null;

        }
        static public clsTest FindTestByPersonIDAndLicenseClass(int LocalDrivingLicenseApplications,int PersonID, int LicenseClassID,clsTestType.enTestType TestType)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            byte TestResult = 0; string Notes = ""; int CreatedByUserID = -1;

            if (clsTestAccess.GetLastTestPerPersonIDAndClassLicenseIDAndTestTypeID
                (LocalDrivingLicenseApplications,PersonID, LicenseClassID, (int)TestType, ref TestID,
            ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))

                return new clsTest(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            else
                return null;
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;
        }

    }
}

