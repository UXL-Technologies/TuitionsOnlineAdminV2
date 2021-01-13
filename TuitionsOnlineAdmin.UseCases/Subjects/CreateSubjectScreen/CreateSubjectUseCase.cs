
using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen
{
   public class CreateSubjectUseCase: ICreateSubjectUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        public CreateSubjectUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }



        public void CreateSubject(Subject subject)
        {
            Console.WriteLine("I have reached create subject");
            instanceOfIUnitOfWork.CreateSubject(subject);
        }
    }
}
