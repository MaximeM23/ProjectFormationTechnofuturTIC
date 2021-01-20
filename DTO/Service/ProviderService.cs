using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Tools;

namespace DTO.Service
{
    public class ProviderService : IProviderService
    {
        IProviderRepository _providerRepo;
        public ProviderService(IProviderRepository providerRepository)
        {
            _providerRepo = providerRepository;
        }
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
            return _providerRepo.GetProviderByMailAndPasswordMatch(mail, password).ProviderDTOToProviderDAO();
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
