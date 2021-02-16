//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the pluginInterface  Repository  for City;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public  interface ICityRepository
    {
        //To hold the contract for creating the City and store it in a database
        string CreateCityRepository(City city);
        //Authors: SA, BM, SM
        //Date:18-Jan-2021
        //To hold the contract for viewing City
        List<City> ViewCityRepository(string searchKey);
        //To hold the contract for updating City
        string UpdateCityRepository(City city);
    }
}
