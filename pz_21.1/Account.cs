using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21._1
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }


        public Account(int id, string username, string email, string password, DateTime registrationDate)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;

        }
    }
}
