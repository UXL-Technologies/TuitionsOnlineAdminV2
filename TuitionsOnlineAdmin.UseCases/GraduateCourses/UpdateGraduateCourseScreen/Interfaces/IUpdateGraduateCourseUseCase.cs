using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen.Interfaces
{
   public interface IUpdateGraduateCourseUseCase
    {
        string UpdateGraduateCourse(GraduateCourse graduatCourse);
    }
}
