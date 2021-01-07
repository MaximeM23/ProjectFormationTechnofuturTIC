using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Picture
    {
        public int Id { get; private set; }
        public string UrlName { get; private set; }
        public Picture(int id, string urlName)
        {
            Id = id;
            UrlName = urlName;
        }

    }
}
