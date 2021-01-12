using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string? Password { get; set; }
        public List<Address> Addresses { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Disabled { get; set; }
        public Role Role { get; set; }
        public int IdRole { get; set; }
        public Client()
        {

        }
        public Client(int id, string firstname, string lastname, string phoneNumber,string password ,string emailAddress, DateTime birthDate, List<Address> addresses, bool disabled,Role role)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Password = password;
            Addresses = addresses;
            BirthDate = birthDate;
            Disabled = disabled;
            Role = role;
        }

    }
}
