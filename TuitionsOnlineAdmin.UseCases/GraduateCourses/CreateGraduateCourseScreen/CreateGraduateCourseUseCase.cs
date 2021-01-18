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
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork) {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create graduate Courses in IunitOfwork
        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIUnitOfWork.CreateGraduateCourse(graduateCourse);
        }
    }
}
