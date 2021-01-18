using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface ICommentRepository : IRepository<Comment>
    {
        IEnumerable<Comment> GetCommentByWineId(int IdWine);
    }
}
