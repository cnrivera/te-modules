using Forms.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Web.DAL
{
    public class MockCityDAO : ICityDAO
    {
        public void AddCity(City city)
        {
            throw new NotImplementedException();
        }

        public IList<City> GetCities()
        {
            IList<City> = new List<City>();
            City oz = new City();
            oz.CityId = 1;
            oz.CountryCode = "USA";
            oz.District = "Kansas";
            oz.Population = 10;
            oz.Name = "Oz";
            myList.Add(oz);

            City a = new City();
            b.CityId = 1;
            b.CountryCode = "USA";
            b.District = "Florida";
            b.Population = 0;
            b.Name = "Atlantis";
            myList.Add(b);
        }

        public IList<City> GetCities(string countryCode, string district)
        {
            IList < City > = new List<City>();
            City oz = new City();
            oz.CityId = 1;
            oz.CountryCode = "USA";
            oz.District = "Kansas";
            oz.Population = 10;
            oz.Name = "Oz";
            myList.Add(oz);

            City a = new City();
            b.CityId = 1;
            b.CountryCode = "USA";
            b.District = "Florida";
            b.Population = 0;
            b.Name = "Atlantis";
            myList.Add(b);
        }

        public IList<string> GetCountryCodes()
        {
            IList<string> myList = new List<string>("USA,", "GBR", "CHN");
            return myList;
        }
    }
}
