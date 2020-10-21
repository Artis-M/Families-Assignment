﻿using Models;

namespace Families.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}