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
    public class ProviderRepository : BaseRepository, IProviderRepository
    {
        public ProviderRepository(IConfiguration config) : base(config)
        {
        }

        public int Delete(int value)
        {
            throw new NotImplementedException();
        }
        public Provider GetProviderByMailAndPasswordMatch(string email, string password)
        {
            Connection.Command cmd = new Connection.Command("GetProviderByMailAndPasswordMatch", true);
            cmd.AddParameter("@email", email);
            cmd.AddParameter("@password", password);
            return _con.ExecuteReader(cmd, Mapper.ProviderToDAO).SingleOrDefault();
        }

        public IEnumerable<Provider> GetAll()
        {
            throw new NotImplementedException();
        }

        public Provider GetOne(int value)
        {
            throw new NotImplementedException();
        }

        public int Insert(Provider value)
        {
            throw new NotImplementedException();
        }

        public bool Update(Provider newValue)
        {
            throw new NotImplementedException();
        }
    }
}
