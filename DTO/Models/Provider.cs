using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Provider
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Password { get; private set; }
        public string EmailAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public List<Picture> Pictures{ get; set; }
        public List<Advertisement> Advertisements{ get; set; }
        public Provider(string name, string description, string password, string emailAddress, string phoneNumber)
        {
            Name = name;
            Description = description;
            Password = password;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

    }
}
