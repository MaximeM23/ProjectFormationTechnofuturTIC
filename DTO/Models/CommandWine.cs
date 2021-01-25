using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class CommandWine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int IdWine { get; set; }
        public int IdCommand { get; set; }
    }
}
