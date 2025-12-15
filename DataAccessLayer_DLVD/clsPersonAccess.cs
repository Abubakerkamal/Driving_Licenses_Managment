using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsPersonAccessLayer
    {
        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM People_View1";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                return dt;
            }
            finally {
             connection.Close();
            }

            return dt;
        }

        static public DataTable FilterByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM People_View1 where PersonID = @ID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ID",ID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable FilterBy(string By, string str)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM People_View1 where " + By + " like '%' + @str + '%' ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@str", str);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public bool IsExist(string NationalNo) {

            bool IsFound =false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT Found = 1 FROM People_View1 where NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        static public bool IsExist(int PersonID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT Found = 1 FROM People_View1 where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }


        static public int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "INSERT INTO [dbo].[People] ([NationalNo] ,[FirstName] ,[SecondName] ,[ThirdName] ,[LastName]" +
                ",[DateOfBirth] ,[Gendor] ,[Address] ,[Phone] ,[Email] ,[NationalityCountryID] ,[ImagePath])" +
                "  VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor," +
                " @Address, @Phone, @Email, @NationalityCountryID, @ImagePath) select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != string.Empty)
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            if (Email != string.Empty)
            {
                cmd.Parameters.AddWithValue("@Email", Email);
            }
            else cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id)) {
                    PersonID = id;  
                }
               
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PersonID;

        }


        static public int UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;
         
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[People] Set [NationalNo] = @NationalNo,[FirstName] = @FirstName" +
                ",[SecondName] = @SecondName,[ThirdName] = @ThirdName,[LastName] = @LastName" +
                ",[DateOfBirth] = @DateOfBirth,[Gendor] = @Gendor, [Address] = @Address, [Phone] = @Phone, [Email] = @Email," +
                "[NationalityCountryID] = @NationalityCountryID , [ImagePath]= @ImagePath where PersonID = @PersonID";
               

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != string.Empty)
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            if (Email != string.Empty)
            {
                cmd.Parameters.AddWithValue("@Email", Email);
            }
            else cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {

                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected;

        }

        static public bool GetPersonInfoByID( int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
            ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

             bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From People Where PersonID = @PersonID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    IsFound =true;
                    NationalNo = reader["NationalNo"].ToString();
                    FirstName             = reader["FirstName"].ToString();
                    SecondName            = reader["SecondName"].ToString();

                    if (reader["ThirdName"] == DBNull.Value)
                    {
                        ThirdName = string.Empty;
                    }
                    else ThirdName             = reader["ThirdName"].ToString();

                    LastName              = reader["LastName"].ToString();
                    DateOfBirth           = (DateTime)reader["DateOfBirth"];
                    Gendor                = (byte)reader["Gendor"];
                    Address               = reader["Address"].ToString();
                    Phone                 = reader["Phone"].ToString();

                    if (reader["Email"] == DBNull.Value)
                    {
                        Email = string.Empty;
                    }
                    else Email = reader["Email"].ToString();

                    NationalityCountryID  = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = string.Empty;
                    }
                    else ImagePath = reader["ImagePath"].ToString();

                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                
                connection.Close();
            }

            return IsFound;

        }

        static public bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
         ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From People Where NationalNo = @NationalNo";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();

                    if (reader["ThirdName"] == DBNull.Value)
                    {
                        ThirdName = string.Empty;
                    }
                    else ThirdName = reader["ThirdName"].ToString();

                    LastName = reader["LastName"].ToString();
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] == DBNull.Value)
                    {
                        Email = string.Empty;
                    }
                    else Email = reader["Email"].ToString();

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = string.Empty;
                    }
                    else ImagePath = reader["ImagePath"].ToString();

                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {

                connection.Close();
            }

            return IsFound;

        }
        static public int DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Delete From People Where PersonID = @PersonID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            
            try
            {

                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected;
        }
    }


}
