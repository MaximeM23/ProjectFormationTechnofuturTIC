using DAL.Interface;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Connection = Tools.Connection;

namespace DAL.Repository
{
    public class CommandRepository : BaseRepository, ICommandRepository
    {
        public CommandRepository(IConfiguration config) : base(config)
        {
        }

        public int Insert(Command value)
        {
            Connection.Command cmd = new Connection.Command("InsertCommand", true);
            cmd.AddParameter("@DateCommand", value.DateCommand);
            cmd.AddParameter("@IdClient", value.IdClient);
            cmd.AddParameter("@IdAddressBilling", value.IdAddress);
            return (int)_con.ExecuteScalar(cmd);
        }

        public int InsertCommandWine(CommandWine cw)
        {
            Connection.Command cmd = new Connection.Command("InsertCommandWine", true);
            cmd.AddParameter("@IdCommand", cw.IdCommand);
            cmd.AddParameter("@IdWine", cw.IdWine);
            cmd.AddParameter("@Quantity", cw.Quantity);
            return _con.ExecuteNonQuery(cmd);
        }
    }
}
