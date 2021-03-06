﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Families.Data.Imp
{
    public class UserServiceImp : IUserService
    {
        private List<User> users;

        public UserServiceImp()
        {
            users = new[]
            {
                new User
                {
                    UserName = "admin",
                    Password = "admin"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}