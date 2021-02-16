//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: Implementing the interface IUpdateTeacherVideoUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.UpdateTeacherVideoScreen.Interface;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.UpdateTeacherVideoScreen
{
   public class UpdateTeacherVideoUseCase : IUpdateTeacherVideoUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateTeacherVideoUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update TeacherVideos in IunitOfwork
        public string UpdateTeacherVideo(TeacherVideo teacherVideo)
        {
            instanceOfIUnitOfWork.UpdateTeacherVideo(teacherVideo);
            return "done";
        }
    }
}
