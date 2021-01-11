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
        void CreateCityRepository(City city);
    }
}
