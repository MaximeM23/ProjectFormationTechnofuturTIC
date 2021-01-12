﻿using DAL.Interface;
using DTO.Interface;
using DTO.Models;
using DTO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.Service
{
    public class CityService : ICityService
    {
        private ICityRepository _cityRepo;
        public CityService(ICityRepository cityRepo)
        {
            _cityRepo = cityRepo;
        }
        public IEnumerable<City> GetAll()
        {
            return _cityRepo.GetAll().Select(x => x.CityDTOToCityDAO());
        }

        public IEnumerable<City> GetCitiesByCountry(string Country)
        {
            return _cityRepo.GetCityByCountryName(Country).Select(x => x.CityDTOToCityDAO());
        }

        public int Insert(City Value)
        {
            throw new NotImplementedException();
        }
    }
}