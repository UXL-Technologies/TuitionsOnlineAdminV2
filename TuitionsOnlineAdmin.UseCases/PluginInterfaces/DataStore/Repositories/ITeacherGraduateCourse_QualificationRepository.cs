using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ITeacherGraduateCourse_QualificationRepository
    {
        public List<TeacherGraduateCourseQualification> ViewGraduateCourseQualificationRepository(int teacherId);
    }
}
