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
        private readonly IUnitOfWork unitOfWork;

        public  CreateCertificateCourseUseCase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void CreateCertificateCourse(CertificateCourse certificateCourse)
        {
            Console.WriteLine("I have reached CreateCertificateCourse ");
            unitOfWork.CreateCertificateCourse(certificateCourse);
        }
    }
}
