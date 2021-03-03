//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  class to implement create TeacherCertificateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.CreateTeacherCertificateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.CreateTeacherCertificateCourseQualificationScreen
{
   public  class CreateTeacherCertificateCourseQualificationUseCase: ICreateTeacherCertificateCourseQualificationUseCase

    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher 
        
        private readonly IUnitOfWork diIUnitOfWork;

        // Aim: Constructor dependency injection of IUnitOfWork for creating the teacher Doctorate course qualifications.
        public CreateTeacherCertificateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        //Aim : The CreateCertificateCourseUseCase method is responsible to create the teacher Certificate course qualification.
        public string CreateTeacherCertificateCourseQualification(int teacherId, int selectedCertificateCourses)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedCertificateCourses);
            var result = diIUnitOfWork.CreateTeacherCertificateCourseQualification(teacherId, selectedCertificateCourses);
            return result;
        }
    }
}
