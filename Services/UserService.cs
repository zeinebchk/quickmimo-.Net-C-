using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace quickmimo.Services
{
    public class UserService
    {

        public UserService() { }
        public bool validatePassword(string text)
        {
            return text.Length >= 8 && text.Any(char.IsUpper) && text.Any(char.IsDigit);
        }

        public bool validateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public bool validateNumTel(string numTel)
        {
            return numTel.Length == 8 && numTel.All(char.IsDigit);

        }
        public  string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        public  bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = this.HashPassword(enteredPassword);
            return enteredHash == storedHash;
        }
    }
}
