using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Service;
using DTO.Interface;
using DTO.Models;
using Microsoft.AspNetCore.Authorization;
using Token.Tools;

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IClientService _service;
        protected TokenManager _tokenManager { get; }

        public ClientController(TokenManager tokenManager, IClientService service)
        {
            _tokenManager = tokenManager;
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{Id}")]
        public IActionResult Details(int id)
        {
            return Ok(_service.GetUserWithAllInformationById(id));
        }

        [HttpPost]    
        public IActionResult Insert([FromBody] Client client)
        {
            return Ok(_service.Insert(client));
        }
        [HttpPut("{Id}")]
        public IActionResult Update([FromBody] Client client)
        {
            if((client.Password == "") || (client.Password == null))
            {
                if (_service.UpdateClientWithoutPassword(client))
                {

                    string token = _tokenManager.GenerateToken(new TokenData()
                    {
                        UserId = client.Id,
                        Username = client.EmailAddress,
                        Role = client.Role.RoleName
                    });
                    return Ok(new { token });
                }
                return Ok("Failed to update");
            }
            else
            {
                if (_service.Update(client))
                {
                    string token = _tokenManager.GenerateToken(new TokenData()
                    {
                        UserId = client.Id,
                        Username = client.EmailAddress,
                        Role = client.Role.RoleName
                    });
                    return Ok(new { token });
                }
                return Ok("Failed to update");
            }
        }
    }
}
