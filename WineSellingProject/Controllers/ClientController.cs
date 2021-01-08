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

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientController : ControllerBase
    {
        IClientService _service;

        public ClientController(IClientService service)
        {
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
                return Ok(_service.UpdateClientWithoutPassword(client));
            }
            else
            {
                return Ok(_service.Update(client));
            }
        }
    }
}
