using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ProviderPicture
    {
        public int Id { get; set; }
        public int IdProvider { get; set; }
        public int IdPicture { get; set; }
    }
}
