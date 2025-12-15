using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer_DLVD
{
    public class clsApplicationAccess
    {
        static public int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "INSERT INTO [dbo].[Applications]  ([ApplicantPersonID] , [ApplicationDate]," +
                " [ApplicationTypeID] , [ApplicationStatus] , [LastStatusDate] , [PaidFees] , [CreatedByUserID])" +
                " VALUES (@ApplicantPersonID, @ApplicationDate , @ApplicationTypeID ," +
                " @ApplicationStatus , @LastStatusDate , @PaidFees , @CreatedByUserID) select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ApplicationID = id;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return ApplicationID;
        }

        static public bool GetApplicationInfoByID(int ApplicationID,ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,
             ref byte ApplicationStatus, ref DateTime LastStatusDate,ref decimal PaidFees,ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From Applications Where ApplicationID = @ApplicationID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]);

                    LastStatusDate = (DateTime)reader["ApplicationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        static public int Update(int ApplicationID,  int ApplicantPersonID,  DateTime ApplicationDate,  int ApplicationTypeID,
              byte ApplicationStatus,  DateTime LastStatusDate,  decimal PaidFees,  int CreatedByUserID)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[Applications] set [ApplicantPersonID] = @ApplicantPersonID, [ApplicationDate] = @ApplicationDate, " +
                "[ApplicationTypeID] = @ApplicationTypeID, [ApplicationStatus] = @ApplicationStatus, [LastStatusDate] = @LastStatusDate," +
                "[PaidFees] = @PaidFees,  [CreatedByUserID] = @CreatedByUserID " +
                "where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
        


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


        static public int UpdateStatus(int ApplicationID, byte NewStatus)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[Applications] set [ApplicationStatus] = @NewStatus, [LastStatusDate] = @LastStatusDate " +
                "where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@NewStatus", NewStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
         

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

        static public int Delete(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Delete From Applications Where ApplicationID = @ApplicationID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        static public bool IsExist(int ApplicationID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT Found = 1 FROM Applications ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return GetActiveApplicationID(PersonID, ApplicationTypeID) != -1;
        }

        static public int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select ActiveApplicationID = ApplicationID From Applications Where ApplicantPersonID = @PersonID and ApplicationTypeID = @ApplicationTypeID" +
                "ApplicationStatus = 1";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {

                connection.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out int ID) ){
                    ActiveApplicationID = ID;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        static public int GetApplicationIDForLicenseClass(int ApplicantPersonID, int ApplicationTypeID, int LicenseClassID)
        {

            int ActiveApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select ActiveApplicationID = Applications.ApplicationID From Applications inner join " +
                " LocalDrivingLicenseApplications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID " +
                "Where ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID = @ApplicationTypeID and " +
                " LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID" +
                "and ApplicationStatus = 1";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {

                connection.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(),out int ID))
                {
                    ActiveApplicationID = ID;


                }

            }
            catch (Exception ex)
            {
            }
            finally
            {

                connection.Close();
            }

            return ActiveApplicationID;

        }


    }
}
