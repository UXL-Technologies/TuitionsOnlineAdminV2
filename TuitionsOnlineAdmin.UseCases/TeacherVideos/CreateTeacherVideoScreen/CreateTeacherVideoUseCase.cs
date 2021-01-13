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
        private readonly IUnitOfWork unitOfWork;

        public CreateTeacherVideoUseCase(IUnitOfWork unitOfWork)

        {
            this.unitOfWork = unitOfWork;
        }
        public void CreateTeacherVideo(TeacherVideo teacherVideo)
        {
            Console.WriteLine("I have reached create teacherVideo");
            unitOfWork.CreateTeacherVideo(teacherVideo);
        }
    }
}
