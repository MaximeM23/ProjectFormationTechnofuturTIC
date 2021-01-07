using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Tag       
    {
       
        public int Id { get; private set; }
        public string TagName { get; private set; }
        public Tag(int id, string tagName)
        {
            Id = id;
            TagName = tagName;
        }

    }

}
