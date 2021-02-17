//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: Implementing the interface IViewCurrencyUseCase

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.Currencies.ViewCurrencyScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Currencies.ViewCurrencyScreen
{
        public class ViewCurrencyUseCase : IViewCurrencyUseCase
    {
            //property dependency injection
            private readonly IUnitOfWork instanceOfIUnitOfWork;

            //constructor dependency injection
            public ViewCurrencyUseCase(IUnitOfWork instanceOfIUnitOfWork)
            {
                this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
            }

            //Calling the unit of work for fetching the database

            public List<Currency> ViewCurrency(string searchKey)
            {
                var currencyList = instanceOfIUnitOfWork.ViewCurrencies(searchKey);
                return currencyList;
            }
        }
    }
