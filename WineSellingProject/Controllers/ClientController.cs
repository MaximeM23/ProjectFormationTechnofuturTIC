﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Service;
using DTO.Interface;
using DTO.Models;

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            return Ok(_service.Update(client));
        }
    }
}
