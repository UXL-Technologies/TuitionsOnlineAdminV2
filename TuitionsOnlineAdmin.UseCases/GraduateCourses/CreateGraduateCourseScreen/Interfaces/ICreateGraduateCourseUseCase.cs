﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the Interface for GraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen.Interfaces
{
   public interface ICreateGraduateCourseUseCase
    {
        //Declaring a method to create the graduate Course
        string CreateGraduateCourse(GraduateCourse graduateCourse);
    }
}
