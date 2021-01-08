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
        private readonly IUnitOfWork unitOfWork;

        public CreateGraduateCourseUseCase(IUnitOfWork unitOfWork) {
            this.unitOfWork = unitOfWork;
        }
        public void CreateGraduateCourse(GraduateCourse graduateCourse)
        {
            unitOfWork.CreateGraduateCourse(graduateCourse);
        }
    }
}
