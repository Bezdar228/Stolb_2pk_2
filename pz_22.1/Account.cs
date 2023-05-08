using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22._1
{
    public class Account
    {
        private int _id;
        private string _email;
        private string _login;
        private string _pass;
        private DateTime _registrationDate;

        private static int _accountsCreatedSince2020 = 0;

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ID must be greater than zero.");
                }
                _id = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email must not be empty or whitespace.");
                }
                _email = value;
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Login must not be empty or whitespace.");
                }
                _login = value;
            }
        }

        public string Pass
        {
            get => _pass;
            set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Password must be at least 8 characters long.");
                }
                if (!value.Any(char.IsDigit) || !value.Any(char.IsLetter))
                {
                    throw new ArgumentException("Password must contain both letters and digits.");
                }
                if (!value.Any(c => "!#@".Contains(c)))
                {
                    throw new ArgumentException("Password must contain at least one of the following symbols: ! # @.");
                }
                _pass = value;
            }
        }

        public DateTime RegistrationDate
        {
            get => _registrationDate;
            set
            {
                if (value < new DateTime(2000, 1, 1) || value > new DateTime(2022, 1, 1))
                {
                    throw new ArgumentException("Registration date must be between 01.01.2000 and 01.01.2022.");
                }
                _registrationDate = value;
            }
        }

        public Account(int id, string email, string login, string pass, DateTime registrationDate)
        {
            Id = id;
            Email = email;
            Login = login;
            Pass = pass;
            RegistrationDate = registrationDate;

            if (registrationDate.Year >= 2020)
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

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Password: {Pass}");
            Console.WriteLine($"Registration date: {RegistrationDate}");
        }

        public static int AccountsCreatedSince2020 => _accountsCreatedSince2020;
    }

}
