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
    public class clsApplicationType
    {
       public int ApplicationTypeID { get; set; }
       public string ApplicationTypeTitle { get; set; }
       public decimal Fees { get; set; }


        clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.Fees = ApplicationTypeFees;
        }
        static public DataTable GetAllAppTypes()
        {
            return clsApplcationTypeAccess.GetAllAppTypes();
        }

        
        static public clsApplicationType Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationTypeFees = -1;
            bool IsFound = clsApplcationTypeAccess.GetAppTypeByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationTypeFees);

            if (IsFound) { 
            return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
            }
            return null;
             
        }

        private bool _Update()
        {
            int Result = clsApplcationTypeAccess.Update(this.ApplicationTypeID, this.ApplicationTypeTitle, this.Fees);

            return ( Result > 0);
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
