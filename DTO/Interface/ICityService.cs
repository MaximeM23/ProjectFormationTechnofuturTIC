using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface ICityService : IGetAllService<City>, IInsertService<City>
    {
        IEnumerable<City> GetCitiesByCountry(string Country);
    }
}
