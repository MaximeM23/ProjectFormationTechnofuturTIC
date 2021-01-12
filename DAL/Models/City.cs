using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class City
    {
      
        public int Id { get; set; }
        public string CityName { get; set; }
        public string? PostalCode { get; set; }
        public string Country { get; set; }

    }
}
