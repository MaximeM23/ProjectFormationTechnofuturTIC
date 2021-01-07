using DAL.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Tools;
using System.Linq;
using DTO.Interface;

namespace DTO.Service
{
    public class ClientService : IClientService
    {
        private IClientRepository _clientRepo;
        private IAddressRepository _addressRepo;
        private IRoleRepository _roleRepo;
        private ICityRepository _cityRepo;
        private IClientAddressRepository _clientAddressRepo;
        public ClientService(IClientRepository clientRepo, IAddressRepository addressRepo, IRoleRepository roleRepo, ICityRepository cityRepo, IClientAddressRepository clientAddressRepo)
        {
            _clientRepo = clientRepo;
            _addressRepo = addressRepo;
            _cityRepo = cityRepo;
            _roleRepo = roleRepo;
            _clientAddressRepo = clientAddressRepo;
        }

        public bool Delete(int Id)
        {
            return false;
        }
        
        public IEnumerable<Client> GetAll()
        {
            return _clientRepo.GetAll().Select(x => x.ClientDTOToClientDAO());
        }

        public Client GetClientByMailAndPasswordMatch(string email, string password)
        {
            Client baseClient = _clientRepo.GetClientByMailAndPasswordMatch(email, password).ClientDTOToClientDAO();
            baseClient.Role = new Role();            
            baseClient.Role = _roleRepo.GetOne(baseClient.IdRole).RoleDTOToRoleDAO();
            return baseClient;
        }

        public Client GetOne(int Id)
        {
            return _clientRepo.GetOne(Id).ClientDTOToClientDAO();
        }

        public Client GetUserWithAllInformationById(int id)
        {
            Client baseClient = _clientRepo.GetOne(id).ClientDTOToClientDAO();
            baseClient.Role = new Role();
            baseClient.Addresses = new List<Address>();
            foreach (Address a in _addressRepo.GetAddressByIdUser(id).Select(x => x.AddressDTOToAddressDAO()))
            {
                a.City = _cityRepo.GetOne(a.City.Id).CityDTOToCityDAO();
                baseClient.Addresses.Add(a);
            }
            baseClient.Role = _roleRepo.GetOne(baseClient.IdRole).RoleDTOToRoleDAO();
            return baseClient;
        }

        public int Insert(Client Value)
        {
            int idClientAddress = 0;
            int idAddress = 0;
            int idClient = 0;
            idClient = _clientRepo.Insert(Value.ClientDALToClientDTO());
            foreach(Address a in Value.Addresses)
            {
                idAddress = _addressRepo.Insert(a.AddressDAOToAddressDTO());
                DAL.Models.ClientAddress clientAddress = new DAL.Models.ClientAddress()
                {
                    IdAddress = idAddress,
                    IdClient = idClient
                };
                idClientAddress = _clientAddressRepo.Insert(clientAddress);
            }
            return ((idClientAddress > 0) && (idClient > 0) && (idAddress > 0)) ? 1 : 0;
        }

        public bool Update(Client Value)
        {
            _clientRepo.Update(Value.ClientDALToClientDTO());
            foreach(Address address in Value.Addresses)
            {
                _addressRepo.Update(address.AddressDAOToAddressDTO());
            }
            return true;
        }
    }
}
