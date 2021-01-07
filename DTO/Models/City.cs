using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class City
    {
      
        public int Id { get; private set; }
        public string CityName { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public City(int id, string cityName, string postalCode, string country)
        {
            Id = id;
            CityName = cityName;
            PostalCode = postalCode;
            Country = country;
        }

    }
}
