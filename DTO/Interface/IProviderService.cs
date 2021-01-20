using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface IProviderService : IService<Provider>
    {
        Provider GetProviderByPasswordAndMailMatch(string mail, string password);
    }
}
