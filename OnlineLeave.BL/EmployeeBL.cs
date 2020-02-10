using OnlineLeave.Entity;
using OnlineLeave.DAL;
using System;
using System.Data;

namespace OnlineLeave.BL
{
    public class EmployeeBL
    {
        public static Boolean InsertEmployee(EmployeeEntity employee,int id)
        {
            bool result = EmployeeRepository.InsertEmployee(employee,id);
            return result;
        }

        public static DataTable ViewEmployee()
        {
            DataTable data = EmployeeRepository.ViewEmployee();
            return data;
        }
        public static DataTable Validate(int EmployeeId)
        {
            DataTable dataTable=EmployeeRepository.Validate(EmployeeId);
            return dataTable;
        }
        public static void DeleteEmployee(int id)
        {
            EmployeeRepository.DeleteEmployee(id);
        }
    }
}
