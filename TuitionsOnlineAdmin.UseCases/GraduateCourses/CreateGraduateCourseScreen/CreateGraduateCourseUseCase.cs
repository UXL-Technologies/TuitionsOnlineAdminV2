//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for GraduateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen
{
    public class CreateGraduateCourseUseCase : ICreateGraduateCourseUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        public CreateGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork) {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIUnitOfWork.CreateGraduateCourse(graduateCourse);
        }
    }
}
