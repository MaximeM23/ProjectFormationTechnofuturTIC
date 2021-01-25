using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Tools;

namespace DTO.Service
{
    public class CommandService : ICommandService
    {
        private ICommandRepository _commandRepo;
        public CommandService(ICommandRepository commandRepo)
        {
            _commandRepo = commandRepo;
        }
        public int Insert(Command Value)
        {
            int commandId = _commandRepo.Insert(Value.CommandDAOToCommanDTO());
            if (commandId > 0)
            {
                foreach (CommandWine cw in Value.CommandWine)
                {
                    cw.IdCommand = commandId;
                    _commandRepo.InsertCommandWine(cw.CommandWineDAOToCommandWineDTO());
                }
            }
            return commandId;
        }
    }
}
