//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Jan-2021
//Aim: defining the pluginInterface  Repository  for University;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface IUniversityRepository
    {
        //To hold the contract for creating the University and store it in a database
        string CreateUniversityRepository(University university);

        //To hold the contract for updating University
        string UpdateUniversityRepository(University university);
       
        //To hold the contract for viewing University
        List<University> ViewUniversityRepository(string searchKey);

    }
}
