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
        IProviderService _providerService;

        public LoginController(TokenManager tokenManager, IClientService clientService, IProviderService providerService)
        {
            _tokenManager = tokenManager;
            _clientService = clientService;
            _providerService = providerService;
        }

        [HttpPost]
        public IActionResult Login([FromBody]LoginCredentials dt)
        {
            if(dt?.emailAddress == null || dt.password == null)
            {
                return BadRequest();
            }

            Client clientFound = _clientService.GetClientByMailAndPasswordMatch(dt.emailAddress,dt.password);
            Provider providerFound = null;
            if (clientFound == null)
            {
                providerFound = _providerService.GetProviderByPasswordAndMailMatch(dt.emailAddress,dt.password);
            }
            if ((clientFound == null)&&(providerFound == null))
            {
                return StatusCode(401);
            }
            string token = "";
            if (clientFound != null)
            {                
                token = _tokenManager.GenerateToken(new TokenData()
                {
                    UserId = clientFound.Id,
                    Username = clientFound.EmailAddress,
                    Role = clientFound.Role.RoleName
                });
            }
            if (providerFound != null)
            {

                token = _tokenManager.GenerateToken(new TokenData()
                {
                    UserId = providerFound.Id,
                    Username = providerFound.EmailAddress,
                    Role = "Provider"
                });
            }

            return Ok(new { token });
        }
    }
}
