﻿//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the Interface for UpdateGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen.Interface
{
   public interface IUpdateGraduateCourseUseCase
    {
        //Declaring a method to update the graduateCourse
        string UpdateGraduateCourse(GraduateCourse graduateCourse);
    }
}
