//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the Class for CityUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen
{
    public class CreateCityUseCase : ICreateCityUseCase

    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateCityUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create Cities in IunitOfwork
        public string CreateCity(City city)
        {

            Console.WriteLine("I have reached create city");
           string result =  instanceOfIUnitOfWork.CreateCity(city);
            return result; 
        }


    }
}
