using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4.Q_2_2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string name, string pass)
        {
            if (name == "ahmed" && pass == "1313")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string name, string role)
        {
            if (name == "ahmed" && role == "owner") {
                return true;            
            }
            return false;
        }
    }
}
