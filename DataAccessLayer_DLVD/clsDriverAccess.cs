using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsDriverAccess
    {


        static public DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"SELECT * FROM Drivers_View order by FullName";

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
            finally
            {
                connection.Close();
            }

            return dt;
        }
        static public int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int DriverID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "INSERT INTO [dbo].[Drivers] ([PersonID], [CreatedByUserID], [CreatedDate])" +
                " VALUES(@PersonID, @CreatedByUserID , @CreatedDate )select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    DriverID = id;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return DriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            //we dont update the createddate for the driver.
            string query = @"Update  Drivers  
                            set PersonID = @PersonID,
                                CreatedByUserID = @CreatedByUserID
                                where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        static public bool GetDriverByDriverID(int DriverID, ref int PersonID,ref int CreatedByUserID,ref DateTime CreatedDate)
        {
        

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From Drivers Where DriverID = @DriverID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedDate"];
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

        static public bool GetDriverByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From Drivers Where PersonID = @PersonID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    DriverID = (int)reader["DriverID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        static public bool IsDriverExistByPersonID(int PersonID) {


                bool IsFound = false;
                SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
                string query = "SELECT Found = 1 FROM Drivers where PersonID = @PersonID";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    IsFound = reader.HasRows;
                    reader.Close();
                }
                catch (Exception)
                {
                return IsFound;
            }
            finally
                {
                    connection.Close();
                }

                return IsFound;

            

        }
    }
}
