//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for SubjectUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen
{
    //property dependency injection
    public class CreateSubjectUseCase: ICreateSubjectUseCase
    {
        //constructor dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        public CreateSubjectUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create Subject in IunitOfwork
        public void CreateSubject(Subject subject)
        {
            Console.WriteLine("I have reached create subject");
            instanceOfIUnitOfWork.CreateSubject(subject);
        }
    }
}
