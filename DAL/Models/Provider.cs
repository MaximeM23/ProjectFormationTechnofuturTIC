using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

    }
}
