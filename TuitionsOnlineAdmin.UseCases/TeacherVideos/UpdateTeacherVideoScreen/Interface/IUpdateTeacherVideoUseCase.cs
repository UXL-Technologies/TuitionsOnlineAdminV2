//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: defining the Interface for UpdateTeacherVideoUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.UpdateTeacherVideoScreen.Interface
{
   public interface IUpdateTeacherVideoUseCase
    {
        //Declaring a method to update the TeacherVideo
        string UpdateTeacherVideo(TeacherVideo teacherVideo);
    }
}
