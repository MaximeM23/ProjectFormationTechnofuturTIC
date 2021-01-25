using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.Tools;
using System.Linq;

namespace DTO.Service
{
    public class CommandService : ICommandService
    {
        private ICommandRepository _commandRepo;
        private IClientRepository _clientRepo;
        private IAddressRepository _addressRepo;
        private ICityRepository _cityRepo;
        private IWineRepository _wineRepo;
        public CommandService(ICommandRepository commandRepo, IClientRepository clientRepo, IAddressRepository addressRepo, ICityRepository cityRepo, IWineRepository wineRepo)
        {
            _commandRepo = commandRepo;
            _clientRepo = clientRepo;
            _addressRepo = addressRepo;
            _cityRepo = cityRepo;
            _wineRepo = wineRepo;
        }

        public IEnumerable<Command> GetAll()
        {
            throw new NotImplementedException();
        }

        public DetailsCommand GetOne(int Id)
        {
            DetailsCommand dc = new DetailsCommand();
            Command cmd = _commandRepo.GetOne(Id).CommandDTOToCommanDAO();
            dc.DateOfCommand = cmd.DateOfCommand;
            dc.Address = _addressRepo.GetAddressByClientAddress(cmd.IdAddress).AddressDTOToAddressDAO();
            dc.Address.City = _cityRepo.GetOne(dc.Address.City.Id).CityDTOToCityDAO();
            dc.Client = _clientRepo.GetOne(cmd.IdClient).ClientDTOToClientDAO();
            dc.Commandwine = _commandRepo.GetAllCommandWineByCommandId(Id).Select(x => x.CommandWineDAOToCommandWineDTO()).ToList();
            foreach(CommandWine cw in dc.Commandwine)
            {
                cw.wineName = _wineRepo.GetOne(cw.IdWine).WineName;
                cw.winePrice = _wineRepo.GetWinePrice(cw.IdWine).FirstOrDefault().PriceWine;
            }
            return dc;
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
