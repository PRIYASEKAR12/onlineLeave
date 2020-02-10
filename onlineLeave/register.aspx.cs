using System;
using System.Data;
using OnlineLeave.BL;
using System.Web.UI.WebControls;
using OnlineLeave.Entity;

namespace onlineLeave
{
    public partial class register : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDelete.Enabled = false;
                FillGridView();
            }

        }
        protected void linkonclick(object sender, EventArgs e)
        {
            int EmployeeId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            DataTable dtbl = EmployeeBL.Validate(EmployeeId);
            hfEmployeeId.Value = EmployeeId.ToString();
            getName.Text = dtbl.Rows[0]["EmployeeName"].ToString();
            getId.Text = dtbl.Rows[0]["DepartmentId"].ToString();
            getPhoneNumber.Text = dtbl.Rows[0]["EmployeePhoneNumber"].ToString();
            getGender.Text = dtbl.Rows[0]["EmployeeGender"].ToString();
            getDateOfBirth.Text = dtbl.Rows[0]["EmployeeDateOfBirth"].ToString();
            getEmail.Text = dtbl.Rows[0]["EmployeeEmailId"].ToString();
            getDesignation.Text = dtbl.Rows[0]["EmployeeDesignation"].ToString();
            btnDelete.Enabled = true;
        }


        protected void btnClear_Onclick(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            hfEmployeeId.Value = "";
            getName.Text =getId.Text = getPhoneNumber.Text = getGender.Text = getDateOfBirth.Text = getEmail.Text =getDesignation.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        protected void btnDelete_Onclick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hfEmployeeId.Value);
            EmployeeBL.DeleteEmployee(id);
            Clear();
            FillGridView();
            Response.Write("DeletedSuccessfully");
        }

        protected void btnSave_Onclick(object sender, EventArgs e)
        {
            int id=hfEmployeeId.Value == "" ? 0 : Convert.ToInt32(hfEmployeeId.Value);
            string EmployeeName = getName.Text;
            int DepartmentId = Convert.ToInt32(getId.Text);
            long EmployeePhoneNumber = Convert.ToInt64(getPhoneNumber.Text);
            string EmployeeGender = getGender.Text;
            DateTime EmployeeDateOfBirth = Convert.ToDateTime(getDateOfBirth.Text);
            string EmployeeEmailId = getEmail.Text;
            string EmployeeDesignation = getDesignation.Text;
            EmployeeEntity employee = new EmployeeEntity(EmployeeName, DepartmentId, EmployeePhoneNumber, EmployeeGender, EmployeeDateOfBirth, EmployeeEmailId, EmployeeDesignation);
            bool result = EmployeeBL.InsertEmployee(employee,id);
            if (result)
            {
                Response.Write("Successfully added");
            }
            else
            {
                Response.Write("Falied");
            }
            FillGridView();
        }
        private void FillGridView()
        {
            DataTable dataTable = EmployeeBL.ViewEmployee();
            gridTable.DataSource = dataTable;
            gridTable.DataBind();
        }
       
    }
}