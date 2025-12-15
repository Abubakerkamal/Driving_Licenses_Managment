using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccessLayer_DLVD;
using System.Security.AccessControl;

namespace BusinessLayer
{


    public class clsPerson
    {

        public int PersonID = -1;
        enum _enMode { AddNew = 0, Update = 1 }
        public string NationalNo, FirstName, SecondName, ThirdName, LastName, Address, Phone, Email, ImagePath;
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public byte Gendor;
        public DateTime DateOfBirth;
        public int NationalityCountryID;
        string _PrevImage;
        _enMode _Mode;

       public clsCountry CountryInfo;


        public clsPerson() {
        _Mode = _enMode.AddNew;
        }

       public clsPerson(int PersonID ,string NationalNo, string firstName, string secondName, string thirdName, string lastName, string address,
            string Phone, string Email, string ImagePath, byte Gendor, DateTime DateOfBirth, int NationalityCountryID, string PrevImage = "")
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = Phone;
            this.Email = Email;
            this.Gendor = Gendor;   
            this.DateOfBirth = DateOfBirth;
            this.NationalityCountryID = NationalityCountryID;
            this._PrevImage = PrevImage;
            this.ImagePath = ImagePath;
            _Mode = _enMode.Update;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);

            
        }




        static public DataTable GetAllPeople()
        {
            return clsPersonAccessLayer.GetAllPeople(); 
        }

        static public DataTable FilterByID(int ID) {
        return clsPersonAccessLayer.FilterByID(ID);
        }

        static public DataTable FilterBy(string By, string str)
        {
            return clsPersonAccessLayer.FilterBy(By, str);
        }

        static public clsPerson FindPerson(int PersonID)
        {
            string NationalNo= "", FirstName ="", SecondName = "", ThirdName = "", LastName = "", Address = "",
                Phone = "", Email = "", ImagePath = "";
            byte Gendor = 0;
            DateTime DateOfBirth = DateTime.Today;
            int NationalityCountryID = 0;

            bool IsFound = clsPersonAccessLayer.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            if (IsFound)
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                      Address, Phone, Email, ImagePath, Gendor, DateOfBirth, NationalityCountryID);
            }
            return null;
        }

        static public clsPerson FindPerson(string NationalNo)
        {
            int PersonID = 0;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "",
            Phone = "", Email = "", ImagePath = "";
            byte Gendor = 0;
            DateTime DateOfBirth = DateTime.Today;
            int NationalityCountryID = 0;

            bool IsFound = clsPersonAccessLayer.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            if (IsFound)
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                      Address, Phone, Email, ImagePath, Gendor, DateOfBirth, NationalityCountryID);
            }
            return null;
        }
        static public bool IsExist(string NationalNo)
        {
            return clsPersonAccessLayer.IsExist(NationalNo);
        }

        private bool _AddNew()
        {
            
            PersonID = clsPersonAccessLayer.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID,
                this.ImagePath);

            return (PersonID != -1);
        }
        
        private bool _Update()
        {

          
            int rowsAffected = clsPersonAccessLayer.UpdatePerson(this.PersonID, this.NationalNo,  this.FirstName, this.SecondName, this.ThirdName,
                 this.LastName,  this.DateOfBirth, this.Gendor,  this.Address,  this.Phone,  this.Email, this.NationalityCountryID, this.ImagePath);
            return (rowsAffected > 0);
        }

        public bool Save()
        {
            switch (_Mode) { 
            
                case _enMode.AddNew:
                   _Mode = _enMode.Update;
                    return _AddNew();
                case _enMode.Update:
                    return _Update();
            
            
            }
            return false;
        }

        static public bool DeletePerson(int PersonID)
        {
            return (clsPersonAccessLayer.DeletePerson(PersonID)  != 0);
        }

    }
}
