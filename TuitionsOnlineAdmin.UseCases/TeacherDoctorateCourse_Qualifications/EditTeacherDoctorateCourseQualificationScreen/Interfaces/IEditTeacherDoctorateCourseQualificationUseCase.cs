//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the Interface for TeacherDoctorateCourse_Qualification

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.EditTeacherDoctorateCourseQualificationScreen.Interfaces
{
   public interface IEditTeacherDoctorateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher Doctorate course qualification.
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_Qualification> teacherDoctorateCourseQualifications);
    }
}
