//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  Interface for editing Teacher Doctorate Course Qualification

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.EditTeacherDoctorateCourseQualificationScreen.Interfaces
{
   public interface IEditTeacherDoctorateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher Doctorate course qualification.
        public string EditTeacherDoctorateCourseQualification(List<TeacherDoctorateCourse_QualificationWithForeignKeys> teacherDoctorateCourseQualifications);
    }
}
