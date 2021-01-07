using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Advertisement
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public bool Disabled { get; private set; }
        public DateTime DateOfPublication { get; private set; }
        public List<Picture> Pictures { get; private set; }
        public Advertisement(int id, string description, bool disabled, DateTime dateOfPublication, List<Picture> pictures)
        {
            Id = id;
            Description = description;
            Disabled = disabled;
            DateOfPublication = dateOfPublication;
            Pictures = pictures;
        }

    }
}
