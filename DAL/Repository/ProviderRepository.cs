using DAL.Interface;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

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
