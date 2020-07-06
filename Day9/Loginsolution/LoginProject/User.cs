using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    class User :IComparable<User>
    {
        string username, password;
        int status=1;
        public User() {
            status = 1;
        }
        public void TakeUserData()
        {
            Console.WriteLine("Please enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter the password");
            password = Console.ReadLine();
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            status = 1;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }

        public int CompareTo(User other)
        {
            return this.username.CompareTo(other.username);
            
        }
        public override string ToString()
        {
            return username + " : " + password;
        }

    }
}
