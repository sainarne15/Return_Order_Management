﻿using AuthorizationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Provider
{
    public interface IUserProvider
    {
        public List<UserCredentials> GetUsers();

        public UserCredentials GetUser(UserCredentials user);
    }
}
