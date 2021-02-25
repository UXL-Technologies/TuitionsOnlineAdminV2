//Authors: SA, BM, SM,KK,BA
//Date:25-Jan-2021
//Aim: defining the Class for UniversityUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Universities.CreateUniversityScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.Universities.CreateUniversityScreen
{
   public class CreateUniversityUseCase: ICreateUniversityUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //dependency injection
        public CreateUniversityUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create Subject in IunitOfwork
        public string CreateUniversity(University university)
        {
            Console.WriteLine("I have reached create university");
            string result = instanceOfIUnitOfWork.CreateUniversity(university);
            return result;
        }
    }
}
