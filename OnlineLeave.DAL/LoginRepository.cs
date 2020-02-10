using System;
using System.Configuration;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineLeave.DAL
{
    public class LoginRepository
    {
        public Boolean login(string userName, string password)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_login", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@userName", userName);
            sqlCommand.Parameters.AddWithValue("@password", password);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }


        }
    }
}
