using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsTestAccess
    {


        public static bool GetTestInfoByID(int TestID,
           ref int TestAppointmentID, ref byte TestResult,
           ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    IsFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = Convert.ToByte(reader["TestResult"]);
                    if (reader["Notes"] == DBNull.Value)

                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }
                else
                {
                    // The record was not found
                    IsFound = false;
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

        static public bool GetLastTestPerPersonIDAndClassLicenseIDAndTestTypeID(int LocalDrivingLicenseApplicationID, int PersonID, int LicenseClassID, int TestTypeID, ref int TestID, ref int TestAppointmentID,
          ref byte TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"SELECT  top 1 Tests.TestID, 
                Tests.TestAppointmentID, Tests.TestResult, 
			    Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
                FROM            LocalDrivingLicenseApplications INNER JOIN
                Tests INNER JOIN
                TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID 

                ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                INNER JOIN
                Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                WHERE        (Applications.ApplicantPersonID = @PersonID) 
                        AND (LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID)
                        AND ( TestAppointments.TestTypeID=@TestTypeID)
                        AND LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                ORDER BY Tests.TestAppointmentID DESC"; ;

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = Convert.ToByte(reader["TestResult"]);
                    if (reader["Notes"] == DBNull.Value)

                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }
                else
                {
                    IsFound = false;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static bool DoseApplicationPassTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "select Found = 1 from TestsView " +
                "where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID  and TestResult = 1 ";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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

        public static DataTable GetAllTests()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = "SELECT * FROM Tests order by TestID";

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

        static public int TakeTest(int TestAppointmentID,
           byte TestResult, string Notes, int CreatedByUserID)
        {

            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "INSERT INTO [dbo].[Tests]  ([TestAppointmentID] , [TestResult]," +
                " [Notes] , [CreatedByUserID])" +
                " VALUES (@TestAppointmentID, @TestResult , @Notes ," +
                " @CreatedByUserID)" +
                " UPDATE TestAppointments SET  IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID" +
                " SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes != null) cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    TestID = id;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, byte TestResult,
        string Notes, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);

            string query = @"Update  Tests  
                            set TestAppointmentID = @TestAppointmentID,
                                TestResult=@TestResult,
                                Notes = @Notes,
                                CreatedByUserID=@CreatedByUserID
                                where TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
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
        static public int GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {

            int Number = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"select Count(*) from TestAppointments inner join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                           where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and Tests.TestResult = 1";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
      

            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                {
                    Number = Count;
                }

            }
            catch (Exception)
            {
                Number = 0;
            }
            finally
            {
                connection.Close();
            }

            return Number;
        }


        


        

    }
}
