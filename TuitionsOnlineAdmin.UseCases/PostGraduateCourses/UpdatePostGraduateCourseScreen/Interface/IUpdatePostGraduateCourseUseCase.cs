﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:14-Jan-2021
//Aim: defining the Interface for UpdatePostGraduateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.UpdatePostGraduateCourseScreen.Interface
{
   public interface IUpdatePostGraduateCourseUseCase
    {
        //Declaring a method to update the PostGraduateCourse
        string UpdatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
    }
}
