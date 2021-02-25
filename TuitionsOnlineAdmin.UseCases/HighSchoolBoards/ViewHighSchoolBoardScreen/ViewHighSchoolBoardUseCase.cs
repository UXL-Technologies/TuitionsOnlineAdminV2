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
