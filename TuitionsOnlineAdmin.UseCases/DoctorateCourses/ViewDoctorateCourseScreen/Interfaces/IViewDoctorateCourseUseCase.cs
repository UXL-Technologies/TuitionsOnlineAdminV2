//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for view DoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen.Interfaces
{
  public  interface IViewDoctorateCourseUseCase
    {
        //Declaring a method to view the DoctorateCourse
        List<DoctorateCourse> ViewDoctorateCourse(string searchKey);
    }
}
