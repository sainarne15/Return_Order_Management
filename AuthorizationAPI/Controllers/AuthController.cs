using AuthorizationAPI.Model;
using AuthorizationAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuthController));
        private readonly IUserRepo repo;
        public AuthController(IConfiguration config, IUserRepo _repo)
        {
            _config = config;
            repo = _repo;
        }


        [HttpPost]
        public IActionResult Login([FromBody] UserCredentials login)
        {
            AuthRepo auth_repo = new AuthRepo(_config, repo);
            _log4net.Info("Login initiated!");
            IActionResult response = Unauthorized();

            var user = auth_repo.AuthenticateUser(login);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                var tokenString = auth_repo.GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }


    }


}
