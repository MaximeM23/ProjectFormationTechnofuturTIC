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
    public class AddressRepository : BaseRepository, IAddressRepository
    {
        public AddressRepository(IConfiguration config) : base(config)
        {
            // Used to call BaseRepository to make the connection work
        }

        public int Insert(Address value)
        {
            Connection.Command cmd = new Connection.Command("CreateAddress", true);
            cmd.AddParameter("@IdCity", value.IdCity);
            cmd.AddParameter("@Number", value.Number);
            cmd.AddParameter("@Street", value.Street);
            return (int)_con.ExecuteScalar(cmd);
        }

        public int Delete(int value)
        {
            Connection.Command cmd = new Connection.Command("DeleteAddress", true);
            cmd.AddParameter("@IdAddress", value);
            return _con.ExecuteNonQuery(cmd);
        }

        public IEnumerable<Address> GetAddressByIdUser(int id)
        {
            Connection.Command cmd = new Connection.Command("GetAddressesForUser", true);
            cmd.AddParameter("@Id",id);
            return _con.ExecuteReader(cmd, Mapper.AddressToDAO);
        }

        public IEnumerable<Address> GetAll()
        {
            Connection.Command cmd = new Connection.Command("GetAddresses", true);
            return _con.ExecuteReader(cmd, Mapper.AddressToDAO);
        }

        public Address GetOne(int value)
        {
            Connection.Command cmd = new Connection.Command("GetAddressById", true);
            cmd.AddParameter("@id", value);
            return _con.ExecuteReader(cmd, Mapper.AddressToDAO).SingleOrDefault();
        }

        public bool Update(Address newValue)
        {
            Connection.Command cmd = new Connection.Command("UpdateAddress", true);
            cmd.AddParameter("@IdAddress", newValue.Id);
            cmd.AddParameter("@IdCity", newValue.IdCity);
            cmd.AddParameter("@Number", newValue.Number);
            cmd.AddParameter("@Street", newValue.Street);
            if(_con.ExecuteNonQuery(cmd) > 0) return true;
            return false;
        }
    }
}
