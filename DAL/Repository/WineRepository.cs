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
    public class WineRepository : BaseRepository, IWineRepository
    {
        public WineRepository(IConfiguration config) : base(config)
        {
        }

        public int Delete(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wine> GetAll()
        {
            Connection.Command cmd = new Connection.Command("GetAllWine", true);
            return _con.ExecuteReader(cmd, Mapper.WineToDAO);
        }

        public Wine GetOne(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wine> GetWineByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Price> GetWinePrice(int idWine)
        {
            Connection.Command cmd = new Connection.Command("GetWinePrices", true);
            cmd.AddParameter("@IdWine", idWine);
            return _con.ExecuteReader(cmd, Mapper.PriceToDAO);
        }

        public int Insert(Wine value)
        {
            throw new NotImplementedException();
        }

        public bool Update(Wine newValue)
        {
            throw new NotImplementedException();
        }
    }
}
