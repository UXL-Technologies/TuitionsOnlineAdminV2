//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:22-Feb-2021
//Aim: class to view the Teacher Graduate Course Qualification 

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

        // Aim : The View Graduate Course UseCase method is responsible to get the teacher graduate course qualification record if exists else provide an empty container of teacher graduate course qualification.
        public List<TeacherGraduateCourse_QualificationWithForeignKeys> ViewTeacherGraduateCourseQualification(int teacherId)
        {
            var teacherGraduateCourseQualificationList = diIUnitOfWork.ViewTeacherGraduateCourseQualification(teacherId);
            Console.WriteLine(teacherGraduateCourseQualificationList);
            return teacherGraduateCourseQualificationList;

        }
    }
}
