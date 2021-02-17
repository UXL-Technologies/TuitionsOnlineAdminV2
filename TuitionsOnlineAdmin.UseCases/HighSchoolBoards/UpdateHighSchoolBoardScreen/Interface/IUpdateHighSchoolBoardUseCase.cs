//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for HighSchoolBoardUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.UpdateHighSchoolBoardScreen.Interface
{
   public interface IUpdateHighSchoolBoardUseCase
    {
        //Declaring a method to update the HighSchoolBoard
        string UpdateHighSchoolBoard(HighSchoolBoard highSchoolBoard);
    }
}
