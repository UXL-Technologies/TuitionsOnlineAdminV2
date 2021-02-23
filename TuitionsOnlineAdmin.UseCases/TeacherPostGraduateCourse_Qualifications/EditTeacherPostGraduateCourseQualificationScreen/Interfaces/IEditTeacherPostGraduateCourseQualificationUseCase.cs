//Authors: SA, BM, SM,BA ,KK
//Date:23-Feb-2021
//Aim: defining the Interface for TeacherPostGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.EditTeacherPostGraduateCourseQualificationScreen.Interfaces
{
    public interface IEditTeacherPostGraduateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher Postgraduate course qualification.
        public string EditTeacherPostGraduateCourseQualification(List<TeacherPostGraduateCourse_Qualification> teacherPostGraduateCourseQualifications);
    }
}
