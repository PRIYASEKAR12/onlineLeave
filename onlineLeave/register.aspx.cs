using System;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlineLeave
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            string employeeName= getName.Text;
            string employeeId = getId.Text;
            string employeePhoneNumber = getPhoneNumber.Text;
            string employeeCity = getCity.Text;
            string employeeGmail = getGmail.Text;
            string employeeDesignation = getDesignation.Text;
            bool result = employeeRepository.AddInput(employeeName, employeeId,employeePhoneNumber,employeeCity,employeeGmail,employeeDesignation);
            if (result)
            {
                Response.Write("Added successfully");
                
            }
            else
            {
                Response.Write("unsuccessful");
            }

        }
    }
}