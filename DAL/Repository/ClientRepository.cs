﻿using DAL.Interface;
using DAL.Models;
using DAL.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Connection = Tools.Connection;
using System.Linq;

namespace DAL.Repository
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(IConfiguration config) : base(config)
        {
            // Used to call BaseRepository to make the connection work
        }

        public int Insert(Client value)
        {
            Connection.Command cmd = new Connection.Command("CreateClient", true);
            cmd.AddParameter("@fn", value.Firstname);
            cmd.AddParameter("@ln", value.Firstname);
            cmd.AddParameter("@EmailAddress", value.EmailAddress);
            cmd.AddParameter("@Password", value.Password);
            cmd.AddParameter("@PhoneNumber", value.PhoneNumber);
            cmd.AddParameter("@BirthDate", value.BirthDate);
            return (int)_con.ExecuteScalar(cmd);
        }

        public int Delete(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            Connection.Command cmd = new Connection.Command("SelectAllClient", true);
            return _con.ExecuteReader(cmd, Mapper.ClientToDAO);
        }

        public Client GetOne(int value)
        {
            Connection.Command cmd = new Connection.Command("SelectClientById", true);
            cmd.AddParameter("@id", value);
            return _con.ExecuteReader(cmd, Mapper.ClientToDAO).SingleOrDefault();
        }

        public bool Update(Client newValue)
        {
            Connection.Command cmd = new Connection.Command("UpdateClient", true);
            cmd.AddParameter("@IdUser", newValue.Id);
            cmd.AddParameter("@fn", newValue.Firstname);
            cmd.AddParameter("@ln", newValue.Firstname);
            cmd.AddParameter("@EmailAddress", newValue.EmailAddress);
            cmd.AddParameter("@Password", newValue.Password);
            cmd.AddParameter("@PhoneNumber", newValue.PhoneNumber);
            cmd.AddParameter("@BirthDate", newValue.BirthDate);
            if(_con.ExecuteNonQuery(cmd) > 0) return true;
            return false;
        }
    }
}
