using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface ITeacherGraduateCourse_Qualification_SubjectRepository
    {
        //To View Teacher Graduate Course Qualification Subject
        public List<TeacherGraduateCourse_Qualification_SubjectWithForeignKeys> ViewTeacherGraduateCourseQualificationSubjectRepository(int teacherId, int graduateCourseId);
    }
}
