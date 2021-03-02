//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:14-Jan-2021
//Aim: Implementing the interface IViewGradeUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen
{
   public class ViewHighSchoolBoardUseCase : IViewHighSchoolBoardUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public ViewHighSchoolBoardUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the unit of work for fetching the database

        public List<HighSchoolBoard> ViewHighSchoolBoard(string searchKey)
        {
            var highSchoolBoardList = instanceOfIUnitOfWork.ViewHighSchoolBoards(searchKey);
            return highSchoolBoardList;
        }
    }
}
