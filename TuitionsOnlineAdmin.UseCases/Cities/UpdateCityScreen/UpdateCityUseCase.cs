//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: Implementing the interface IUpdateCityUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.Cities.UpdateCityScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Cities.UpdateCityScreen
{
   public class UpdateCityUseCase: IUpdateCityUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateCityUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update City in IunitOfwork

        public string UpdateCity(City city)
        {
            instanceOfIUnitOfWork.UpdateCity(city);
            return "done";
        }
    }
}
