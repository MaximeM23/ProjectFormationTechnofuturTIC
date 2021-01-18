using DTO.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private IWineService _wineService;
        public WineController(IWineService wineService)
        {
            _wineService = wineService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_wineService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_wineService.GetOne(id));
        }
    }
}
