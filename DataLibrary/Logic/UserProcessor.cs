using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using SignupForm.Data;

namespace DataLibrary.Logic
{
    public class UserProcessor
    {
        public static void CreateUser(string username, string email)
        {
            UserContext context = new();

            context.Add(new UserModel
            {
                Username = username,
                EMail = email,
            });

            context.SaveChanges();
        }

        public static List<UserModel> ShowUsers()
        {
            UserContext context = new();
            return context.Users.ToList();
        }

    }
}
