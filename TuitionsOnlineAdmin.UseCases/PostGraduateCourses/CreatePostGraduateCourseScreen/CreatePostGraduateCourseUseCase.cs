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
        private readonly IUnitOfWork unitOfWork;

        public CreatePostGraduateCourseUseCase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse)
        {
            Console.WriteLine("I have reached create postgraduate course");
               unitOfWork.CreatePostGraduateCourse (postGraduateCourse);
        }

       

    }
}
