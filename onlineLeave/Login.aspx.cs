using System;
using onlineLeave;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlineLeave
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginRepository loginRepository = new LoginRepository();
            string username = userName.Text;
            string password = Password.Text;
            bool result = loginRepository.login(username, password);
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
