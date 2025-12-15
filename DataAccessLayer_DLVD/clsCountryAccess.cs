using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace DataAccessLayer_DLVD
{
    public class clsCountryAccess
    {
        static public DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM Countries";

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

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public string GetCountryName(int CountryID)
        {
            string CountryName = "";
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT CountryName FROM Countries where CountryID = @CountryID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    CountryName = result.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return CountryName;
        }

        static public bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {


            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM Countries where CountryID = @CountryID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = true;
                    CountryName = reader["CountryName"].ToString();
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

        static public bool GetCountryInfoByID(string CountryName, ref int CountryID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "SELECT * FROM Countries where CountryName = @CountryName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    IsFound = true;
                    CountryID = (int)reader["CountryID"];
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
    }


}

