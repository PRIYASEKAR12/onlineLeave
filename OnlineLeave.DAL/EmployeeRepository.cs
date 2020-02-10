using OnlineLeave.Entity;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OnlineLeave.DAL
{
    public class EmployeeRepository
    {
       
        public static Boolean InsertEmployee(EmployeeEntity employee,int id)
        {
            string sqlConnection = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlCommand sqlCommand = new SqlCommand("spInsertTable", sqlConnect);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@EmployeeId", id);
            sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
            sqlCommand.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
            sqlCommand.Parameters.AddWithValue("@employeePhoneNumber", employee.EmployeePhoneNumber);
            sqlCommand.Parameters.AddWithValue("@EmployeeGender",employee.EmployeeGender);
            sqlCommand.Parameters.AddWithValue("@EmployeeDateOfBirth", employee.EmployeeDateOfBirth);
            sqlCommand.Parameters.AddWithValue("@EmployeeEmailId", employee.EmployeeEmailId);
            sqlCommand.Parameters.AddWithValue("@EmployeeDesignation", employee.EmployeeDesignation);
            sqlCommand.ExecuteNonQuery();
            int EmployeeValue = id;
            sqlConnect.Close();
            //Clear();
            if (EmployeeValue ==0)
            {
                return true ;
            }
            else
            {
               return false;
            }
        }
        public static DataTable ViewEmployee()
        {
            string sqlConnection = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("spDisplayAll", sqlConnect);
            sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            sqlCommand.Fill(dataTable);
            sqlConnect.Close();
            return dataTable;
        }
        public static DataTable Validate(int EmployeeId)
        {
            string sqlConnection = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("spDisplayId", sqlConnect);
            sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.SelectCommand.Parameters.AddWithValue("@EmployeeId", EmployeeId);
            DataTable dtbl = new DataTable();
            sqlCommand.Fill(dtbl);
            return dtbl;
        }
        public static void DeleteEmployee(int id)
        {
            string sqlConnection = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlCommand sqlCommand = new SqlCommand("spDeleteId", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@EmployeeId", id);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
