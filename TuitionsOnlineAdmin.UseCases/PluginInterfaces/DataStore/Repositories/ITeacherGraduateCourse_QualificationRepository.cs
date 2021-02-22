using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ITeacherGraduateCourse_QualificationRepository
    {
        public List<TeacherGraduateCourse_Qualification> ViewGraduateCourseQualificationRepository(int teacherId);
    }
}
