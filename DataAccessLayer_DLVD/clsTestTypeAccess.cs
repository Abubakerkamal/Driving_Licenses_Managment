using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsTestTypeAccess
    {
        static public DataTable GetAllTestTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM TestTypes";

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

        static public bool GetTestTypeByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From TestTypes Where TestTypeID = @TestTypeID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);



            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeTitle = reader["TestTypeTitle"].ToString();
                    TestTypeDescription = reader["TestTypeDescription"].ToString();
                    TestTypeFees = Convert.ToDecimal(reader["TestTypeFees"]);


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

        static public int Update(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[TestTypes] set [TestTypeTitle] = @TestTypeTitle,[TestTypeDescription] = @TestTypeDescription ,[TestTypeFees] = @TestTypeFees " +
                "where TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);



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
