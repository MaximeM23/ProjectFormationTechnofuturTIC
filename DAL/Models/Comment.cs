using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Comment
    {
      
        public int Id { get; private set; }
        public string CommentValue { get; private set; }
        public int Note { get; private set; }
        public int IdClient { get; private set; }

    }
}
