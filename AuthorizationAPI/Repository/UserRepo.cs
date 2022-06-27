using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Repository
{
    public class UserRepo : IUserRepo
    {
        private IUserProvider _prov;

        public UserRepo(IUserProvider provider)
        {
            _prov = provider;
        }
        public UserCredentials GetUserCred(UserCredentials user)
        {
            if(user==null)
            {
                return null;
            }
            UserCredentials userFound = _prov.GetUser(user);
            return userFound;
        }
    }
}
