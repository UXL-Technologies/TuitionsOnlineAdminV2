using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.UpdateHighSchoolBoardScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.UpdateHighSchoolBoardScreen
{
   public class UpdateHighSchoolBoardUseCase : IUpdateHighSchoolBoardUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateHighSchoolBoardUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update HighSchoolBoard in IunitOfwork

        public string UpdateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {
            instanceOfIUnitOfWork.UpdateHighSchoolBoard(highSchoolBoard);
            return "done";
        }
    }
}
