using DAL.Interface;
using DAL.Models;
using DAL.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connection = Tools.Connection;

namespace DAL.Repository
{
    public class CommandRepository : BaseRepository, ICommandRepository
    {
        public CommandRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<Command> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommandWine> GetAllCommandWineByCommandId(int id)
        {
            Connection.Command cmd = new Connection.Command("GetAllCommandWineByCommandId", true);
            cmd.AddParameter("@IdCommand", id);
            return _con.ExecuteReader(cmd, Mapper.CommandWineToDAO);
        }

        public Command GetOne(int value)
        {
            Connection.Command cmd = new Connection.Command("GetCommandByIdCommand", true);
            cmd.AddParameter("@IdCommand", value);
            return _con.ExecuteReader(cmd, Mapper.CommandToDAO).FirstOrDefault();
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
