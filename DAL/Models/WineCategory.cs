using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class WineCategory
    {
        public int Id { get; set; }
        public int IdWine { get; set; }
        public int IdCategory { get; set; }
    }
}
