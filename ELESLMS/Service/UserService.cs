using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ELESLMS.Data;
using Microsoft.EntityFrameworkCore;

namespace ELESLMS.Service
{
    public class UserService
    {
        private DbModel db;
        public UserService()
        {
            db = new DbModel();
        }
        public User Login(string UserName, string Password)
        {
            string hashedPasword = hashPassword(Password);
            var loginUser = db.Users.Where(u => u.UserName == UserName && u.Password == hashedPasword).Include(i => i.Role).FirstOrDefault();

            return loginUser;
        }

        public bool CheckPassword(User user, string password)
        {
            return user.Password == hashPassword(password);
        }
        public string hashPassword(string plainPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainPassword);
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(plainBytes);

                // Convert byte array to a string 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();

            }
        }

        public void ChangePassword(User user, string password)
        {
            var u = db.Users.Find(user.Id);
            u.Password = hashPassword(password);
            db.SaveChanges();
        }

        public bool Insert(User user)
        {
            return true;
        }

    }
}
