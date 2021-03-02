//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: Implementing the interface IUpdateSubjectUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Subjects.UpdateSubjectScreen.Interface;

namespace TuitionsOnlineAdmin.UseCases.Subjects.UpdateSubjectScreen
{
  public  class UpdateSubjectUseCase: IUpdateSubjectUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateSubjectUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update Subjects in IunitOfwork
        public string UpdateSubject(Subject subject)
        {
            instanceOfIUnitOfWork.UpdateSubject(subject);
            return "done";
        }
    }
}
