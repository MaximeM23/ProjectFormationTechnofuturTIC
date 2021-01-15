using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Wine
    {
        public int Id { get; set; }
        public string WineName { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public bool? Disabled { get; set; }
    }
}
