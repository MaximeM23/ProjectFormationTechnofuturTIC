using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Interface;

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CityController : ControllerBase
    {
        ICityService _service;

        public CityController(ICityService service)
        {
            _service = service;
        }
        [HttpGet("{name}")]
        public IActionResult GetCitiesByCountry(string name)
        {
            return Ok(_service.GetCitiesByCountry(name));
        }
        [HttpGet]
        [Route("/api/Countries")]
        public IActionResult GetCountries()
        {
            return Ok(_service.GetCountries());
        }

        [HttpGet]
        [Route("/api/PostalCode/{name}")]
        public IActionResult GetPostalCode(string name)
        {
            return Ok(_service.GetCPByCityName(name));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
    }
}
