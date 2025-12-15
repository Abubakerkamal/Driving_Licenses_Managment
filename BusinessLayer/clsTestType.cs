using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_DLVD;

namespace BusinessLayer
{
    public class clsTestType
    {
        public enum enTestType
        {
            Vision = 1,
            Written = 2,
            Street = 3
        }
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal Fees { get; set; }


        clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.Fees = TestTypeFees;
        }
        static public DataTable GetAllTestTypes()
        {
            return clsTestTypeAccess.GetAllTestTypes();
        }

        static public clsTestType Find(int TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = -1;
            bool IsFound = clsTestTypeAccess.GetTestTypeByID(TestTypeID, ref TestTypeTitle,ref TestTypeDescription, ref TestTypeFees);

            if (IsFound)
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            return null;

        }

        private bool _Update()
        {
            int Result = clsTestTypeAccess.Update(this.TestTypeID, this.TestTypeTitle,this.TestTypeDescription, this.Fees);

            return (Result > 0);
        }

        public bool Save()
        {
            if (_Update())
            {
                return true;
            }
            return false;
        }
    }
}
