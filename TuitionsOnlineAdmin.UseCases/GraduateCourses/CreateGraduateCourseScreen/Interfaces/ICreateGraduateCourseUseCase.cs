using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen.Interfaces
{
   public interface ICreateGraduateCourseUseCase
    {
        void CreateGraduateCourse(GraduateCourse graduateCourse);
    }
}
