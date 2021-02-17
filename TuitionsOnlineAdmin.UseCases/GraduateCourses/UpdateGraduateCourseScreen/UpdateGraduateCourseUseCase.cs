//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for UpdateGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen
{
    public class UpdateGraduateCourseUseCase : IUpdateGraduateCourseUseCase

    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public UpdateGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update graduate Courses in IunitOfwork
        public string UpdateGraduateCourse(GraduateCourse graduateCourse)
        {
            string result = instanceOfIUnitOfWork.UpdateGraduateCourse(graduateCourse);
            return result;
                
        }
    }
}
