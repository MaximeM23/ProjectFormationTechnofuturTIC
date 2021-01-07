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
    public class ClientAddressRepository : BaseRepository, IClientAddressRepository
    {
        public ClientAddressRepository(IConfiguration config) : base(config)
        {
        }

        public int Insert(ClientAddress Value)
        {
            Connection.Command cmd = new Connection.Command("CreateClientAddress", true);
            cmd.AddParameter("@IdAddress", Value.IdAddress);
            cmd.AddParameter("@IdClient", Value.IdClient);
            return _con.ExecuteNonQuery(cmd);
        }
    }
}
