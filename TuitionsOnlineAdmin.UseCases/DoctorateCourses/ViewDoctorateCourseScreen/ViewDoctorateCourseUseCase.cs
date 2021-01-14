//Authors: SA, BM, SM
//Date:14-Jan-2021
//Aim: defining the usecase for view doctorate course

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen
{
    public class ViewDoctorateCourseUseCase : IViewDoctorateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewDoctorateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the method view doctorate courses in IunitOfwork

        public List<DoctorateCourse> ViewDoctorateCourse(string searchKey)
        {
            var doctorateCourseList = instanceOfIUnitOfWork.ViewDoctorateCourses(searchKey);
            return doctorateCourseList;
        }

    }
}
