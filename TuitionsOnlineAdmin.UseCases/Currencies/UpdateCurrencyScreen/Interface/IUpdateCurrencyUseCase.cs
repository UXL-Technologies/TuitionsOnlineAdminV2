//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:18-Jan-2021
//Aim: defining the Interface for CurrencyUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Currencies.UpdateCurrencyScreen.Interface
{
   public interface IUpdateCurrencyUseCase
    {
        //Declaring a method to update the Currency
        string UpdateCurrency(Currency currency);
    }
}
