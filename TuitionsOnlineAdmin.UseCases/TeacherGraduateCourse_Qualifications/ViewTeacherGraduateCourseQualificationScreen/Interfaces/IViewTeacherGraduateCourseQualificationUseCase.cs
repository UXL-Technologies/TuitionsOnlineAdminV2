//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim:Interface to view the Teacher Graduate Course Qualification 

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
