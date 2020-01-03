using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
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

        public void Register(int position, string name, string surname, string username, string email, string dependable, string password)
        {
            if (!UserExists(username))
            {
                if (position == 2)
                {
                    db.Users.Add(new Student()
                    {
                        Name = name,
                        Surname = surname,
                        UserName = username,
                        EMail = email,
                        Number = dependable,
                        Password = hashPassword(password),
                        CreatedTime = DateTime.Now
                    });
                    db.SaveChanges();
                }
                else if (position == 3)
                {
                    db.Users.Add(new Teacher()
                    {
                        Name = name,
                        Surname = surname,
                        UserName = username,
                        EMail = email,
                        Subject = dependable,
                        Password = hashPassword(password),
                        CreatedTime = DateTime.Now
                    });
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Username is taken");
            }
        }
        public User UserByUsername(string username)
        {
            return db.Users.FirstOrDefault(k => k.UserName == username);
        }

        public bool UserExists(string username)
        {
            var f = UserByUsername(username);
            if (f==null)
            {
                return false;
            }
            else
            {
                return true;
            }
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
        public void ChangePassword(string username, string password)
        {
            var f = UserByUsername(username);
            f.Password = hashPassword(password);
            db.SaveChanges();
        }
        public void SetSecretQuestionAndAnswer(User user,int secretQuestion, string answer)
        {
            var u = db.Users.Find(user.Id);
            u.SecretQuestion = (SecretQuestion)secretQuestion;
            u.SecretAnswer = answer;
            db.SaveChanges();
        }
        public bool SecretQuestionCheck(string username, int secretQuestion,string answer)
        {
            var f = UserByUsername(username);
            if ((int)f.SecretQuestion==secretQuestion && f.SecretAnswer==answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteUser(User user)
        {
            var u = db.Users.Find(user.Id);
            u.IsDeleted = true;
            db.SaveChanges();
        }
    }
}
