//Authors: SA, BM, SM,BA ,KK
//Date:24-Feb-2021
//Aim: defining the class for TeacherDoctoratecourse_Qualification

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.ViewTeacherDoctorateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.ViewTeacherDoctorateCourseQualificationScreen
{
   public  class ViewTeacherDoctorateCourseQualificationUseCase : IViewTeacherDoctorateCourseQualificationUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher Doctorate course qualifications.
        public ViewTeacherDoctorateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        // Aim : The ViewDoctorateCourseUseCase method is responsible to get the teacher Doctorate course qualification record if exists else provide an empty container of teacher Doctorate course qualification.

        public List<TeacherDoctorateCourse_QualificationWithForeignKeys> ViewTeacherDoctorateCourseQualification(int teacherId)
        {
            var teacherDoctorateCourseQualificationList = diIUnitOfWork.ViewTeacherDoctorateCourseQualification(teacherId);
            Console.WriteLine(teacherDoctorateCourseQualificationList);
            return teacherDoctorateCourseQualificationList;
        }
    }
}
