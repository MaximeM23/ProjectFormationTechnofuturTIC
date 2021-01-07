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
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetOne(int value)
        {
            Connection.Command cmd = new Connection.Command("GetRoleById", true);
            cmd.AddParameter("@id", value);
            return _con.ExecuteReader(cmd, Mapper.RoleToDAO).SingleOrDefault();
        }

    }
}
