using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ModelsLayer
{
    public class Register
    {
        public Register(int id, string fname, string lname, string role, string email, string password, string confirm)
        {
            RegisterId = id;
            FirstName = fname;
            LastName = lname;
            Role = role;
            EmailAddress = email;
            Password = password;
            ConfirmPassword = confirm;
        }

       
        public Register()
        {

        }
        public int RegisterId { get; set; }

        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        // public Register()
        // {

        // }



    }
}