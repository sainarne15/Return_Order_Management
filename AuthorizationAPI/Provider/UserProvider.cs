using AuthorizationAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Provider
{
    public class UserProvider : IUserProvider
    {
        private static List<UserCredentials> UsersList = new List<UserCredentials>()
        {
            new UserCredentials{Username="user1", Password="pass1"},
            new UserCredentials{Username="user2", Password="pass2"},
            new UserCredentials{Username="user3", Password="pass3"}
        };
        public UserCredentials GetUser(UserCredentials user)
        {
            List<UserCredentials> list = GetUsers();
            UserCredentials uCred = list.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            return uCred;
        }

        public List<UserCredentials> GetUsers()
        {
            return UsersList;
        }
    }
}
