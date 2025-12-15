using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsInternationalLicenseAccsess
    {
        static public int AddNew(int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, 
            DateTime IssueDate, DateTime ExpirationDate,bool IsActive, int CreatedByUserID)
        {

            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "UPDATE InternationalLicenses SET IsActive = 0 WHERE DriverID = @DriverID" +
               
                " INSERT INTO [dbo].[InternationalLicenses]  ([ApplicationID] , [DriverID]," +
                " [IssuedUsingLocalLicenseID] , [IssueDate] , [ExpirationDate] , [IsActive],  [CreatedByUserID])" +
                " VALUES (@ApplicationID, @DriverID , @IssuedUsingLocalLicenseID ," +
                " @IssueDate , @ExpirationDate , @IsActive, @CreatedByUserID) select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    InternationalLicenseID = id;
                }

            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static bool Update(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @"UPDATE InternationalLicenses
                           SET ApplicationID=@ApplicationID, DriverID = @DriverID,
                              IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                              IssueDate = @IssueDate,
                              ExpirationDate = @ExpirationDate,
                              IsActive = @IsActive,IssueReason=@IssueReason,
                              CreatedByUserID = @CreatedByUserID
                         WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static DataTable GetAllLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @"SELECT * FROM InternationalLicenses
                              ORDER BY InternationalLicenseID DESC";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetDriverLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @"SELECT *  
                           FROM InternationalLicenses
                           where DriverID=@DriverID
                           Order By IsActive Desc, ExpirationDate Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
            
        }

        static public bool GetLicenseInfoByLicenseID(int InternationalLicenseID,ref int ApplicationID, ref int DriverID,
            ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate,ref DateTime ExpirationDate,ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                  


                }

                reader.Close();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;
        }

        public static int GetActiveLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @"SELECT TOP 1 InternationalLicenseID
                            FROM InternationalLicenses
                            WHERE
                            DriverID = @DriverID  AND GETDATE() BETWEEN IssueDate AND ExpirationDate
                             ORDER BY ExpirationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    InternationalLicenseID = id;
                }
            }

            catch (Exception)
            {
                return InternationalLicenseID;
            }

            finally
            {
                connection.Close();
            }


            return InternationalLicenseID;
        }

    }
}
