//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Class for TeacherVideoUseCase ;

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
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        public CreateTeacherVideoUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            Console.WriteLine("I have reached create teacherVideo");
            instanceOfIUnitOfWork.CreateTeacherVideo(teacherVideo);
        }
    }
}
