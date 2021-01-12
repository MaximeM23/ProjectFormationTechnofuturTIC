using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface IAddressService : IGetAllService<Address>,IUpdateService<Address>,IDeleteService<Address>
    {
        IEnumerable<Address> GetAddressesByIdUser(int id);
    }
}
