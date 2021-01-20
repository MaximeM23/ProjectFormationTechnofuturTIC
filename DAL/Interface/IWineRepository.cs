using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IWineRepository: IRepository<Wine>
    {
        IEnumerable<Wine> GetWineByCategory(string category);
        IEnumerable<Price> GetWinePrice(int idWine);

        IEnumerable<Wine> GetWineByProviderId(int idProvider);
    }
}
