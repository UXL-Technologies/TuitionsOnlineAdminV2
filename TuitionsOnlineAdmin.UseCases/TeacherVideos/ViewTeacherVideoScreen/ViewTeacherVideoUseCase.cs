//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: Implementing the interface IviewTeacherVideoUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.ViewTeacherVideoScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.ViewTeacherVideoScreen
{
   public class ViewTeacherVideoUseCase : IViewTeacherVideoUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewTeacherVideoUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<TeacherVideo> ViewTeacherVideo(string searchKey)
        {
            var teacherVideoList = instanceOfIUnitOfWork.ViewTeacherVideos(searchKey);
            return teacherVideoList;
        }
    }
}
