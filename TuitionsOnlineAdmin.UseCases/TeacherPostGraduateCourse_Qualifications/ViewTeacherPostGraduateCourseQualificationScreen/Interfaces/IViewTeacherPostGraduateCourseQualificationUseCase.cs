//Authors: SA, BM, SM,BA ,KK
//Date:23-Feb-2021
//Aim: defining the Interface for TeacherPostGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.ViewTeacherPostGraduateCourseQualificationScreen.Interfaces
{
    public interface IViewTeacherPostGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the teacher Postgraduate course qualification. 
        public List<TeacherPostGraduateCourse_Qualification> ViewTeacherPostGraduateCourseQualification(int teacherId);

    }
}
