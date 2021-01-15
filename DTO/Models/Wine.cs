using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Wine
    {
        public int Id { get; set; }
        public string WineName { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public bool Disabled { get; set; }
        public List<Category> Category { get; set; }
        public List<Price> Prices { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
