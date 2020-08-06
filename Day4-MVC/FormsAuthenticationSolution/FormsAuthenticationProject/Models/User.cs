using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsAuthenticationProject.Models
{
    public class User
    {
        string username, password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}