using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.CreateTeacherCertificateCourseQualificationScreen.Interfaces
{
   public interface ICreateTeacherCertificateCourseQualificationUseCase
    {

        //Aim : The method is responsible to hold the contact for Creating teacher Certificate Course Qualification. 
        public string CreateTeacherCertificateCourseQualification(int teacherId, int selectedCertificateCourses);
    }
}
