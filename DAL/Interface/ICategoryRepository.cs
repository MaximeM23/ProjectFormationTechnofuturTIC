using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetAllWineTypeCategory(int IdWine, int IdTag);

        IEnumerable<Category> GetAllCategoriesByType(int IdType);

        int InsertNewWineCategory(int IdWine, int IdCategory);
    }
}
