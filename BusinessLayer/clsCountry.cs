using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_DLVD;
namespace BusinessLayer
{

    public class clsCountry
    {


        public int CountryID;
        public string CountryName;


       public clsCountry() { }
        public clsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
    
        static public DataTable GetAllCountries()
        { 
         return clsCountryAccess.GetAllCountries();
        }

        static public string GetCountryName(int PersonID) {
        return clsCountryAccess.GetCountryName(PersonID);
        }

        static public clsCountry Find(int CountryID) {
        string CountryName = "";
        bool IsFound = clsCountryAccess.GetCountryInfoByID(CountryID,ref CountryName);
        
            if(IsFound) { return new clsCountry(CountryID, CountryName); }
            return null;
        }

        static public clsCountry Find(string CountryName)
        {
            int CountryID = 0;
            bool IsFound = clsCountryAccess.GetCountryInfoByID(CountryName, ref CountryID);

            if (IsFound) { return new clsCountry(CountryID, CountryName); }
            return null;
        }

    }
}
