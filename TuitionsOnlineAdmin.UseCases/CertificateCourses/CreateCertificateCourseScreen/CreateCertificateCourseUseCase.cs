//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for CertifiacteCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen
{
    
    public class CreateCertificateCourseUseCase : ICreateCertificateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateCertificateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create certificate courses in IunitOfwork
        public string CreateCertificateCourse(CertificateCourse certificateCourse)
        {
            Console.WriteLine("I have reached CreateCertificateCourse ");
            string result= instanceOfIUnitOfWork.CreateCertificateCourse(certificateCourse);
            return result;
        }
    }
}
