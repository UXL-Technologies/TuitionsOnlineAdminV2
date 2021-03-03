//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:18-Jan-2021
//Aim: defining the pluginInterface  Repository  for Currency



using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ICurrencyRepository
    {
        //To hold the contract for creating the Currency and store it in a database
        string CreateCurrencyRepository(Currency currency);
        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:18-Jan-2021
        //To hold the contract for viewing Currency
        List<Currency> ViewCurrencyRepository(string searchKey);
        //To hold the contract for updating Currency
        string UpdateCurrencyRepository(Currency currency);
    }
}
