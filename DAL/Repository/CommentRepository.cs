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
            Connection.Command cmd = new Connection.Command("InsertNewComment", true);
            cmd.AddParameter("@Note", value.Note);
            cmd.AddParameter("@Comment", value.CommentValue);
            cmd.AddParameter("@IdClient", value.IdClient);
            cmd.AddParameter("@IdWine", value.IdWine);
            return _con.ExecuteNonQuery(cmd);
        }

        public bool Update(Comment newValue)
        {
            throw new NotImplementedException();
        }
    }
}
