using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public Role()
        {
            Id = -1;
            RoleName = "";
        }
        public Role(int id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

    }
}
