using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public int IdCity { get; set; }
 
    }
}
