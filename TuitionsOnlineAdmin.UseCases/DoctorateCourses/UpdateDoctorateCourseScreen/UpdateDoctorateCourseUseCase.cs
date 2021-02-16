//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: Implementing the interface IUpdateDoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.UpdateDoctorateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.UpdateDoctorateCourseScreen
{
   public class UpdateDoctorateCourseUseCase : IUpdateDoctorateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateDoctorateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update doctorate courses in IunitOfwork
        public string UpdateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            instanceOfIUnitOfWork.UpdateDoctorateCourse(doctorateCourse);
            return "done";
        }

        
    }
}
