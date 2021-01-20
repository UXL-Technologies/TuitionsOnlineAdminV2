
//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim:implementing the inteface ICityRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class CityRepository : ICityRepository

    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public CityRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }
        //to create a single record for city
        public void CreateCityRepository(City city)
        {
            instanceOfDbContext.City.Add(city);
            instanceOfDbContext.SaveChanges();
        }

        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //To view City based on the search criteria 
        public List<City> ViewCityRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
            if (searchKey != null)
            {
                List<City> cityList = new List<City>();
                cityList = instanceOfDbContext.City.Where(s => s.CityName.Contains(searchKey)).ToList();
                return cityList;
            }
            //if not entire list of data is displayed
            else

            {
                var cityList = instanceOfDbContext.City.ToList();
                return cityList;
            }
        }

        //To update City
        public string UpdateCityRepository(City city)
        {
            City cityToBeUpdated = instanceOfDbContext.City.FirstOrDefault(s => s.CityId == city.CityId);
            cityToBeUpdated = city;
            instanceOfDbContext.City.Append(cityToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }



    }
}

