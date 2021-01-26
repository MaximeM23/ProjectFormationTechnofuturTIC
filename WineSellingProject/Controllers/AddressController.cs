using DTO.Interface;
using DTO.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineSellingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase
    {
        IAddressService _addressService;
        IClientAddressService _clientAddressService;
        ICityService _cityService;
        public AddressController(IAddressService addressService, IClientAddressService clientAddressService, ICityService cityService)
        {
            _addressService = addressService;
            _clientAddressService = clientAddressService;
            _cityService = cityService;
        }

        [HttpGet("{id}")]
        public IActionResult GetAllByIdUser(int id)
        {
            return Ok(_addressService.GetAddressesByIdUser(id));
        }

        [HttpPost]
        [Route("{idClient}")]
        public IActionResult Insert([FromBody] Address value, int IdClient)
        {
            if (value.City.Id == 0)
            {
                int IdCity = _cityService.GetIdByValues(value.City.Country, value.City.PostalCode, value.City.CityName);
                value.City.Id = IdCity;
            }
            int insertedAddressId = _addressService.Insert(value);
            if (insertedAddressId > 0)
            {
                _clientAddressService.Insert(new ClientAddress()
                {
                    IdAddress = insertedAddressId,
                    IdClient = IdClient
                });
                return Ok(insertedAddressId);
            }
            return Ok("Error while inserting data");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Address value)
        {
            if (value.City.Id == 0)
            {
                int IdCity = _cityService.GetIdByValues(value.City.Country, value.City.PostalCode, value.City.CityName);
                value.City.Id = IdCity;
            }
            return Ok(_addressService.Update(value));
            
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_addressService.Delete(id));
        }
    }
}
