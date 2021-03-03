//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Jan-2021
//Aim: Implementing the interface IViewUniversityUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.Universities.ViewUniversityScreen.Intefaces;

namespace TuitionsOnlineAdmin.UseCases.Universities.ViewUniversityScreen
{
   public class ViewUniversityUseCase: IViewUniversityUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewUniversityUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        List<University> IViewUniversityUseCase.ViewUniversity(string searchKey)
        {
            var universityList = instanceOfIUnitOfWork.ViewUniversities(searchKey);
            return universityList;
        }
    }
}
