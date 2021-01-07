using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Wine
    {
        public int Id { get; private set; }
        public string WineName { get; private set; }
        public string Description { get; private set; }
        public int Year { get; private set; }
        public bool Disabled { get; private set; }
    }
}
