using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Tools
{
    public static class MapperDTO
    {
        #region Client and adresses mapper
        //public static DTO.Models.City CityDAOToCityDTO(this DAL.Models.City city)
        //{
        //    return new DTO.Models.City(city.Id, city.CityName, city.PostalCode, city.Country);
        //}
        //public static List<DTO.Models.Address> AddressDAOToClientDTO(this List<DAL.Models.Address> address)
        //{
        //    if (address == null) return null;
        //    List<DTO.Models.Address> dtoAddress = null;
        //    if(address.Count > 0)
        //    {
        //        dtoAddress = new List<DTO.Models.Address>();
        //        foreach(DAL.Models.Address ad in address)
        //        {
        //            dtoAddress.Add(new DTO.Models.Address(ad.Id, ad.Street, ad.Number, ad.City.CityDAOToCityDTO()));
        //        }
        //    }
        //    return dtoAddress;
        //}
        //public static DTO.Models.Client ClientDTOToClientDAO(this DAL.Models.Client client)
        //{
        //    return new DTO.Models.Client
        //    {
        //        Id = client.Id,
        //        Addresses = client.Addresses.AddressDAOToClientDTO(),
        //        BirthDate = client.BirthDate,
        //        Disabled = client.Disabled,
        //        EmailAddress = client.EmailAddress,
        //        Firstname = client.Firstname,
        //        Lastname = client.Lastname,
        //        PhoneNumber = client.PhoneNumber
        //    };
        //}

        public static DTO.Models.Client ClientDTOToClientDAO(this DAL.Models.Client client)
        {
            if (client == null) return null;
            return new DTO.Models.Client
            {
                Id = client.Id,
                BirthDate = client.BirthDate,
                Disabled = client.Disabled,
                EmailAddress = client.EmailAddress,
                Firstname = client.Firstname,
                Lastname = client.Lastname,
                PhoneNumber = client.PhoneNumber,
                IdRole = client.IdRole
            };
        }

        public static DAL.Models.Client ClientDALToClientDTO(this DTO.Models.Client client)
        {
            return new DAL.Models.Client
            {
                Id = client.Id,
                BirthDate = client.BirthDate,
                Disabled = client.Disabled,
                EmailAddress = client.EmailAddress,
                Firstname = client.Firstname,
                Password = client.Password,
                Lastname = client.Lastname,
                PhoneNumber = client.PhoneNumber,
                IdRole = client.IdRole
            };
        }
        public static DTO.Models.Address AddressDTOToAddressDAO(this DAL.Models.Address addr)
        {
            return new DTO.Models.Address(addr.Id, addr.Street, addr.Number,
                new Models.City(addr.IdCity, "", "", ""));
        }
        public static DAL.Models.Address AddressDAOToAddressDTO(this DTO.Models.Address addr)
        {
            return new DAL.Models.Address
            {
                Id = addr.Id,
                IdCity = addr.City.Id,
                Street = addr.Street,
                Number = addr.Number
            };
        }

        public static DAL.Models.City CityDAOToCityDTO(this DTO.Models.City city)
        {
            return new DAL.Models.City
            {
                Id = city.Id,
                CityName = city.CityName,
                Country = city.Country,
                PostalCode = city.PostalCode
            };
        }
        public static DTO.Models.City CityDTOToCityDAO(this DAL.Models.City City)
        {
            return new DTO.Models.City(City.Id, City.CityName, City.PostalCode, City.Country);
        }
        

        public static DTO.Models.Role RoleDTOToRoleDAO(this DAL.Models.Role role)
        {
            return new DTO.Models.Role(role.Id, role.RoleName);
        }
        #endregion

    }
}
