//Authors: SA, BM, SM,BA ,KK
//Date:22-Feb-2021
//Aim: defining the class for TeacherGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.CreateTeacherGraduateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.CreateTeacherGraduateCourseQualificationScreen
{
    public class CreateTeacherGraduateCourseQualificationUseCase : ICreateTeacherGraduateCourseQualificationUseCase
    {
        //// Aim: Property dependency injection of IUnitOfWork for creating the teacher graduate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim: Constructor dependency injection of IUnitOfWork for creating the teacher graduate course qualifications.
        public CreateTeacherGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        //Aim : The CreateGraduateCourseUseCase method is responsible to create the teacher graduate course qualification.
        public string CreateTeacherGraduateCourseQualification(int teacherId, int selectedGraduateCourses)
        {
            var result = diIUnitOfWork.CreateTeacherGraduateCourseQualification(teacherId, selectedGraduateCourses);
            return result;
        }
    }
}
