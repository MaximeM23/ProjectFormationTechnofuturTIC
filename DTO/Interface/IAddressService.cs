using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface IAddressService : IService<Address>
    {
        IEnumerable<Address> GetAddressesByIdUser(int id);
    }
}
