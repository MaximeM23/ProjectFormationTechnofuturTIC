using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface ICityRepository : IRepository<City>
    {
        IEnumerable<string> GetCityByCountryName(string Country);

        IEnumerable<string> GetCPByCityName(string City);

        IEnumerable<string> GetCountries();
    }
}
