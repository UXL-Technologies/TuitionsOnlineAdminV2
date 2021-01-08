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
        private readonly IUnitOfWork unitOfWork;
        public  CreateDoctorateCourseUseCase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public void CreateDoctorateCourse(DoctorateCourse doctorateCourse)
        {
            Console.WriteLine("I have reached create doctorate course");
            unitOfWork.CreateDoctorateCourse(doctorateCourse);
        }
    }
}
