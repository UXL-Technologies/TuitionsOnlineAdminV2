//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the pluginInterface  Repository  for HighSchoolBoard;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public  interface IHighSchoolBoardRepository
    {
        //To hold the contract for creating the HighSchoolBoard and store it in a database
        void CreateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard);
    }
}
