//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the Interface for TeacherCertificateCourse_Qualification


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.EditTeacherCertificateCourseQualificationScreen.Interfaces
{
   public interface IEditTeacherCertificateCourseQualificationUseCase
    {
        //Aim : The method is responsible to hold the contact for editing the teacher Certificate course qualification.
        public string EditTeacherCertificateCourseQualification(List<TeacherCertificateCourse_QualificationWithForeignKeys> teacherCertificateCourseQualifications);
    }
}
