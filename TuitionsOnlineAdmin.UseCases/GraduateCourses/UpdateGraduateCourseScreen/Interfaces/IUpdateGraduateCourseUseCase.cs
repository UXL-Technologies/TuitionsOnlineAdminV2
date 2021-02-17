using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen.Interfaces
{
   public interface IUpdateGraduateCourseUseCase
    {
        string UpdateGraduateCourse(GraduateCourse graduatCourse);
    }
}
