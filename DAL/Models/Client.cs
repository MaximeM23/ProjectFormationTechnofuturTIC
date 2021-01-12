using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Disabled { get; set; }
        public int IdRole { get; set; }

    }
}
