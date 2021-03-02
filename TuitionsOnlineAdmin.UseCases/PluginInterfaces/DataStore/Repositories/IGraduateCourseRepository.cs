//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the pluginInterface  Repository  for GraduateCourse;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface IGraduateCourseRepository
    {
        //To hold the contract for creating the GraduateCourse and store it in a database
        string CreateGraduateCourseRepository(GraduateCourse graduateCourse);

        //To hold the contract for viewing graduate course 
        List<GraduateCourse> ViewGraduateCourseRepository(string searchKey);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:14-Jan-2021
        //To hold the contract for updating graduate course 
        string UpdateGraduateCourseRepository(GraduateCourse graduateCourse);
    }
}
