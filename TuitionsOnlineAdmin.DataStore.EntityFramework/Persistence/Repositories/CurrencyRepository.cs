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
        private readonly TuitionsOnlineAdminDbContext _database;
        public CurrencyRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;

        }
        //To create a single record for Currency
        public void CreateCurrencyRepository(Currency currency)
        {
            _database.Currency.Add(currency);
            _database.SaveChanges();

        }
    }
}
