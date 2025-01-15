using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4.Q_2_2
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string name, string pass);
        bool AuthorizeUser (string name, string role);
    }
}
