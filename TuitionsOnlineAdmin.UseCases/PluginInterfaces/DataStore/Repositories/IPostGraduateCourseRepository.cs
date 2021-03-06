﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the pluginInterface  Repository  for PostGraduateCourse;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface IPostGraduateCourseRepository
    {
        //To hold the contract for creating the PostGraduateCourse and store it in a database
        string CreatePostGraduateRepository(PostGraduateCourse postGraduateCourse);

        //To hold the contract for viewing post graduate course 
        List<PostGraduateCourse> ViewPostGraduateCourseRepository(string searchKey);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:14-Jan-2021
        //To hold the contract for updating post graduate course 
        string UpdatePostGraduateCourseRepository(PostGraduateCourse postGraduateCourse);

    }
}
