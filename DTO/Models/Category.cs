using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Tag Tag { get; set; }
    }
}
