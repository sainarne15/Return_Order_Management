using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using AuthorizationAPI.Repository;
using Castle.Core.Configuration;
using Confluent.Kafka;
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
    class RepositoryTest
    {
        private readonly IConfiguration _config;
        List<UserCredentials> user = new List<UserCredentials>();

        [SetUp]
        public void Setup()
        {
            user = new List<UserCredentials>()
            {
                new UserCredentials{Username = "user1",Password = "user1"}
            };

        }


        [TestCase("user1", "user1")]
        public void GetUserCred_Returns_Object(string uname, string pass)
        {
            UserCredentials cred = new UserCredentials { Username = uname, Password = pass };
            Mock<IUserProvider> mock = new Mock<IUserProvider>();
            

            mock.Setup(p => p.GetUser(It.IsAny<UserCredentials>())).Returns(user[0]);
            UserRepo uRepo = new UserRepo(mock.Object);
            

            var userCred = uRepo.GetUserCred(cred);

            Assert.IsInstanceOf<UserCredentials>(userCred);
        }

        [TestCase("user3", "user3")]
        public void GetUserCred_Returns_Null(string uname, string pass)
        {
            user[0] = null;
            UserCredentials cred = new UserCredentials { Username = uname, Password = pass };
            Mock<IUserProvider> mock = new Mock<IUserProvider>();
            mock.Setup(p => p.GetUser(It.IsAny<UserCredentials>())).Returns(user[0]);

            UserRepo uRepo = new UserRepo(mock.Object);

            var userCred = uRepo.GetUserCred(cred);

            Assert.IsNull(userCred);

        }
        [TestCase("user3", "user3")]
        public void GetUserCred_Returns(string uname, string pass)
        {
            user[0] = null;
            
        UserCredentials cred = new UserCredentials { Username = uname, Password = pass };
            Mock<IUserProvider> mock = new Mock<IUserProvider>();
            mock.Setup(p => p.GetUser(It.IsAny<UserCredentials>())).Returns(user[0]);

            AuthRepo uRepo = new AuthRepo(IConfiguration Config,mock.Object);

            var userCred = uRepo.GetUserCred(cred);

            Assert.IsNull(userCred);

        }
    }
}

