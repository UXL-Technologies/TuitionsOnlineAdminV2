//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the Repository for currency


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class CurrencyRepository : ICurrencyRepository

    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
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
