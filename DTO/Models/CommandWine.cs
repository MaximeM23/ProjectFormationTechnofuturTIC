using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class CommandWine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Wine Wine { get; set; }
        public Command Command { get; set; }
    }
}
