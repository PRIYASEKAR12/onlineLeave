using System;
using OnlineLeave.DAL;

namespace OnlineLeave.BL
{
    public class LoginBL
    {
        public  Boolean login(string username,string password)
        {
            LoginRepository repository = new LoginRepository();
            return repository.login(username, password);
        }
    }
}
