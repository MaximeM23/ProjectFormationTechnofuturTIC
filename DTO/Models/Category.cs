using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public string CategoryName { get; private set; }
        public Tag Tag { get; private set; }
    }
}
