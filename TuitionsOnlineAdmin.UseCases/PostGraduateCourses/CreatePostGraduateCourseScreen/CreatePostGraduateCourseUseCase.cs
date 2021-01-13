//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for PostGraduateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen.Interface;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen
{
   public  class CreatePostGraduateCourseUseCase : ICreatePostGraduateCourseUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        public CreatePostGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        public void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            Console.WriteLine("I have reached create postgraduate course");
            instanceOfIUnitOfWork.CreatePostGraduateCourse (postGraduateCourse);
        }

       

    }
}
