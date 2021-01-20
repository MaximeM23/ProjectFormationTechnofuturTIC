using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Comment
    {
      
        public int Id { get; set; }
        public string CommentValue { get; set; }
        public int Note { get; set; }
        public int IdClient { get; set; }

    }
}
