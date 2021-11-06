using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace TodoApi.Authentication
{
    public class JwtAuth : IJwtAuth
    {
        private const string Username = "tester";
        private const string Password = "P@ssw0rd";

        private readonly string _key;

        public JwtAuth(string key)
        {
            _key = key;
        }

        public string Authenticate(string username, string password)
        {
            // TODO: This is just for tutorial purpose. The real production application should have real flow to check username and password.

            if (!(username.Equals(Username) || password.Equals(Password)))
            {
                return null;
            }

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            var tokenKey = Encoding.ASCII.GetBytes(_key);

            var securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, username)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

            return jwtSecurityTokenHandler.WriteToken(token);
        }
    }
}