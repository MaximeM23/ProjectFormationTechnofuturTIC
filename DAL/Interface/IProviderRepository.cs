using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IProviderRepository: IRepository<Provider>
    {
        Provider GetProviderByMailAndPasswordMatch(string email, string password);
    }
}
