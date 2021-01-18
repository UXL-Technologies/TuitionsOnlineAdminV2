//Authors: SA, BM, SM
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
        void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
    }
}
