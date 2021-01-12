using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface IClientService : IService<Client>
    {
        Client GetUserWithAllInformationById(int id);

        Client GetClientByMailAndPasswordMatch(string email, string password);

        bool UpdateClientWithoutPassword(Client client);

        bool FindEmail(string email);
    }
}
