//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for SubjectUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen
{
    
    public class CreateSubjectUseCase: ICreateSubjectUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //dependency injection
        public CreateSubjectUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create Subject in IunitOfwork
        public string CreateSubject(Subject subject)
        {
            Console.WriteLine("I have reached create subject");
          string result =   instanceOfIUnitOfWork.CreateSubject(subject);
            return result;
        }
    }
}
