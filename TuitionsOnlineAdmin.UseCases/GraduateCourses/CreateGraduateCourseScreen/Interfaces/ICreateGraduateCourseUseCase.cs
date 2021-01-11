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
        void CreateGraduateCourse(GraduateCourse graduateCourse);
    }
}
