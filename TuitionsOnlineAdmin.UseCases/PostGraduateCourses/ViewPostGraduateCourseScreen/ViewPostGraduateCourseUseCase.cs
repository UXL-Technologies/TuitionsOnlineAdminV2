//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:14-Jan-2021
//Aim: defining the Interface for UpdatePostGraduateCourseUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.ViewPostGraduateCourseScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.ViewPostGraduateCourseScreen
{
      //Aim: defining the usecase for view post graduate course

    public class ViewPostGraduateCourseUseCase : IViewPostGraduateCourseUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //dependency injection
        public ViewPostGraduateCourseUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database
        public List<PostGraduateCourse> ViewPostGraduateCourse(string searchKey)
        {
            var postGraduateCourseList = instanceOfIUnitOfWork.ViewPostGraduateCourses(searchKey);
            return postGraduateCourseList;
        }

        
    }
}
