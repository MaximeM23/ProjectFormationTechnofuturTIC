using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Tools;

namespace DTO.Service
{
    public class WineService : IWineService
    {
        IWineRepository _wineRepository;
        ICategoryRepository _categoryRepository;
        public WineService(IWineRepository wineRepository, ICategoryRepository categoryRepository)
        {
            _wineRepository = wineRepository;
            _categoryRepository = categoryRepository;
        }
        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wine> GetAll()
        {
            List<Wine> ListOfWines = new List<Wine>();            
            foreach(Wine w in _wineRepository.GetAll().Select(x => x.WineDTOToWineDAO()))
            {
                w.Prices = new List<Price>();
                foreach(Price p in _wineRepository.GetWinePrice(w.Id).Select(x => x.PriceDTOToWineDAO()))
                {
                    w.Prices.Add(p);
                }
                w.Category = _categoryRepository.GetAllWineTypeCategory(w.Id, 1).Select(x => x.CategoryDTOToCategoryDAO()).ToList();
                ListOfWines.Add(w);
            }
            return ListOfWines;
        }

        public Wine GetOne(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Wine Value)
        {
            throw new NotImplementedException();
        }

        public bool Update(Wine Value)
        {
            throw new NotImplementedException();
        }
    }
}
