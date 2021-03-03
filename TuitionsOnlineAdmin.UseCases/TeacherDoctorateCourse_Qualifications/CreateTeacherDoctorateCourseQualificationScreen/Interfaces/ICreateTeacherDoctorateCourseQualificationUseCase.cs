//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  Interface for creating  Teacher Doctorate Course Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.CreateTeacherDoctorateCourseQualificationScreen.Interfaces
{
  public interface ICreateTeacherDoctorateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for Creating teacher Doctorate Course Qualification. 
        public string CreateTeacherDoctorateCourseQualification(int teacherId, int selectedDoctorateCourses);
    }
}
