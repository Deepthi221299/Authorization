﻿using AuthorizationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Service
{
    public interface IUserService
    {
        public List<UserCredentials> GetAllUsers();
        public UserCredentials GetUser(UserToken user);
        public string GenerateJSONWebToken(string userRole);
    }
}
