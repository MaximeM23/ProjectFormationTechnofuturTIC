using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Price
    {
        public int Id { get; private set; }
        public DateTime DateOfPrice { get; private set; }
        public decimal PriceWine { get; private set; }

    }
}
