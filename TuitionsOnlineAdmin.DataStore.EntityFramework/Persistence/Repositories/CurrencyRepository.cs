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
        public string CreateCurrencyRepository(Currency currency)
        {
            try {
                instanceOfDbContext.Currency.Add(currency);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_CURRENCY;
            }

        }

        //Authors: SA, BM, SM
        // Date:18-Jan-2021
        //To view Currency based on the search criteria 
        public List<Currency> ViewCurrencyRepository(string searchKey)
        {
            try {
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
            catch (Exception) {
                List<Currency> currencyList = new List<Currency>();
                return currencyList = null;
            }
            //if the seach key is present the list is displayed

        }
        //To update Currency
        public string UpdateCurrencyRepository(Currency currency)
        {
            try {
                Currency currencyToBeUpdated = instanceOfDbContext.Currency.FirstOrDefault(s => s.CurrencyId == currency.CurrencyId);
                currencyToBeUpdated = currency;
                instanceOfDbContext.Currency.Append(currencyToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_CURRENCY;
            }

        }
    }
}
