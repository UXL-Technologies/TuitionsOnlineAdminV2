//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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
    //Aim: defining the usecase for view graduate course

    public class ViewGraduateCourseUseCase : IViewGraduateCourseUseCase
    {
        //property dependency injection
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
