//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the class for TeacherCertificatecourse_Qualification


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.ViewTeacherCertificateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.ViewTeacherCertificateCourseQualificationScreen
{
   public class ViewTeacherCertificateCourseQualificationUseCase : IViewTeacherCertificateCourseQualificationUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher Certificate course qualifications.
        public ViewTeacherCertificateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        // Aim : The ViewCertificateCourseUseCase method is responsible to get the teacher Certificate course qualification record if exists else provide an empty container of teacher Certificate course qualification.
        public List<TeacherCertificateCourse_Qualification> ViewTeacherCertificateCourseQualification(int teacherId)
        {
            var teacherCertificateCourseQualificationList = diIUnitOfWork.ViewTeacherCertificateCourseQualification(teacherId);
            Console.WriteLine(teacherCertificateCourseQualificationList);
            return teacherCertificateCourseQualificationList;
        }

       

       
    }
}
