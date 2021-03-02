//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the pluginInterface  Repository  for DoctorateCourse;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
  public  interface IDoctorateCourseRepository
    {
        //To hold the contract for creating the DoctorateCourse and store it in a database
        string CreateDoctorateCourseRepository(DoctorateCourse doctorateCourse);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:14-Jan-2021
        //To hold the contract for viewing Doctorate course 
        List<DoctorateCourse> ViewDoctorateCourseRepository(string searchKey);

        //To hold the contract for updating DoctorateCourse
        string UpdateDoctorateCourseRepository(DoctorateCourse doctorateCourse);




    }
}
