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
    [Authorize]
    public class CommandController : ControllerBase
    {
        ICommandService _commandService;
        public CommandController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        [HttpPost]
        public IActionResult InsertNewCommand([FromBody] Command cmd)
        {
            return Ok(_commandService.Insert(cmd));
        }

        [HttpGet("{id}")]
        public IActionResult GetCommandByIdCommand(int id)
        {
            return Ok(_commandService.GetOne(id));
        }
    }
}
