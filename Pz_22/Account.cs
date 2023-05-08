using System;

namespace pz_22
{
    class Account
    {
        private int id;
        private string email;
        private string login;
        private string pass;
        private DateTime registrationDate;

        private static int accountsSince2020;

        public int ID
        {
            get { return id; }
            set
            {
                if (value != null)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentNullException("ID cannot be null.");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }
            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    login = value;
                }
                else
                {
                    throw new ArgumentException("Login cannot be null or empty.");
                }
            }
        }

        public string Pass
        {
            get { return pass; }
            set
            {
                if (value.Length >= 8 && ContainsDigits(value) && ContainsLetters(value) && ContainsSymbols(value))
                {
                    pass = value;
                }
                else
                {
                    throw new ArgumentException("Password must be at least 8 characters long and contain digits, letters, and symbols !#@.");
                }
            }
        }

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set
            {
                if (value >= new DateTime(2000, 1, 1) && value <= new DateTime(2022, 1, 1))
                {
                    registrationDate = value;
                }
                else
                {
                    throw new ArgumentException("Registration date must be between 01.01.2000 and 01.01.2022.");
                }
            }
        }

        public static int AccountsSince2020
        {
            get { return accountsSince2020; }
        }

        public Account(int id, string email, string login, string pass, DateTime registrationDate)
        {
            ID = id;
            Email = email;
            Login = login;
            Pass = pass;
            RegistrationDate = registrationDate;

            if (registrationDate.Year >= 2020)
            {
                accountsSince2020++;
            }
        }

        public Account(int id, string email, string login, string pass)
            : this(id, email, login, pass, DateTime.Now)
        {
        }

        public Account(int id, string email, string login)
            : this(id, email, login, "password123")
        {
        }

        public Account(int id, string email)
            : this(id, email, "user123")
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Password: {Pass}");
            Console.WriteLine($"Registration date: {RegistrationDate.ToShortDateString()}");
        }

        private bool ContainsDigits(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsLetters(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsSymbols(string str)
        {
            return str.Contains("!") || str.Contains("#");



    }
    }
}