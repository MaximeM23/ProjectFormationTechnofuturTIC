using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.Tools
{
    public static class Mapper
    {
    //    public static IEnumerable<Client> ClientToListDAO(IDataReader reader)
    //    {
    //        List<Client> listClient = new List<Client>();
    //        while (reader.Read())
    //        {
    //            Client client = new Client();
    //            client.Id = (int)reader["Client.Id"];
    //            client.Firstname = reader["Firstname"].ToString();
    //            client.Lastname = reader["Lastname"].ToString();
    //            client.PhoneNumber = reader["PhoneNumber"].ToString();
    //            client.Password = reader["Password"].ToString();
    //            client.EmailAddress = reader["EmailAddress"].ToString();
    //            client.BirthDate = (DateTime)reader["BirthDate"];
    //            client.Disabled = (bool)reader["Disabled"];
    //            client.Addresses = new List<Address>();
    //            client.Addresses.Add(new Address((int)reader["Address.Id"], (string)reader["Address.Street"], (string)reader["Address.Number"],
    //            new City((int)reader["City.Id"], (string)reader["City.CityName"], (string)reader["City.PostalCode"], (string)reader["City.Country"])));
    //            while (reader.Read() && listClient.Contains(client))
    //            {
    //                client.Addresses.Add(new Address((int)reader["Address.Id"], (string)reader["Address.Street"], (string)reader["Address.Number"],
    //                new City((int)reader["City.Id"], (string)reader["City.CityName"], (string)reader["City.PostalCode"], (string)reader["City.Country"])));                
    //            }
    //        }
    //        return listClient;
    //    }

    //    public static Client ClientToDAO(IDataReader reader)
    //    {
    //        Client client = new Client();
    //        while (reader.Read())
    //        {
    //            client.Id = (int)reader["Client.Id"];
    //            client.Firstname = reader["Firstname"].ToString();
    //            client.Lastname = reader["Lastname"].ToString();
    //            client.PhoneNumber = reader["PhoneNumber"].ToString();
    //            client.Password = reader["Password"].ToString();
    //            client.EmailAddress = reader["EmailAddress"].ToString();
    //            client.BirthDate = (DateTime)reader["BirthDate"];
    //            client.Disabled = (bool)reader["Disabled"];
    //            client.Addresses = new List<Address>();
    //            while (reader.Read())
    //            {
    //                client.Addresses.Add(new Address((int)reader["Address.Id"], (string)reader["Address.Street"], (string)reader["Address.Number"],
    //                new City((int)reader["City.Id"], (string)reader["City.CityName"], (string)reader["City.PostalCode"], (string)reader["City.Country"])));
    //            }
    //        }
    //        return client;
    //    }

        public static Address AddressToDAO(IDataReader reader)
        {
            return new Address
            {
                Id = (int)reader["IdAddress"],
                IdCity = (int)reader["IdCity"],
                Number = (string)reader["Number"],
                Street = (string)reader["Street"]
            };
        }
        public static City CityToDAO(IDataReader reader)
        {
            return new City
            {
                Id = (int)reader["IdCity"],
                CityName = (string)reader["CityName"],
                PostalCode = (reader["PostalCode"] != DBNull.Value) ? (string)reader["PostalCode"] : null ,
                Country = (string)reader["Country"]
            };
        }

        public static string CountryToDAO(IDataReader reader)
        {
            return (string)reader["Country"];
        }

        public static string CityStringToDAO(IDataReader reader)
        {
            return (string)reader["CityName"];
        }
        public static string CpToDAO(IDataReader reader)
        {
            return (reader["PostalCode"] != DBNull.Value) ? (string)reader["PostalCode"] : null;
        }


        public static Role RoleToDAO(IDataReader reader)
        {
            return new Role
            {
                Id = (int)reader["IdRole"],
                RoleName = (string)reader["RoleName"]
            };
        }

        public static Client ClientToDAO(IDataReader reader)
        {
            return new Client
            {
                Id = (int)reader["IdClient"],
                Firstname = reader["Firstname"].ToString(),
                Lastname = reader["Lastname"].ToString(),
                PhoneNumber = reader["PhoneNumber"].ToString(),
                EmailAddress = reader["EmailAddress"].ToString(),
                BirthDate = (reader["BirthDate"] != DBNull.Value) ? (DateTime?)reader["BirthDate"] : null,
                Disabled = (bool)reader["Active"],
                IdRole = (int)reader["IdRole"]               
            };
        }

        public static ClientAddress ClientAddressToDAO(IDataReader reader)
        {
            return new ClientAddress
            {
                Id = (int)reader["IdClientAddress"],
                IdClient = (int)reader["IdClient"],
                IdAddress = (int)reader["IdAddress"]
            };
        }

        public static Wine WineToDAO(IDataReader reader)
        {
            return new Wine
            {
                Description = (string)reader["Description"],
                Id = (int)reader["IdWine"],
                WineName = (string)reader["WineName"],
                Year = (int)reader["Year"]
            };
        }

        public static Price PriceToDAO(IDataReader reader)
        {
            return new Price
            {
                DateOfPrice = (DateTime)reader["DateOfPrice"],
                PriceWine = (decimal)reader["Price"]
            };
        }

        public static Category CategoryToDAO(IDataReader reader)
        {
            return new Category
            {
                CategoryName = (string)reader["CategoryName"],
                IdTag = (int)reader["IdTag"]
            };
        }

        public static Comment CommentToDAO(IDataReader reader)
        {
            return new Comment
            {
                CommentValue = (string)reader["Comment"],
                Id = (int)reader["IdComment"],
                IdClient = (int)reader["IdClient"],
                Note = (byte)reader["Note"]
            };
        }
        public static Provider ProviderToDAO(IDataReader reader)
        {
            return new Provider
            {
                Id = (int)reader["IdProvider"],
                Description = (string)reader["Description"],
                EmailAddress = (string)reader["EmailAddress"],
                Name = (string)reader["ProviderName"],
                PhoneNumber = (string)reader["PhoneNumber"]
            };
        }
    }
}
