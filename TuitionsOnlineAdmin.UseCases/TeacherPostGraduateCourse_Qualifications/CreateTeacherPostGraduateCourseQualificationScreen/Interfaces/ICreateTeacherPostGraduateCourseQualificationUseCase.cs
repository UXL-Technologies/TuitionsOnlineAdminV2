//Authors: SA, BM, SM,BA ,KK
//Date:23-Feb-2021
//Aim: defining the Interface for TeacherPostGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.CreateTeacherPostGraduateCourseQualificationScreen.Interfaces
{
    public interface ICreateTeacherPostGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for Creating teacher PostGraduate Course Qualification. 
        public string CreateTeacherPostGraduateCourseQualification(int teacherId, int selectedPostGraduateCourses);
    }
}
