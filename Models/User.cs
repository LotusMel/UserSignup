using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }

        public User(string username, string password)
        {
            username = Username;
            
            password = Password;
        }
    }

}
