using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Price
    {
        public DateTime? DateOfPrice { get; set; }
        public decimal PriceWine { get; set; }
        public int IdWine { get; set; }

    }
}
