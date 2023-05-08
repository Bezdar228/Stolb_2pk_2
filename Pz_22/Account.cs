using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    public class Account
    {
        private int _id;
        private string _username;
        private string _email;
        private string _password;
        private DateTime _registrationDate;
        private bool _isAdmin;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id должно быть больше нуля");
                }
                _id = value;
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Имя пользователя не может быть пустым или null");
                }
                _username = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email не может быть пустым или нулевым");
                }
                _email = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value == null || value.Length < 8 || !value.Any(char.IsDigit) || !value.Any(c => "!#@".Contains(c)))
                {
                    throw new ArgumentException("Пароль должен состоять как минимум из 8 символов и содержать как минимум одну цифру и один из следующих символов: !#@");
                }
                _password = value;
            }
        }

        public DateTime RegistrationDate { get; set; }
        public bool IsAdmin { get; set; }

        public Account(int id, string username, string email, string password, DateTime registrationDate, bool isAdmin)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
            IsAdmin = isAdmin;
        }
    }
}
