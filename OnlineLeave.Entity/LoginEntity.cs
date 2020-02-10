using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLeave.Entity
{
    public class LoginEntity
    {
        public string userName;
        public string Password;
        public LoginEntity(string userName,string Password)
        {
            this.userName = userName;
            this.Password = Password;
        }
    }
}
