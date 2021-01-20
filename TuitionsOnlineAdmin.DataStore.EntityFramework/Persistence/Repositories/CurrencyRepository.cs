//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: implementing the inteface ICurrencyRepository


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class CurrencyRepository : ICurrencyRepository

    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public CurrencyRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }
        //To create a single record for Currency
        public void CreateCurrencyRepository(Currency currency)
        {
            instanceOfDbContext.Currency.Add(currency);
            instanceOfDbContext.SaveChanges();

        }

        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //To view Currency based on the search criteria 
        public List<Currency> ViewCurrencyRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
            if (searchKey != null)
            {
                List<Currency> currencyList = new List<Currency>();
                currencyList = instanceOfDbContext.Currency.Where(s => s.CurrencyName.Contains(searchKey)).ToList();
                return currencyList;
            }
            //if not entire list of data is displayed
            else

            {
                var currencyList = instanceOfDbContext.Currency.ToList();
                return currencyList;
            }
        }
        //To update Currency
        public string UpdateCurrencyRepository(Currency currency)
        {
            Currency currencyToBeUpdated = instanceOfDbContext.Currency.FirstOrDefault(s => s.CurrencyId == currency.CurrencyId);
            currencyToBeUpdated = currency;
            instanceOfDbContext.Currency.Append(currencyToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }
    }
}
