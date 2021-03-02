//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: Implementing the interface IUpdateCertificateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.CertificateCourses.UpdateCertificateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.CertificateCourses.UpdateCertificateCourseScreen
{
        public class UpdateCertificateCourseUseCase : IUpdateCertificateCourseUseCase
        {
            //property dependency injection
            private readonly IUnitOfWork instanceOfIUnitOfWork;

            //constructor dependency injection
            public UpdateCertificateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
            {
                this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

            }
            //Calling the method update certificate courses in IunitOfwork
            public string UpdateCertificateCourse(CertificateCourse certificateCourse)
            {
                instanceOfIUnitOfWork.UpdateCertificateCourse(certificateCourse);
                return "done";
            }
        }
}

