using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace WebApp
{
    public static class Utils
    {
        public static string CheckUserData(int id, string login, string name, string surname, string email, string phone, List<User> users)
        {
            string[] errors = new string[5]; string result = "";
            if (string.IsNullOrEmpty(login) || login.Length > 100) errors[0] = "login";
            if (string.IsNullOrEmpty(name) || name.Length > 30) errors[1] = "name";
            if (string.IsNullOrEmpty(surname) || surname.Length > 30) errors[2] = "surname";
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,10})*)(\.(\w){2,6})$")) errors[3] = "email";
            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, @"^(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?$")) errors[4] = "phone";
            if (errors[0] == null && errors[3] == null && errors[4] == null)
            {
                int f = (from u in users where login == u.Login select u.Id).FirstOrDefault(), s = (from u in users where email == u.Email select u.Id).FirstOrDefault(),
                    t = (from u in users where Regex.Replace(phone, "[^0-9]", "") == Regex.Replace(u.Phone, "[^0-9]", "") select u.Id).FirstOrDefault();
                foreach (User u in users)
                {
                    if (f == u.Id && f != id) errors[0] = "login";
                    if (s == u.Id && s != id) errors[3] = "email";
                    if (t == u.Id && t != id) errors[4] = "phone";
                }
            }                
            foreach (string s in errors) if (!string.IsNullOrEmpty(s)) result += s + ", ";
            return result;
        }

        public static string ConvertToSHA512(string str)
        {
            using SHA512 alg = SHA512.Create(); string result = "";
            foreach (byte i in alg.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str)))
                result += i.ToString("x2");
            return result;
        }

        public static string MakeToken(string login, string pwd_hash) => ConvertToSHA512(login) + pwd_hash;
    }

    public class LoginUser
    {
        public string Role { get; }
        public string Login { get; }
        public string PasswordHash { get; }
        public LoginUser(string role, string login, string pwd_hash) { Role = role; Login = login; PasswordHash = pwd_hash; }
    }

    public class UserModel
    {
        public int Id { get; }
        public string Login { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public string Phone { get; }
        public UserModel(int id, string login, string name, string surname, string email, string phone) { Id = id; Login = login; Name = name; Surname = surname; Email = email; Phone = phone; }
    }

    public class HotelModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        public string Room { get; set; }
    }
}