//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Class for HighSchoolBoard ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen
{
    public class CreateHighSchoolBoardUseCase : ICreateHighSchoolBoardUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;
        //constructor dependency injection
        public CreateHighSchoolBoardUseCase(IUnitOfWork instanceOfIUnitOfWork)

        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;
        }

        //Calling the method create highSchoolBoards in IunitOfwork
        public string CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {

            Console.WriteLine("I have reached create HighSchoolBoard");
           string result =  instanceOfIUnitOfWork.CreateHighSchoolBoard(highSchoolBoard);
            return result;
        }
    }
}
