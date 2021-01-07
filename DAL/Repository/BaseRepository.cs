using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Connection;

namespace DAL.Interface
{
    public class BaseRepository
    {
        internal Connection _con;

        IConfiguration _config;

        public BaseRepository(IConfiguration config)
        {
            _config = config;
            _con = new Connection(_config.GetConnectionString("DbConnectionString"));
        }
    }
}
