using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
   class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Account(int id, string email, string login, string pass, DateTime registrationDate)
        {
            Id = id;
            Email = email;
            Login = login;
            Pass = pass;
            RegistrationDate = registrationDate;
        }

        public Account(int id, string email, string login, string pass)
            : this(id, email, login, pass, DateTime.Now)
        {
        }

        public Account(int id, string email, string login)
            : this(id, email, login, "defaultpass", DateTime.Now)
        {
        }

        public Account(int id, string email)
            : this(id, email, $"user{id}", "defaultpass", DateTime.Now)
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Password: {Pass}");
            Console.WriteLine($"Registration date: {RegistrationDate}");
        }
    }
}
