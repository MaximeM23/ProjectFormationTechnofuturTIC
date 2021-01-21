using DTO.Interface;
using DTO.Models;
using Microsoft.AspNetCore.Authorization;
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


        [Route("provider/{id}")]
        [Authorize(Roles = "Provider")]
        public IActionResult GetAllByProviderId(int id)
        {
            return Ok(_wineService.GetWineByProviderId(id));
        }

        [HttpGet]
        [Route("categories/{id}")]
        [Authorize(Roles = "Provider")]
        public IActionResult GetAllCategories(int id)
        {
            return Ok(_wineService.GetAllCategoriesByTagId(id));
        }
        
        [HttpPost]
        [Authorize(Roles = "Provider")]
        public IActionResult InsertNewWine([FromBody] Wine wine)
        {
            return Ok(_wineService.Insert(wine));
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Provider")]
        public IActionResult DeleteWine(int id)
        {
            return Ok(_wineService.Delete(id));
        }

    }
}
