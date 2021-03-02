//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the Interface for postGraduateCourseUsecase ;



using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen.Interface
{
    public interface ICreatePostGraduateCourseUseCase
    {
        //Declaring a method to create the PostGraduateCourse
        string CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
    }
}
