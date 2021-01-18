using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Service
{
    public class ProviderService : IProviderService
    {
        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Provider> GetAll()
        {
            throw new NotImplementedException();
        }

        public Provider GetOne(int Id)
        {
            throw new NotImplementedException();
        }

        public Provider GetProviderByPasswordAndMailMatch(string mail, string password)
        {
            throw new NotImplementedException();
        }

        public int Insert(Provider Value)
        {
            throw new NotImplementedException();
        }

        public bool Update(Provider Value)
        {
            throw new NotImplementedException();
        }
    }
}
