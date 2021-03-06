﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:14-Jan-2021
//Aim: defining the Interface for view DoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen.Interfaces
{
  public  interface IViewDoctorateCourseUseCase
    {
        //Declaring a method to view the DoctorateCourse
        List<DoctorateCourse> ViewDoctorateCourse(string searchKey);
    }
}
