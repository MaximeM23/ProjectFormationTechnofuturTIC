using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ProviderAddress
    {
        public int Id { get; set; }
        public int IdProvider { get; set; }
        public int IdAddress { get; set; }
    }
}
