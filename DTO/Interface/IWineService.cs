using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface IWineService : IService<Wine>
    {
        IEnumerable<Wine> GetWineByProviderId(int idProvider);

        public IEnumerable<Category> GetAllCategoriesByTagId(int IdTag);

        public int EnableWine(int id);

    }
}
