//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  Interface for viewing Teacher Doctorate Course Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.ViewTeacherDoctorateCourseQualificationScreen.Interfaces
{
    public interface IViewTeacherDoctorateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the teacher Doctorate course qualification. 
        public List<TeacherDoctorateCourse_QualificationWithForeignKeys> ViewTeacherDoctorateCourseQualification(int teacherId);
    }
}
