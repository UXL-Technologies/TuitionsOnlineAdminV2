﻿//Authors: SA, BM, SM
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
         List<PostGraduateCourse> ViewPostGraduateCourse(string searchKey);
    }
}
