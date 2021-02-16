//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: defining the Interface for view TeacherVideoUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.ViewTeacherVideoScreen.Interfaces
{
   public interface IViewTeacherVideoUseCase
    {
        //Declaring a method to view the TeacherVideo
        List<TeacherVideo> ViewTeacherVideo(string searchKey);

    }
}
