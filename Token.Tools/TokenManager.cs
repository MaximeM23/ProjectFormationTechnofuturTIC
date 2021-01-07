using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Token.Tools
{
    public class TokenManager
    {
        private IConfiguration _config;

        public TokenManager(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(TokenData dt)
        {
            if (dt == null)
            {
                throw new ArgumentException(nameof(dt));
            }
            DateTime expirationDate = DateTime.Now.AddMinutes(double.Parse(_config["Jwt:LifeTime"]));
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Name,dt.Username),
                new Claim("UserId", dt.UserId.ToString()),
                new Claim(ClaimTypes.Role,dt.Role)
            };

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: expirationDate,
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public TokenData getData(ClaimsPrincipal cp)
        {
            if(cp == null)
            {
                throw new ArgumentNullException(nameof(cp));
            }

            if(!cp.HasClaim(c => c.Type == ClaimTypes.Name)
                && cp.HasClaim(c => c.Type == "UserId")
                && cp.HasClaim(c => c.Type == ClaimTypes.Role))
            {
                throw new SecurityTokenException("Missing claims");
            }
            return new TokenData()
            {
                UserId = ExtractClaim<int>(cp, "UserId"),
                Username = ExtractClaim(cp, ClaimTypes.Name),
                Role = ExtractClaim(cp, ClaimTypes.Role)
            };
        }

        private string ExtractClaim(ClaimsPrincipal cp, string TypeClaim)
        {
            return cp.Claims.SingleOrDefault(c => c.Type == TypeClaim)?.Value;
        }

        private T ExtractClaim<T>(ClaimsPrincipal cp, string TypeClaim)
        {
            return (T)Convert.ChangeType(ExtractClaim(cp, TypeClaim), typeof(T));
        }
    }
}
