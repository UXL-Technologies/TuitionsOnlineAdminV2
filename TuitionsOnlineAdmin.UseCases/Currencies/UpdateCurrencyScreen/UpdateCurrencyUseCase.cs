﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:18-Jan-2021
//Aim: Implementing the interface IUpdateCurrencyUseCase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.Currencies.UpdateCurrencyScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Currencies.UpdateCurrencyScreen
{
   public class UpdateCurrencyUseCase : IUpdateCurrencyUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateCurrencyUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update Currency in IunitOfwork
        public string UpdateCurrency(Currency currency)
        {
            instanceOfIUnitOfWork.UpdateCurrency(currency);
            return "done";
        }

     
    }
}
