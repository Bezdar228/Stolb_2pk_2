using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    public class Account : ICloneable
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        private string _pass;
        public DateTime RegistrationDate { get; set; }
        private static int _accountsCreatedSince2020;

        public Account(int id, string email, string login, string pass, DateTime registrationDate)
        {
            Id = id;
            Email = email;
            Login = login;
            Pass = pass;
            RegistrationDate = registrationDate;

            if (RegistrationDate.Year >= 2020)
            {
                _accountsCreatedSince2020++;
            }
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

        public  virtual void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Password: {Pass}");
            Console.WriteLine($"Registration date: {RegistrationDate}");
        }

        public object Clone()
        {
            return new Account(Id, Email, Login, Pass, RegistrationDate);
        }

        public string Pass
        {
            get => _pass;
            set
            {
                if (value.Length < 8 || !value.Any(char.IsDigit) || !value.Any(char.IsLetter) || !value.Any(c => "!#@".Contains(c)))
                {
                    throw new ArgumentException("Password must be at least 8 characters long, contain letters and digits, and contain at least one of the following symbols: ! # @.");
                }
                _pass = value;
            }
        }

        public static int AccountsCreatedSince2020
        {
            get => _accountsCreatedSince2020;
        }
    }
}
