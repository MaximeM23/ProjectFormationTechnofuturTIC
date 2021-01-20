using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public List<Picture>? Pictures{ get; set; }
        public List<Advertisement>? Advertisements{ get; set; }
        public Provider(int id, string name, string description, string password, string emailAddress, string phoneNumber)
        {
            Id = id;
            Name = name;
            Description = description;
            Password = password;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public Provider()
        {
        }
    }
}
