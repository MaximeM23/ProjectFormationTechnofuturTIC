using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Provider
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Password { get; private set; }
        public string EmailAddress { get; private set; }
        public string PhoneNumber { get; private set; }

    }
}
