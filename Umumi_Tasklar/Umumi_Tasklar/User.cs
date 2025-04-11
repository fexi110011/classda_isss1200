using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umumi_Tasklar
{
    internal class User
    {
        public string _userName { get; set; }
        private string _password { get; set; }
        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 25)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("UserName duzgun daxil edin(8 den boyuk,25 den kicik.)");
                }
            }
        }
        public string Password { 
            get
            {
                return _password;
            } 
            set
            {
                if (value.Length >= 8 && value.Length<=25)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Passwordu duzgun daxil edin(8 den boyuk,25 den kicik.)");
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
