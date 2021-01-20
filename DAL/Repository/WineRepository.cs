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
            Connection.Command cmd = new Connection.Command("GetWineById", true);
            cmd.AddParameter("@id", value);
            return _con.ExecuteReader(cmd, Mapper.WineToDAO).SingleOrDefault();
        }

        public IEnumerable<Wine> GetWineByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wine> GetWineByProviderId(int idProvider)
        {
            Connection.Command cmd = new Connection.Command("GetWineByProviderId", true);
            cmd.AddParameter("@IdProvider", idProvider);
            return _con.ExecuteReader(cmd, Mapper.WineToDAO);
        }

        public IEnumerable<Price> GetWinePrice(int idWine)
        {
            Connection.Command cmd = new Connection.Command("GetWinePrices", true);
            cmd.AddParameter("@IdWine", idWine);
            return _con.ExecuteReader(cmd, Mapper.PriceToDAO);
        }

        public int Insert(Wine value)
        {
            Connection.Command cmd = new Connection.Command("InsertNewWine", true);
            cmd.AddParameter("@WineName", value.WineName);
            cmd.AddParameter("@Description", value.Description);
            cmd.AddParameter("@Year", value.Year);
            cmd.AddParameter("@IdProvider", value.IdProvider);
            return (int)_con.ExecuteScalar(cmd);
        }

        public int InsertPriceForwine(Price price)
        {
            Connection.Command cmd = new Connection.Command("InsertNewWinePrice", true);
            cmd.AddParameter("@IdWine",price.IdWine);
            cmd.AddParameter("@Price", price.PriceWine);
            return _con.ExecuteNonQuery(cmd);
        }

        public bool Update(Wine newValue)
        {
            throw new NotImplementedException();
        }
    }
}
