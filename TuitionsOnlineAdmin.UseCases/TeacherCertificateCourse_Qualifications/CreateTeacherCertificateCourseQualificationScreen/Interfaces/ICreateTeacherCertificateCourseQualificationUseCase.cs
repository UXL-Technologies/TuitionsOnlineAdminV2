//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  Interface for creating Teacher Certificate Course Qualification
using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.CreateTeacherCertificateCourseQualificationScreen.Interfaces
{
   public interface ICreateTeacherCertificateCourseQualificationUseCase
    {

        //Aim : The method is responsible to hold the contact for Creating teacher Certificate Course Qualification. 
        public string CreateTeacherCertificateCourseQualification(int teacherId, int selectedCertificateCourses);
    }
}
