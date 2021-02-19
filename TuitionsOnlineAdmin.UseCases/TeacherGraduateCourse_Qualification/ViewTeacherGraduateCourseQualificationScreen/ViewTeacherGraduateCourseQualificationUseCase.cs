using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualification.ViewTeacherGraduateCourseQualificationScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourseQualification.ViewTeacherGraduateCourseQualificationScreen
{
    public class ViewTeacherGraduateCourseQualificationUseCase : IViewTeacherGraduateCourseQualificationUseCase
    {
        private readonly IUnitOfWork diIUnitOfWork;

        public ViewTeacherGraduateCourseQualificationUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        public List<TeacherGraduateCourseQualification> ViewTeacherGraduateCourseQualification(int teacherId)
        {
            var teacherGraduateCourseQualificationList = diIUnitOfWork.ViewTeacherGraduateCourseQualification(teacherId);
            return teacherGraduateCourseQualificationList;
        }
    }
}
