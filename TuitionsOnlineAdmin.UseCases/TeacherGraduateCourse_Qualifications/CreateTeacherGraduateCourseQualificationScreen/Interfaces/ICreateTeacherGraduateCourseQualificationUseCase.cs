using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.CreateTeacherGraduateCourseQualificationScreen.Interfaces
{
   public interface ICreateTeacherGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for Creating teacher Graduate Course Qualification. 
        public void CreateTeacherGraduateCourseQualification(int teacherId, List<int> selectedGraduateCourses);
    }
}

