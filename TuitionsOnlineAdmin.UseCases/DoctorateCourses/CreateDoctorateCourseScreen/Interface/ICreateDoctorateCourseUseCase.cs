//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Interface for DoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen.Interface
{
   public interface ICreateDoctorateCourseUseCase
    {
        //Declaring a method to create the DoctorateCourse
        void CreateDoctorateCourse(DoctorateCourse doctorateCourse);
    }
}
