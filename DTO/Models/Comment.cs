using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Comment
    {
      
        public int Id { get; set; }
        public string CommentValue { get; set; }
        public int Note { get; set; }
        public ClientComment Client { get; set; }
        public int idClient { get; set; }
        public int IdWine { get; set; }
        public Comment(int id, string commentValue, int note, int idC,int Idw)
        {
            Id = id;
            CommentValue = commentValue;
            Note = note;
            idClient = idC;
            IdWine = Idw;
        }

    }
}
