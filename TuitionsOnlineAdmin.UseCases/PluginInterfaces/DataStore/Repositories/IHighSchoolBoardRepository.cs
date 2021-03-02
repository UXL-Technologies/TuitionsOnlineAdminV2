//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:12-Jan-2021
//Aim: defining the pluginInterface  Repository  for HighSchoolBoard;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface IHighSchoolBoardRepository
    {
        //To hold the contract for creating the HighSchoolBoard and store it in a database
        string CreateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:18-Jan-2021
        //To hold the contract for viewing HighSchoolBoard
        List<HighSchoolBoard> ViewHighSchoolBoardRepository(string searchKey);
        //To hold the contract for updating HighSchoolBoard
        string UpdateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard);
    }
}
