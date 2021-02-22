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

        private readonly IUnitOfWork diIUnitOfWork;

        public ViewTeacherGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        public List<TeacherGraduateCourse_Qualification> ViewTeacherGraduateCourseQualification(int teacherId)
        {
            var teacherGraduateCourseQualificationList = diIUnitOfWork.ViewTeacherGraduateCourseQualification(teacherId);
            Console.WriteLine(teacherGraduateCourseQualificationList);
            return teacherGraduateCourseQualificationList;

        }
    }
}
