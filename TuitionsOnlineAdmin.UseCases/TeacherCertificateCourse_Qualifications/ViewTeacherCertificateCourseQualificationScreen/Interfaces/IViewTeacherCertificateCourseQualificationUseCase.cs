//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:24-Feb-2021
//Aim:  Interface for viewing TeacherCertificateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.ViewTeacherCertificateCourseQualificationScreen.Interfaces
{
   public  interface IViewTeacherCertificateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for viewing the teacher Certificate course qualification. 
        public List<TeacherCertificateCourse_QualificationWithForeignKeys> ViewTeacherCertificateCourseQualification(int teacherId);
    }
}
