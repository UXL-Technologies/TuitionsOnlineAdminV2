//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the Class for CurrencyUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.Currencies.CreateCurrencyScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Currencies.CreateCurrencyScreen
{
    public class CreateCurrencyUseCase : ICreateCurrencyUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateCurrencyUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create Currency in IunitOfwork
        public string CreateCurrency(Currency currency)
        {
           string result =  instanceOfIUnitOfWork.CreateCurrency(currency);
            return result;
        }
    }
}
