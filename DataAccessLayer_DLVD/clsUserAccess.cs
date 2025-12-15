using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer_DLVD
{
    public class clsUserAccess
    {

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT UserID, Users.PersonID, FirstName + ' ' + SecondName + ' ' + + ISNULL( People.ThirdName,'') + ' ' + LastName,\r\nUserName, IsActive\r\nFROM Users inner join People \r\non Users.PersonID = People.PersonID";

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
            catch (Exception)
            {

                return dt;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public int AddNew(int PersonID, string UserName, string Password, bool IsActive)
        {

            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "INSERT INTO [dbo].[Users] ([PersonID] ,[UserName] ,[Password], [IsActive] )" +
                "  VALUES (@PersonID, @UserName, @Password, @IsActive) select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
           

            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    UserID = id;
                }

            }
            catch (Exception)
            {
                return UserID;
            }
            finally
            {
                connection.Close();
            }

            return UserID;

        }

        static public int Update(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[Users] set [PersonID] = @PersonID ,[UserName] = @UserName ," +
                "[Password] = @Password, [IsActive] = @IsActive " +
                "where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {

                connection.Open();
                 result = cmd.ExecuteNonQuery();
                

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return result;

        }

        static public int ChangePassword(int UserID, string Password)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[Users] set[Password] = @Password " +
                "where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Password", Password);


            try
            {

                connection.Open();
                result = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return result;

        }

        static public bool GetUserInfoByUserName(string UserName,  ref int PersonID, ref int UserID, ref string Password, ref bool IsActive)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From Users Where UserName = @UserName";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToBoolean(reader["IsActive"]);


                }

                reader.Close();
            }
            catch (Exception)
            {
              IsFound = false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;

        }

        static public bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From Users Where UserID = @UserID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserName = reader["UserName"].ToString();
                    PersonID = (int)reader["PersonID"];
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToBoolean(reader["IsActive"]);


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

        static public bool GetByUsernameAndPassword(string UserName, string Password,ref int UserID, ref int PersonID,ref bool IsActive)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select * From Users Where UserName = @UserName and Password = @Password";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = Convert.ToBoolean(reader["IsActive"]);

                }

                reader.Close();
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;

        }

        static public bool IsExistWithPerson( int PersonID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select Found = 1 From Users Where PersonID = @PersonID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

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


        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public int Delete(int UserID)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Delete  From [dbo].[Users] where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);


            try
            {

                connection.Open();
                result = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return result;

        }


    }
}
