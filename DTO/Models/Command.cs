using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Command
    {
        public int Id { get; private set; }
        public int IdAddress { get; private set; }
        public int IdClient { get; private set; }
        public List<CommandWine> CommandWine { get; set; }
        public Command(int id, int idAddress, int idClient, List<CommandWine> commandWine)
        {
            Id = id;
            IdAddress = idAddress;
            IdClient = idClient;
            CommandWine = commandWine;
        }
    }
}
