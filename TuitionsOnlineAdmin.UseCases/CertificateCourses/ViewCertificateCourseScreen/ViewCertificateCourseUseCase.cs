//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: defining the Interface for viewGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.CertificateCourses.ViewCertificateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.CertificateCourses.ViewCertificateCourseScreen
{
    
    public class ViewCertificateCourseUseCase: IViewCertificateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //dependency injection
        public ViewCertificateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<CertificateCourse> ViewCertificateCourse(string searchKey)
        {
            var certificateCourseList = instanceOfIUnitOfWork.ViewCertificateCourses(searchKey);
            return certificateCourseList;
        }
    }
}
