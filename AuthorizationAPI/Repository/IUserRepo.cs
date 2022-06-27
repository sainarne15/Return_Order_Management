﻿using AuthorizationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Repository
{
    public interface IUserRepo
    {
        public UserCredentials GetUserCred(UserCredentials user);
    }
}
