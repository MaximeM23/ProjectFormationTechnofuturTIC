using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int IdPictures { get; set; }

    }
}
