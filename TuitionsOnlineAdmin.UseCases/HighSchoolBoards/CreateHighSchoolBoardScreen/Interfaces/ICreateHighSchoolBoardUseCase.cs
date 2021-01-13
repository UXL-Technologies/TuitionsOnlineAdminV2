//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Interface for HighSchoolBoard ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen.Interfaces
{
   public interface ICreateHighSchoolBoardUseCase
    {
        void CreateHighSchoolBoard(HighSchoolBoard highSchoolBoard);
    }
}
