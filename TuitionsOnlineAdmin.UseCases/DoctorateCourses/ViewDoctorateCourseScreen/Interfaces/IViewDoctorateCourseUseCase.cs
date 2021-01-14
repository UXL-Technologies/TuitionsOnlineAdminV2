//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for UpdateDoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen.Interfaces
{
  public  interface IViewDoctorateCourseUseCase
    {
        List<DoctorateCourse> ViewDoctorateCourse(string searchKey);
    }
}
