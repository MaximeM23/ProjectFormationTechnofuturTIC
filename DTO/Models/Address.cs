using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public City City { get; set; }        
        public Address()
        {

        }
        public Address(int id, string street, string number, City city)
        {
            Id = id;
            Street = street;
            Number = number;
            City = city;
        }
 
    }
}
