//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the Class for DoctorateCourseUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen
{
    public class CreateDoctorateCourseUseCase : ICreateDoctorateCourseUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        public  CreateDoctorateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        public void CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            Console.WriteLine("I have reached create doctorate course");
            instanceOfIUnitOfWork.CreateDoctorateCourse(doctorateCourse);
        }
    }
}
