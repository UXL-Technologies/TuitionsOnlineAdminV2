﻿//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for CurrencyUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.Currencies.UpdateCurrencyScreen.Interface
{
   public interface IUpdateCurrencyUseCase
    {
        //Declaring a method to update the Currency
        string UpdateCurrency(Currency currency);
    }
}
