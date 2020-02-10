using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLeave.Entity
{
    public class EmployeeEntity
    {
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public long EmployeePhoneNumber { get; set; }
        public string EmployeeGender { get; set; }
        public DateTime EmployeeDateOfBirth { get; set; }
        public string EmployeeEmailId { get; set; }
        public string EmployeeDesignation { get; set; }

        public EmployeeEntity(string EmployeeName, int DepartmentId, long EmployeePhoneNumber, string EmployeeGender, DateTime EmployeeDateOfBirth, string EmployeeEmailId, string EmployeeDesignation)
        {
            this.EmployeeName = EmployeeName;
            this.DepartmentId = DepartmentId;
            this.EmployeePhoneNumber = EmployeePhoneNumber;
            this.EmployeeGender = EmployeeGender;
            this.EmployeeDateOfBirth = EmployeeDateOfBirth;
            this.EmployeeEmailId = EmployeeEmailId;
            this.EmployeeDesignation = EmployeeDesignation;
        }
    }
}
