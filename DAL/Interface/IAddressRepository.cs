using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IAddressRepository : IRepository<Address>
    {
        IEnumerable<Address> GetAddressByIdUser(int id);

        Address GetAddressByClientAddress(int id);
    }
}
