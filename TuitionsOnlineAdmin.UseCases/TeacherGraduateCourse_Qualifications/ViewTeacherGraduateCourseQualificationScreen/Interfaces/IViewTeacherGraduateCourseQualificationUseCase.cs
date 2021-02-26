//Authors: SA, BM, SM,BA ,KK
//Date:22-Feb-2021
//Aim: defining the Interface for TeacherGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.ViewTeacherGraduateCourseQualificationScreen.Interfaces
{
  public  interface IViewTeacherGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the teacher graduate course qualification. 
        public List<TeacherGraduateCourse_QualificationWithForeignKeys> ViewTeacherGraduateCourseQualification(int teacherId);
      
    }
}
