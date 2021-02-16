//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: Implementing the interface IViewCityUseCase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.Cities.ViewCityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Cities.ViewCityScreen
{

    public class ViewCityUseCase : IViewCityUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewCityUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<City> ViewCity(string searchKey)
        {
            var cityList = instanceOfIUnitOfWork.ViewCities(searchKey);
            return cityList;
        }
    }
}
