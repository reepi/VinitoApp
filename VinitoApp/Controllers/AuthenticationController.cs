using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using VinitoApp.Models;

namespace VinitoApp.Controllers
{
    [Route("api/POLICIA")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        #region Inyecciones
        private readonly IConfiguration _config;
        private readonly UserService _userService;

        public AuthenticationController(IConfiguration config, UserService userService)
        {
            _config = config;
            _userService = userService;
        }
        #endregion

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] CredentialsDTO credentials)
        {
            User? user = _userService.AuthenticateUser(credentials.Username,
                credentials.Password);

            if (user is not null)
            {
                var securityPassword = new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey]"]));

                var signature = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

                var claimsForToken = new List<Claim>();

                var jwtSecurityToken = new JwtSecurityToken(
                    _config["AuthenticationBuilder:Issuer"],
                    _config["Authentication:Audience"],
                    claimsForToken,
                    DateTime.UtcNow,
                    DateTime.UtcNow.AddHours(1),
                    signature);

                var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

                return Ok(tokenToReturn);
            }
            return Unauthorized();
        }

    }
}
