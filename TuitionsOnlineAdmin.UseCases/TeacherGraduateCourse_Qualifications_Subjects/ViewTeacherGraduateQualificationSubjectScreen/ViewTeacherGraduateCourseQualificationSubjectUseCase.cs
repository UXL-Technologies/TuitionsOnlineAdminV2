using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications_Subjects.ViewTeacherGraduateQualificationSubjectScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications_Subjects.ViewTeacherGraduateQualificationSubjectScreen
{
    public class ViewTeacherGraduateCourseQualificationSubjectUseCase : IViewTeacherGraduateCourseQualificationSubjectUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork diIUnitOfWork;
        //Aim: Constructor dependency injection of IUnitOfWork for viewing the teacher graduate course qualifications.
        public ViewTeacherGraduateCourseQualificationSubjectUseCase(IUnitOfWork diIUnitOfWork)
        {
            this.diIUnitOfWork = diIUnitOfWork;
        }
        public List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> ViewTeacherGraduateCourseQualificationSubject(int teacherId, int graduateCourseId)
        {
            var teacherGraduateCourseQualificationSubjectList = diIUnitOfWork.ViewTeacherGraduateCourseQualificationSubject(teacherId, graduateCourseId);
            
            return teacherGraduateCourseQualificationSubjectList;
        }
    }
}
