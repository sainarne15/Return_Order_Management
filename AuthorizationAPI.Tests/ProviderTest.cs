using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationAPI.Tests
{
    [TestFixture]
    public class ProviderTest
    {
        List<UserCredentials> user = new List<UserCredentials>();

        [SetUp]
        public void Setup()
        {
            user = new List<UserCredentials>()
            {
                new UserCredentials{Username = "user1",Password = "user1"}
 
            };

        }


        [TestCase("user1", "pass1")]
        public void GetUser_Returns_Object(string uname, string pass)
        {
            UserProvider pro = new UserProvider();
            UserCredentials cred = new UserCredentials { Username = uname, Password = pass };
        
            var userCred = pro.GetUser(cred);

            Assert.IsNotNull(userCred);
        }

        [TestCase("user1", "pass1")]
        public void GetUser_Returns_User1(string uname, string pass)
        {
            UserProvider pro = new UserProvider();
            UserCredentials cred = new UserCredentials { Username = uname, Password = pass };

            var userCred = pro.GetUser(cred);

            Assert.IsInstanceOf<UserCredentials>(userCred);
        }

        [TestCase("user3", "user3")]
        public void GetUser_Returns_Null(string uname, string pass)
        {
            UserProvider pro = new UserProvider();

            UserCredentials cred = new UserCredentials { Username = uname, Password = pass };

            var userCred = pro.GetUser(cred);

            Assert.IsNull(userCred);

        }


    }
}
