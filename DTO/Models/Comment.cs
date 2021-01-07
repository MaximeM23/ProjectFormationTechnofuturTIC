using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Comment
    {
      
        public int Id { get; private set; }
        public string CommentValue { get; private set; }
        public int Note { get; private set; }
        public Client Client { get; private set; }
        public Comment(int id, string commentValue, int note, Client client)
        {
            Id = id;
            CommentValue = commentValue;
            Note = note;
            Client = client;
        }

    }
}
