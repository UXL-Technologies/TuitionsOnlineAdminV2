//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: implementing the interface  ICreateTeacherVideoUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen
{
    
    public class CreateTeacherVideoUseCase : ICreateTeacherVideoUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateTeacherVideoUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create TeacherVideo in IunitOfwork
        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            Console.WriteLine("I have reached create teacherVideo");
            instanceOfIUnitOfWork.CreateTeacherVideo(teacherVideo);
        }
    }
}
