using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOOPSExampleProject
{
    class InvalidNumberException :ApplicationException
    {
        string myMessage;
        public InvalidNumberException()
        {
            myMessage = "The number is invaid";
        }
        public override string StackTrace => "Hey this is an user defined exception. The user is not a valid user";
        public override string Message => myMessage;
    }
}
