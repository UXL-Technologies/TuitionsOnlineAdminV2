using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface IGraduateCourseRepository
    {
        void CreateGraduateCourseRepository(GraduateCourse graduateCourse);
    }
}
