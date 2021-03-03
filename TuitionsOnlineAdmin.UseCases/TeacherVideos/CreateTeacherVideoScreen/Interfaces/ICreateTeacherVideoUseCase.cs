//Authors: Shravan A, Bhavya MU, Sneha M, Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: defining the Interface for TeacherVideoUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen.Interfaces
{
    public interface ICreateTeacherVideoUseCase
    {
        //Declaring a method to create the TeacherVideo
        string CreateTeacherVideo(TeacherVideo teacherVideo);
    }
}
