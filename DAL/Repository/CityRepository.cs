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
    public class CityRepository : BaseRepository, ICityRepository
    {
        public CityRepository(IConfiguration config) : base(config)
        {
        }

        public int Insert(City value)
        {
            Connection.Command cmd = new Connection.Command("CreateCity", true);
            cmd.AddParameter("@CityName", value.CityName);
            cmd.AddParameter("@Country", value.Country);
            cmd.AddParameter("@PostalCode", value.PostalCode);
            return _con.ExecuteNonQuery(cmd);
        }

        public int Delete(int value)
        {
            Connection.Command cmd = new Connection.Command("DeleteCityById", true);
            cmd.AddParameter("@Id", value);
            return _con.ExecuteNonQuery(cmd);
        }

        public IEnumerable<City> GetAll()
        {
            Connection.Command cmd = new Connection.Command("GetCities", true);
            return _con.ExecuteReader(cmd, Mapper.CityToDAO);
        }

        public City GetOne(int value)
        {
            Connection.Command cmd = new Connection.Command("GetCitiesById", true);
            cmd.AddParameter("@id", value);
            return _con.ExecuteReader(cmd, Mapper.CityToDAO).SingleOrDefault();
        }

        public bool Update(City newValue)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCityByCountryName(string Country)
        {
            Connection.Command cmd = new Connection.Command("GetCitiesByCountryName", true);
            cmd.AddParameter("@name", Country);
            return _con.ExecuteReader(cmd, Mapper.CityToDAO);
        }
    }
}
