using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class LoginCredentials
    {
        public int? UserId { get; set; }
        public string emailAddress { get; set; }
        public string password { get; set; }
    }
}
