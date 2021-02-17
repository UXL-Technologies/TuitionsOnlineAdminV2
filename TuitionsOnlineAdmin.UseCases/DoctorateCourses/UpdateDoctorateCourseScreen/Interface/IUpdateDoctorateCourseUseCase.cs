//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim:  Interface to declare UpdateDoctorateCourse ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.UpdateDoctorateCourseScreen.Interface
{
   public interface IUpdateDoctorateCourseUseCase
    {
        //Declaring a method to update the DoctorateCourse
        string UpdateDoctorateCourse(DoctorateCourse doctorateCourse);
    }
}
