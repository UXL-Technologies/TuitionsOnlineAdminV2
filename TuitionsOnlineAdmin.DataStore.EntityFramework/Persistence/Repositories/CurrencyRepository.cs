//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: implementing the inteface ICurrencyRepository


using System;
using System.Collections.Generic;
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
    }
}
