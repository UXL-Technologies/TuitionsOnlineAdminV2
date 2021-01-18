//Authors: SA, BM, SM
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
        void CreateGraduateCourse(GraduateCourse graduateCourse);
    }
}
