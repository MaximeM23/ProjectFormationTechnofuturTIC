using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IClientAddressRepository
    {
        int Insert(ClientAddress Value);
    }
}
