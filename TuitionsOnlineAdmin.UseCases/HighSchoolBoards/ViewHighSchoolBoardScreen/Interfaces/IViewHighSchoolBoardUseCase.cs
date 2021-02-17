//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for view HighSchoolBoardUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen.Interfaces
{
  public  interface IViewHighSchoolBoardUseCase
    {
        //Declaring a method to view the HighSchoolBoard
        List<HighSchoolBoard> ViewHighSchoolBoard(string searchKey);
    }
}
