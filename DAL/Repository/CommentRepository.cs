using DAL.Interface;
using DAL.Models;
using DAL.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Connection = Tools.Connection;

namespace DAL.Repository
{
    public class CommentRepository : BaseRepository, ICommentRepository
    {
        public CommentRepository(IConfiguration config) : base(config)
        {
        }

        public int Delete(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentByWineId(int IdWine)
        {
            Connection.Command cmd = new Connection.Command("GetCommentByIdWine", true);
            cmd.AddParameter("@idWine", IdWine);
            return _con.ExecuteReader(cmd, Mapper.CommentToDAO);
        }

        public Comment GetOne(int value)
        {
            throw new NotImplementedException();
        }

        public int Insert(Comment value)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comment newValue)
        {
            throw new NotImplementedException();
        }
    }
}
