//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the Interface for CurrencyUsecase ;



using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Currencies.CreateCurrencyScreen.Interfaces
{
    public interface ICreateCurrencyUseCase
    {
        void CreateCurrency(Currency currency);
    }
}
