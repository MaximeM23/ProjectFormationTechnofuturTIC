using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetClientByMailAndPasswordMatch(string email, string password);
        bool UpdateClientWithoutPassword(Client client);
        bool FindEmail(string email);
    }
}
