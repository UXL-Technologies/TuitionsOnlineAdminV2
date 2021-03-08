using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications_Subjects.ViewTeacherGraduateQualificationSubjectScreen.Interfaces
{
   public interface IViewTeacherGraduateCourseQualificationSubjectUseCase
    {
        public List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> ViewTeacherGraduateCourseQualificationSubject(int teacherId, int graduateCourseId);
    }
}
