//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  class to implement create TeacherDoctorateCourse_Qualification

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.CreateTeacherDoctorateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.CreateTeacherDoctorateCourseQualificationScreen
{
   public class CreateTeacherDoctorateCourseQualificationUseCase : ICreateTeacherDoctorateCourseQualificationUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher 
        
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim: Constructor dependency injection of IUnitOfWork for creating the teacher Doctorate course qualifications.
        public CreateTeacherDoctorateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        //Aim : The CreateDoctorateCourseUseCase method is responsible to create the teacher Doctorate course qualification.
        public string CreateTeacherDoctorateCourseQualification(int teacherId, int selectedDoctorateCourses)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedDoctorateCourses);
            var result = diIUnitOfWork.CreateTeacherDoctorateCourseQualification(teacherId, selectedDoctorateCourses);
            return result;
        }
    }
}
