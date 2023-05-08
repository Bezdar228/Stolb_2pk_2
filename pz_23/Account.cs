using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    public class Account
    {
        private static int accountsCount;
        private static int accountsCountSince2020;

        public int Id { get; private set; }
        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email cannot be null or empty.");

                email = value;
            }
        }
        public string Login
        {
            get => login;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Login cannot be null or empty.");

                login = value;
            }
        }
        public string Pass
        {
            get => pass;
            set
            {
                if (value.Length < 8 || !ContainsDigits(value) || !ContainsLetters(value) || !ContainsSpecialChars(value))
                    throw new ArgumentException("Password must be at least 8 characters long, contain digits and letters, and include !#@ symbols.");

                pass = value;
            }
        }
        public DateTime RegistrationDate
        {
            get => registrationDate;
            set
            {
                if (value < new DateTime(2000, 1, 1) || value > new DateTime(2022, 1, 1))
                    throw new ArgumentOutOfRangeException("Registration date must be between 01.01.2000 and 01.01.2022.");

                registrationDate = value;
            }
        }

        public Account(int id, string email, string login, string pass, DateTime registrationDate)
        {
            Id = id;
            Email = email;
            Login = login;
            Pass = pass;
            RegistrationDate = registrationDate;

            accountsCount++;
            if (registrationDate.Year >= 2020)
                accountsCountSince2020++;
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

        public virtual void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Password: {Pass}");
            Console.WriteLine($"Registration date: {RegistrationDate}");
        }

        public static int AccountsCount => accountsCount;
        public static int AccountsCountSince2020 => accountsCountSince2020;

        private string email;
        private string login;
        private string pass;
        private DateTime registrationDate;

        private static bool ContainsDigits(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    return true;
            }

            return false;
        }

        private static bool ContainsLetters(string str)
        {
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    return true;
            }

            return false;
        }

        private static bool ContainsSpecialChars(string str)
        {
            foreach (char c in str)
            {
                if (c == '!' || c == '#' || c == '@')
                    return true;
            }

            return false;
        }
    }
}
