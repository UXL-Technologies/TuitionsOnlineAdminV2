//Authors: SA, BM, SM
//Date:13-Jan-2021
//Aim: defining the Interface for viewGraduateCourseUsecase ;

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
