using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Tools;

namespace DTO.Service
{
    public class AddressService : IAddressService
    {
        private IAddressRepository _addressRepo;
        private ICityRepository _cityRepo;
        public AddressService(IAddressRepository addressRepo, ICityRepository cityRepo)
        {
            _addressRepo = addressRepo;
            _cityRepo = cityRepo;
        }

        public bool Delete(int Id)
        {
            if (_addressRepo.Delete(Id) > 0)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<Address> GetAddressesByIdUser(int id)
        {
            List<Address> addresses =  _addressRepo.GetAddressByIdUser(id).Select(x => x.AddressDTOToAddressDAO()).ToList();
            foreach(Address a in addresses)
            {
                a.City = _cityRepo.GetOne(a.City.Id).CityDTOToCityDAO();
            }
            return addresses;
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetOne(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Address Value)
        {
            return _addressRepo.Insert(Value.AddressDAOToAddressDTO());
        }

        public bool Update(Address Value)
        {
            return _addressRepo.Update(Value.AddressDAOToAddressDTO());
        }
    }
}
