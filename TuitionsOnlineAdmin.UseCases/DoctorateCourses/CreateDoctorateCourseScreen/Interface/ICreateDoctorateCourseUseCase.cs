//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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
       string CreateDoctorateCourse(DoctorateCourse doctorateCourse);
    }
}
