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
        private readonly IUnitOfWork unitOfWork;

        public CreateCurrencyUseCase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateCurrency(Currency currency)
        {
            unitOfWork.CreateCurrency(currency);
        }
    }
}
