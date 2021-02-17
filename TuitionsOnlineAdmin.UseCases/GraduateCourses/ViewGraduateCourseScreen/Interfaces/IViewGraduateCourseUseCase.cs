﻿//Authors: SA, BM, SM
//Date:13-Jan-2021
//Aim: defining the Interface for viewGraduateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.ViewGraduateCourseScreen.Interfaces
{
    
    public interface IViewGraduateCourseUseCase
    {
        //Declaring a method to view the Graduate course
        List<GraduateCourse> ViewGraduateCourse(string searchKey);
    }
}
