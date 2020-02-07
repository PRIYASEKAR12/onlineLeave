using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineLeave
{
    public class EmployeeRepository
    {
        public Boolean AddInput(string employeeName, string employeeId, string employeePhoneNumber, string employeeCity,string  employeeGmail, string employeeDesignation )
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand sqlCommand = new SqlCommand("InsertEmployee", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@employeeName", employeeName);
            sqlCommand.Parameters.AddWithValue("@employeeId", employeeId);
            sqlCommand.Parameters.AddWithValue("@employeePhoneNumber", employeePhoneNumber);
            sqlCommand.Parameters.AddWithValue("@employeeCity", employeeCity);
            sqlCommand.Parameters.AddWithValue("@employeeGmail", employeeGmail);
            sqlCommand.Parameters.AddWithValue("@employeeDesignation", employeeDesignation);
            sqlConnection.Open();
            dataAdapter.InsertCommand = sqlCommand;
            int result = dataAdapter.InsertCommand.ExecuteNonQuery();
            if (result>=1)
            {
                return true;
            }
            return false;
        }
    }
}