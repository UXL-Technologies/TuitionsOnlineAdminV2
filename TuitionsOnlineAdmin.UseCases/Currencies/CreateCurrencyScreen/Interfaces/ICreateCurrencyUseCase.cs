//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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
        //Declaring a method to create the Currency
        string CreateCurrency(Currency currency);
    }
}
