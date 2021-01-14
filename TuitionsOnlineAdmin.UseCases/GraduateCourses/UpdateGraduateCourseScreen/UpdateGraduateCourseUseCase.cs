//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for UpdateGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen
{
    public class UpdateGraduateCourseUseCase : IUpdateGraduateCourseUseCase

    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        public UpdateGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        public string UpdateGraduateCourse(GraduateCourse graduateCourse)
        {
            instanceOfIUnitOfWork.UpdateGraduateCourse(graduateCourse);
            return "done";
        }
    }
}
