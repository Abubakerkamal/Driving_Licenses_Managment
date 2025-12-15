using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DLVD
{
    public class clsApplcationTypeAccess
    {
        static public DataTable GetAllAppTypes()
        {
          
                DataTable dt = new DataTable();
                SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
                string query = "SELECT * FROM ApplicationTypes";

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

        static public bool GetAppTypeByID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationTypeFees)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Select *From ApplicationTypes Where ApplicationTypeID = @ApplicationTypeID";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
  


            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    ApplicationTypeFees =Convert.ToDecimal( reader["ApplicationFees"]);


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

        static public int Update(int ApplicationTypeID,  string ApplicationTypeTitle,  decimal ApplicationTypeFees)
        {

            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.connectionString);
            string query = "Update [dbo].[ApplicationTypes] set [ApplicationTypeTitle] = @ApplicationTypeTitle ,[ApplicationFees] = @ApplicationTypeFees " +
                "where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);
  


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
