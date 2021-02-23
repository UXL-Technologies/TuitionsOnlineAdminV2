//Authors: SA, BM, SM,BA ,KK
//Date:23-Feb-2021
//Aim: defining the class for TeacherPostGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.CreateTeacherPostGraduateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.CreateTeacherPostGraduateCourseQualificationScreen
{
    public class CreateTeacherPostGraduateCourseQualificationUseCase : ICreateTeacherPostGraduateCourseQualificationUseCase
    {

        // Aim: Property dependency injection of IUnitOfWork for creating the teacher Postgraduate course qualifications.
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim: Constructor dependency injection of IUnitOfWork for creating the teacher Postgraduate course qualifications.
        public CreateTeacherPostGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)

            {
                this.diIUnitOfWork = diIUnitOfWork;
            }

        //Aim : The CreatePostGraduateCourseUseCase method is responsible to create the teacher Postgraduate course qualification.
        public string CreateTeacherPostGraduateCourseQualification(int teacherId, int selectedPostGraduateCourses)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedPostGraduateCourses);
            var result = diIUnitOfWork.CreateTeacherPostGraduateCourseQualification(teacherId, selectedPostGraduateCourses);
            return result;
        }
    }
}
