using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Wine
    {
        public int Id { get; private set; }
        public string WineName { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }
        public bool Disabled { get; private set; }
        public List<Category> Category { get; private set; }
        public List<Price> Prices { get; private set; }
        public List<Comment> Comments { get; private set; }
    }
}
