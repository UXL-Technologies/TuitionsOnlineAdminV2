//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for UpdatePostGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.ViewPostGraduateCourseScreen.Interfaces
{
   public interface IViewPostGraduateCourseUseCase
    {
        //Declaring a method to view the PostGraduateCourse
        List<PostGraduateCourse> ViewPostGraduateCourse(string searchKey);
    }
}
