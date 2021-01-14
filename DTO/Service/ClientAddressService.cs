using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Tools;

namespace DTO.Service
{
    public class ClientAddressService: IClientAddressService
    {
        private IClientAddressRepository _clientAddressRepo;
        public ClientAddressService(IClientAddressRepository ClientAddressRepository)
        {
            _clientAddressRepo = ClientAddressRepository;
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ClientAddress Value)
        {
            return _clientAddressRepo.Insert(Value.ClientAddressDAOToDTO());
        }
    }
}
