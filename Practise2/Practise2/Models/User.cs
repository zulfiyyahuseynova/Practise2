using System;
using System.Collections.Generic;
using System.Text;

namespace Practise2.Models
{
    class User : IAcoount
    {
        private static int _id = 0;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            _id++;
            Id = _id;
        }

        //public User(string email, string password) : this()
        //{
        //    Email = email;
        //    Password = password;
        //}

        public bool PasswordChecker(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;

            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) isUpper = true;
                    else if (char.IsLower(item)) isLower = true;
                    else if (char.IsDigit(item)) isDigit = true;
                }
                if (isDigit && isLower && isUpper) return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {FullName}, Email: {Email}");
        }
    }
}
