using DTO.Interface;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Token.Tools;

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        protected TokenManager _tokenManager { get; }
        IClientService _clientService; 

        public LoginController(TokenManager tokenManager, IClientService clientService)
        {
            _tokenManager = tokenManager;
            _clientService = clientService;
        }

        [HttpPost]
        public IActionResult Login([FromBody]LoginCredentials dt)
        {
            if(dt?.emailAddress == null || dt.password == null)
            {
                return BadRequest();
            }

            Client clientFound = _clientService.GetClientByMailAndPasswordMatch(dt.emailAddress,dt.password);

            if(clientFound == null)
            {
                return StatusCode(401);
            }

            string token = _tokenManager.GenerateToken(new TokenData()
            {
                UserId = clientFound.Id,
                Username = clientFound.EmailAddress,
                Role = clientFound.Role.RoleName
            });
            return Ok(new { token });
        }
    }
}
