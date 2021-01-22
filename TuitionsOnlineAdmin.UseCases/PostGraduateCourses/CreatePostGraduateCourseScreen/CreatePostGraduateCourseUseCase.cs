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
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreatePostGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }
        //Calling the method create PostGraduateCourses in IunitOfwork
        public string CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            Console.WriteLine("I have reached create postgraduate course");
            string result = instanceOfIUnitOfWork.CreatePostGraduateCourse (postGraduateCourse);
            return result;
        }

       

    }
}
