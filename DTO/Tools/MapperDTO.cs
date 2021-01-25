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

        public static DTO.Models.ClientAddress ClientAddressDTOToDAO(this DAL.Models.ClientAddress CA)
        {
            return new DTO.Models.ClientAddress()
            {
                Id = CA.Id,
                IdAddress = CA.IdAddress,
                IdClient = CA.IdClient
            };
        }
        public static DAL.Models.ClientAddress ClientAddressDAOToDTO(this DTO.Models.ClientAddress CA)
        {
            return new DAL.Models.ClientAddress()
            {
                Id = CA.Id,
                IdAddress = CA.IdAddress,
                IdClient = CA.IdClient
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


        public static DTO.Models.Wine WineDTOToWineDAO(this DAL.Models.Wine wine)
        {
            return new DTO.Models.Wine()
            {
                Description = wine.Description,
                Id = wine.Id,
                WineName = wine.WineName,
                Year = wine.Year,
                Disabled = wine.Disabled                
            };
        }

        public static DAL.Models.Wine WineDAOToWineDTO(this DTO.Models.Wine wine)
        {
            return new DAL.Models.Wine()
            {
                Description = wine.Description,
                Id = wine.Id,
                WineName = wine.WineName,
                Year = wine.Year,
                Disabled = wine.Disabled,
                IdProvider = wine.IdProvider
            };
        }

        public static DAL.Models.Price PriceDALToPriceDTO(this DTO.Models.Price price)
        {
            return new DAL.Models.Price()
            {
                DateOfPrice = price.DateOfPrice,
                PriceWine = price.PriceWine,
                IdWine = price.IdWine
            };
        }

        public static DTO.Models.Price PriceDTOToPriceDAO(this DAL.Models.Price price)
        {
            return new DTO.Models.Price()
            {
                DateOfPrice = price.DateOfPrice,
                PriceWine = price.PriceWine,
                IdWine = price.IdWine
            };
        }

        public static DTO.Models.Category CategoryDTOToCategoryDAO(this DAL.Models.Category Category)
        {
            return new DTO.Models.Category()
            {
                CategoryName = Category.CategoryName,
                Id = Category.Id,
                Tag = new Models.Tag(Category.IdTag, "")
            };
        }
        public static DTO.Models.Comment CommentDTOToCommentDAO(this DAL.Models.Comment Comment)
        {
            return new DTO.Models.Comment(Comment.Id, Comment.CommentValue, Comment.Note,Comment.IdClient);            
        }


        public static DTO.Models.ClientComment ClientCommentDTOToClientCommentDAO(this DAL.Models.Client Client)
        {
            return new DTO.Models.ClientComment()
            {
                Firstname = Client.Firstname,
                Lastname = Client.Lastname
            };
        }

        public static DTO.Models.Provider ProviderDTOToProviderDAO(this DAL.Models.Provider Provider)
        {
            if(Provider != null)
            {
                return new DTO.Models.Provider()
                {
                    Description = Provider.Description,
                    EmailAddress = Provider.EmailAddress,
                    Id = Provider.Id,
                    Name = Provider.Name,
                    Password = Provider.Password,
                    PhoneNumber = Provider.PhoneNumber,                        
                };
            }
            return null;
        }

        public static DAL.Models.Command CommandDAOToCommanDTO(this DTO.Models.Command Command)
        {
            if(Command != null)
            {
                return new DAL.Models.Command()
                {
                    Id = Command.Id,
                    DateCommand = DateTime.Now,
                    IdClient = Command.IdClient,
                    IdAddress = Command.IdAddress
                };
            }
            return null;
        }

        public static DAL.Models.CommandWine CommandWineDAOToCommandWineDTO(this DTO.Models.CommandWine CommandWine)
        {
            if(CommandWine != null)
            {
                return new DAL.Models.CommandWine()
                {
                    Id = CommandWine.Id,
                    IdCommand = CommandWine.IdCommand,
                    IdWine = CommandWine.IdWine,
                    Quantity = CommandWine.Quantity,
                };
            }
            return null;
        }
    }
}
