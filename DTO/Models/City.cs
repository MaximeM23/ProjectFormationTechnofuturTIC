using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class City
    {
      
        public int Id { get; set; }
        public string CityName { get; set; }
        public string? PostalCode { get; set; }
        public string Country { get; set; }
        public City(int id, string cityName, string? postalCode, string country)
        {
            Id = id;
            CityName = cityName;
            PostalCode = postalCode;
            Country = country;
        }

    }
}
