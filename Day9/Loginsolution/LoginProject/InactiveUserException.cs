using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    class InactiveUserException :ApplicationException
    {
        string msg;
        public InactiveUserException()
        {
            msg = "User account is deactivated. Please contact the administrator";
        }
        public override string Message => msg;
    }
}
