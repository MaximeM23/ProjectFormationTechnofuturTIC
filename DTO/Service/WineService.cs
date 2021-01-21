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
        ICommentRepository _commentRepository;
        IClientRepository _clientRepository;
        public WineService(IWineRepository wineRepository, ICategoryRepository categoryRepository, ICommentRepository commentRepository, IClientRepository clientRepository)
        {
            _wineRepository = wineRepository;
            _categoryRepository = categoryRepository;
            _commentRepository = commentRepository;
            _clientRepository = clientRepository;
        }
        public bool Delete(int Id)
        {
            return (_wineRepository.Delete(Id) != -1);
        }

        public IEnumerable<Wine> GetAll()
        {
            List<Wine> ListOfWines = new List<Wine>();            
            foreach(Wine w in _wineRepository.GetAll().Select(x => x.WineDTOToWineDAO()))
            {
                w.Prices = new List<Price>();
                foreach(Price p in _wineRepository.GetWinePrice(w.Id).Select(x => x.PriceDTOToPriceDAO()))
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
            Wine wine = _wineRepository.GetOne(Id).WineDTOToWineDAO();
            wine.Prices = new List<Price>();
            foreach (Price p in _wineRepository.GetWinePrice(wine.Id).Select(x => x.PriceDTOToPriceDAO()))
            {
                wine.Prices.Add(p);
            }
            wine.Category = _categoryRepository.GetAllWineTypeCategory(wine.Id, 1).Select(x => x.CategoryDTOToCategoryDAO()).ToList();
            wine.Comments = new List<Comment>();
            foreach(Comment c in _commentRepository.GetCommentByWineId(wine.Id).Select(x => x.CommentDTOToCommentDAO()))
            {
                c.Client = _clientRepository.GetOne(c.idClient).ClientCommentDTOToClientCommentDAO();
                wine.Comments.Add(c);
            }
            return wine;
        }

        public IEnumerable<Wine> GetWineByProviderId(int idProvider)
        {
            List<Wine> ListOfWines = new List<Wine>();
            foreach (Wine w in _wineRepository.GetWineByProviderId(idProvider).Select(x => x.WineDTOToWineDAO()))
            {
                w.Prices = new List<Price>();
                foreach (Price p in _wineRepository.GetWinePrice(w.Id).Select(x => x.PriceDTOToPriceDAO()))
                {
                    w.Prices.Add(p);
                }
                w.Category = _categoryRepository.GetAllWineTypeCategory(w.Id, 1).Select(x => x.CategoryDTOToCategoryDAO()).ToList();
                ListOfWines.Add(w);
            }
            return ListOfWines;
        }

        public int Insert(Wine Value)
        {
            int newWineId = _wineRepository.Insert(Value.WineDAOToWineDTO());
            if (newWineId > 0)
            {
                foreach(Category c in Value.Category)
                {
                    _categoryRepository.InsertNewWineCategory(newWineId, c.Id);
                }
                foreach(Price p in Value.Prices)
                {
                    p.IdWine = newWineId;
                    _wineRepository.InsertPriceForwine(p.PriceDALToPriceDTO());
                }
                return 1;
            }
            return 0;
        }

        public bool Update(Wine Value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategoriesByTagId(int IdTag)
        {
            return _categoryRepository.GetAllCategoriesByType(IdTag).Select(x => x.CategoryDTOToCategoryDAO());
        }
    }
}
