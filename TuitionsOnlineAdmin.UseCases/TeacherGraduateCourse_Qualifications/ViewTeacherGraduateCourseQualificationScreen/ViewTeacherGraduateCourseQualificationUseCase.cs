//Authors: SA, BM, SM,BA ,KK
//Date:22-Feb-2021
//Aim: defining the class for TeacherGraduateCourse_Qualification 

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.ViewTeacherGraduateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourseQualification.ViewTeacherGraduateCourseQualificationScreen
{
    public class ViewTeacherGraduateCourseQualificationUseCase : IViewTeacherGraduateCourseQualificationUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher graduate course qualifications.
        public ViewTeacherGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        // Aim : The ViewGraduateCourseUseCase method is responsible to get the teacher graduate course qualification record if exists else provide an empty container of teacher graduate course qualification.
        public List<TeacherGraduateCourse_QualificationWithForeignKey> ViewTeacherGraduateCourseQualification(int teacherId)
        {
            var teacherGraduateCourseQualificationList = diIUnitOfWork.ViewTeacherGraduateCourseQualification(teacherId);
            Console.WriteLine(teacherGraduateCourseQualificationList);
            return teacherGraduateCourseQualificationList;

        }
    }
}
