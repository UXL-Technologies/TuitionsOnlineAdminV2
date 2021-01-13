
using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen
{
   public class CreateSubjectUseCase
    {
        private readonly IUnitOfWork unitOfWork;
        public CreateSubjectUseCase(IUnitOfWork unitOfWork)

        {
            this.unitOfWork = unitOfWork;
        }



        public void CreateSubject(Subject subject)
        {
            Console.WriteLine("I have reached create subject");
            unitOfWork.CreateSubject(subject);
        }
    }
}
