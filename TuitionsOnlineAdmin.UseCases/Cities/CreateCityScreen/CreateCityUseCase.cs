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
   public  class CreateCityUseCase: ICreateCityUseCase

    {
        private readonly IUnitOfWork unitOfWork;

        public CreateCityUseCase(IUnitOfWork unitOfWork)

        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateCity(City city)
        {
            
                Console.WriteLine("I have reached create city");
                unitOfWork.CreateCity(city);
            
        }


    }
}
