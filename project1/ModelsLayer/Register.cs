using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Register
    {
        public int RegisterId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
        public Register()
        {

        }


        public Register(int registerId, string name,string role, string email, string password, string confirmPassword)
        {
            RegisterId = registerId;
            Name = name;
            Role = role;
            EmailAddress = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}