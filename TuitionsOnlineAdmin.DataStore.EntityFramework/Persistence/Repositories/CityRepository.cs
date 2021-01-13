
//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the Repository for City

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class CityRepository : ICityRepository 
        
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;

        public CityRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {

            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for City
        public void CreateCityRepository(City city)
        {
            instanceOfDbContext.City.Add(city);
            instanceOfDbContext.SaveChanges();
        }
    }
}
