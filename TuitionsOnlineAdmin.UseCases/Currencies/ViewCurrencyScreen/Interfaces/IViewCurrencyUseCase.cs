//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:18-Jan-2021
//Aim: defining the Interface for view CurrencyUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Currencies.ViewCurrencyScreen.Interfaces
{
   public interface IViewCurrencyUseCase
    {
        //Declaring a method to view the Currency
        List<Currency> ViewCurrency(string searchKey);
    }
}
