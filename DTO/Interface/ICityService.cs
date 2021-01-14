using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface ICityService : IGetAllService<City>, IInsertService<City>
    {
        IEnumerable<string> GetCitiesByCountry(string Country);

        IEnumerable<string> GetCountries();

        IEnumerable<string> GetCPByCityName(string City);
    }
}
