using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.ViewGraduateCourseScreen.Interfaces
{
    
    public interface IViewGraduateCourseUseCase
    {
        List<GraduateCourse> ViewGraduateCourse(string searchKey);
    }
}
