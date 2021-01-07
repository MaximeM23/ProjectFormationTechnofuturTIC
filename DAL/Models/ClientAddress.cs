using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ClientAddress
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdAddress { get; set; }
    }
}
