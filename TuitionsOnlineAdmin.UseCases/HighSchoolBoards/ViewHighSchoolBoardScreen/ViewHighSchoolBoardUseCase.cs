//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: Implementing the interface IViewHighSchoolBoardUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen
{
  public  class ViewHighSchoolBoardUseCase: IViewHighSchoolBoardUseCase
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
