using ApartmentManagementSystem.Business.Abstract;
using ApartmentManagementSystem.Entities.Concrete;
using ApartmentManagementSystem.Entities.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Business.Concrete
{
    public class TokenManager : ITokenService
    {
        private readonly IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        Dictionary<string, string> UserRecords = new Dictionary<string, string>
        {
            {"admin","ty123" }
        };
        public TokenDto Authenticate(UserDto user)
        {
            if (!UserRecords.Any(x => x.Key == user.Username && x.Value == user.Password))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.Now.AddMinutes(10),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new TokenDto
            {
                Token = tokenHandler.WriteToken(token)
            };
        }
    }
}
