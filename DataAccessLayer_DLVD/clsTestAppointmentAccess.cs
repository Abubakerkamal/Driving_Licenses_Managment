using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsTestAppointmentAccess
    {

        static public DataTable GetAllTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees ,IsLocked
                        FROM TestAppointments 
                        where  LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID
                        Order by TestAppointmentID desc ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        static public int AddNew(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID,int RetakeTestApplicationID)
        {

            int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"INSERT INTO [dbo].[TestAppointments]  ([TestTypeID] , [LocalDrivingLicenseApplicationID],
                 [AppointmentDate] , [PaidFees] , [RetakeTestApplicationID] , [IsLocked] , [CreatedByUserID])
                  VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID , @AppointmentDate ,
                 @PaidFees , @RetakeTestApplicationID , @IsLocked , @CreatedByUserID) select SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            if(RetakeTestApplicationID == -1) cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            cmd.Parameters.AddWithValue("@IsLocked", 0);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    AppointmentID = id;
                }

            }
            catch (Exception ex)
            {
                return AppointmentID;

            }
            finally
            {
                connection.Close();
            }

            return AppointmentID;
        }

        static public int Update(int TestAppointmentID, DateTime AppointmentDate)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"Update [dbo].[TestAppointments] set [AppointmentDate] = @AppointmentDate
                           where TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            

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

        static public int LockTestAppointment(int TestAppointmentID)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"Update [dbo].[TestAppointments] set [IsLocked] = @IsLocked
                           where TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@IsLocked", 1);


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

        static public bool GetTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,ref DateTime AppointmentDate ,ref decimal PaidFees,ref int RetakeTestApplicationID , ref byte IsLocked, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From TestAppointments Where TestAppointmentID = @TestAppointmentID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);

                    if (reader["RetakeTestApplicationID"] == DBNull.Value) RetakeTestApplicationID = 0;
                    else RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    IsLocked = Convert.ToByte(reader["IsLocked"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;

        }

        static public bool GetLastTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, ref int TestAppointmentID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int RetakeTestApplicationID, ref byte IsLocked, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"Select top 1 *From TestAppointments where TestTypeID = @TestTypeID
                             LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                            order by TestAppointmentID desc";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);

                    if (reader["RetakeTestApplicationID"] == DBNull.Value) RetakeTestApplicationID = 0;
                    else RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    IsLocked = Convert.ToByte(reader["IsLocked"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;

        }


        static public bool GetTestAppointmentByTestTypeIDAndLDlApplicationID(int TestTypeID,  int LocalDrivingLicenseApplicationID, ref int TestAppointmentID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int RetakeTestApplicationID, ref byte IsLocked, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From Users Where TestTypeID = @TestTypeID and LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                    if (reader["RetakeTestApplicationID"] == DBNull.Value) RetakeTestApplicationID = 0;
                   else  RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    IsLocked = Convert.ToByte(reader["IsLocked"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {

                connection.Close();
            }

            return IsFound;

        }
        public static bool DoseApplicationHasTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, byte IsLocked = 0 )
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "select  Found = 1 from TestAppointments " +
                "where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID  and IsLocked = @IsLocked ORDER BY TestAppointmentID DESC";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);


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

        public static int TotalTrialPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int Trial = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"select Count(*) from TestAppointments 
                            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                            and TestTypeID = @TestTypeID and IsLocked = 1";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if ((result != null && int.TryParse(result.ToString(), out int count)))
                {
                    Trial = count;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return Trial;
        }

        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = @"SELECT TestID FROM Tests
                            WHERE TestAppointmentID = @TestAppointmentID ";



            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", @TestAppointmentID);

            try
            {

                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    TestID = id;
                }

            }
            catch (Exception)
            {
                return TestID;

            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }
    }
      

    
}
