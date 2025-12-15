using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer_DLVD
{
    public class clsLocalDrivingLicenseApplicationAccess
    {
        static public int AddNewLocalDrivingLicenseApplication(int ApplicationID,  int LicenseClassID)
        {

            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "INSERT INTO [dbo].[LocalDrivingLicenseApplications] ([ApplicationID], [LicenseClassID])" +
                " VALUES(@ApplicationID, @LicenseClassID )select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
         

            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    LocalDrivingLicenseApplicationID = id;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;
        }

        static public bool GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select * From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                

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

        static public bool GetLocalDrivingLicenseApplicationByApplicationID(int ApplicationID , ref int LocalDrivingLicenseApplicationID , ref int LicenseClassID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select * From LocalDrivingLicenseApplications Where ApplicationID = @ApplicationID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];


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

        public static DataTable GetAllLocalDrivigLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * From  LocalDrivingLicenseApplications_View order by LocalDrivingLicenseApplicationID desc";

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

        public static bool DosePersonHaveAnActiveApplication(int ApplicantPersonID, int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "select Found = 1 from Applications inner join LocalDrivingLicenseApplications "+
                "on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID inner join LicenseClasses "+
                "on LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID " +
                "where ApplicantPersonID = @ApplicantPersonID and LicenseClasses.LicenseClassID = @LicenseClassID and ApplicationStatus = 1";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    IsFound = true;
                }

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

        static public int UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int RowAfected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"Update[dbo].[LocalDrivingLicenseApplications] set [ApplicationID] = @ApplicationID,
                            [LicenseClassID] = @LicenseClassID Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {

                connection.Open();
                RowAfected = cmd.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return RowAfected;
        }

        static public int DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int RowAfected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"Delete From [dbo].[LocalDrivingLicenseApplications] Where 
                            LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {

                connection.Open();
                RowAfected = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return RowAfected;
        }

      
        static public bool DoseAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            bool IsAttended = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @"SELECT TOP 1 * FROM LocalDrivingLicenseApplications
                            INNER JOIN TestAppointments ON  LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                          
                            WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ) AND ( TestAppointments.TestTypeID  = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    IsAttended = true;
                }

            }
            catch (Exception )
            {
               return false;
            }
            finally
            {
                connection.Close();
            }

            return IsAttended;

        }

        static public bool IsThereAnActiveTestApointment(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool Result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked = 0
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Result = true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return Result;
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {


            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }

            catch (Exception )
            {

            }

            finally
            {
                connection.Close();
            }

            return Result;

        }

    }
}
