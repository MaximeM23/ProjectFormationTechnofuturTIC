using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Command
    {
        public int Id { get; set; }
        public DateTime DateCommand { get; set; }
        public int IdAddress { get; set; }
        public int IdClient { get; set; }
    }
}
