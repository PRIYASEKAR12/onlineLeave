using System;
using OnlineLeave.BL;
using OnlineLeave.Entity;

namespace onlineLeave
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string userChange = userName.Text;
            string password = Password.Text;
            LoginEntity loginEntity = new LoginEntity(userChange,password);
            LoginBL login = new LoginBL();
            bool result = login.login(userChange, password);
            if (result)
            {
                Response.Write("Successfull");
                Response.Redirect("register.aspx");
            }
            else
            {
                Response.Write("unsuccessful");
            }
        }

       
    }
}
