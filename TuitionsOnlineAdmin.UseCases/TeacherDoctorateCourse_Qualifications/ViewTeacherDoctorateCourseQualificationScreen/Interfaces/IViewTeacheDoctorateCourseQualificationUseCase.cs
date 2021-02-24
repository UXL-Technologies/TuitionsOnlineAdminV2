//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the Interface for TeacherDoctorateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.ViewTeacherDoctorateCourseQualificationScreen.Interfaces
{
  public  interface IViewTeacheDoctorateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the teacher Doctorate course qualification. 
        public List<TeacherDoctorateCourse_Qualification> ViewTeacherDoctorateCourseQualification(int teacherId);
    }
}
