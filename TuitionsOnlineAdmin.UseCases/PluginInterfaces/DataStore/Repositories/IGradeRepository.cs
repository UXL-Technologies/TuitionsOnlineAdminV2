//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the pluginInterface  Repository  for Grade;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface IGradeRepository
    {
        //To hold the contract for creating the Grade and store it in a database
        string CreateGradeRepository(Grade grade);

        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To hold the contract for viewing Grade
        List<Grade> ViewGradeRepository(string searchKey);
        //To hold the contract for updating Grade
        string UpdateGradeRepository(Grade grade);

    }
}
