//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for UpdatePostGraduateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.UpdatePostGraduateCourseScreen.Interface;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.UpdatePostGraduateCourseScreen
{
    public class UpdatePostGraduateCourseUseCase : IUpdatePostGraduateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public UpdatePostGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update PostGraduateCourse in IunitOfwork
        public string UpdatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            instanceOfIUnitOfWork.UpdatePostGraduateCourse(postGraduateCourse);
            return "done";
        }
    }
}
