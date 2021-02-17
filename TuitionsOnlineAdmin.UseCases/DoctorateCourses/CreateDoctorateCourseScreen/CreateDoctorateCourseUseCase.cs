//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for DoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen
{
    //property dependency injection
    public class CreateDoctorateCourseUseCase : ICreateDoctorateCourseUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public CreateDoctorateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the method create doctorate courses in IunitOfwork
        public string CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            Console.WriteLine("I have reached create doctorate course");
           string result =  instanceOfIUnitOfWork.CreateDoctorateCourse(doctorateCourse);
            return result;
           
        }
    }
}
