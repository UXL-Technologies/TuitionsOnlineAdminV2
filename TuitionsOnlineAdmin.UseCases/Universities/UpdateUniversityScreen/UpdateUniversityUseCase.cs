//Authors: Shravan A, Bhavya MU, Sneha M, Karan Kumar , Bhargavi S Adiga
//Date:25-Jan-2021
//Aim: Implementing the interface IUpdateUniversityUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Universities.UpdateUniversityScreen.Interface;

namespace TuitionsOnlineAdmin.UseCases.Universities.UpdateUniversityScreen
{
  public  class UpdateUniversityUseCase: IUpdateUniversityUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateUniversityUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update University in IunitOfwork

        public string UpdateUniversity(University university)
        {
            instanceOfIUnitOfWork.UpdateUniversity(university);
            return "done";
        }
    }
}
