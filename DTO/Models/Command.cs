using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Command
    {
        public int Id { get; private set; }
        public DateTime DateCommand { get; private set; }
        public Address FacturationAddress { get; private set; }
        public Client Client { get; private set; }
        public Command(int id, DateTime dateCommand, Address facturationAddress, Client client)
        {
            Id = id;
            DateCommand = dateCommand;
            FacturationAddress = facturationAddress;
            Client = client;
        }
    }
}
