//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:23-Feb-2021
//Aim:Interface for viewing Teacher PostGraduate Course Qualification 

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
        public List<TeacherPostGraduateCourse_QualificationWithForeignKeys> ViewTeacherPostGraduateCourseQualification(int teacherId);

    }
}
