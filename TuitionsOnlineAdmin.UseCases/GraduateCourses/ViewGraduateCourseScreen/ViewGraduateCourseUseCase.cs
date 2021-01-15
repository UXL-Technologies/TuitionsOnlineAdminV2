//Authors: SA, BM, SM
//Date:13-Jan-2021
//Aim: defining the Interface for viewGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.ViewGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.GraduateCourses.ViewGraduateCourseScreen
{
    //Authors: SA, BM, SM
    //Date:12-Jan-2021
    //Aim: defining the usecase for view graduate course


    public class ViewGraduateCourseUseCase : IViewGraduateCourseUseCase
    {
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //dependency injection
        public ViewGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<GraduateCourse> ViewGraduateCourse(string searchKey)
        {
            var graduateCourseList = instanceOfIUnitOfWork.ViewGraduateCourses(searchKey);
            return graduateCourseList;
        }
    }
}
