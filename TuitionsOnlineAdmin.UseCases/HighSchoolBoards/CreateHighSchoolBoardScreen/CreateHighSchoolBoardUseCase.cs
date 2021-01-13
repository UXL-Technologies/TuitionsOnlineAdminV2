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
        private readonly IUnitOfWork unitOfWork;

        public CreateHighSchoolBoardUseCase(IUnitOfWork unitOfWork)

        {
            this.unitOfWork = unitOfWork;
        }
        

        public void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard)
        {

            Console.WriteLine("I have reached create HighSchoolBoard");
            unitOfWork.CreateHighSchoolBoard(highSchoolBoard);
        }
    }
}
