﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the pluginInterface  Repository  for Subject;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface ISubjectRepository
    {

        //To hold the contract for creating the Subject and store it in a database
        string CreateSubjectRepository(Subject subject);

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        //Date:15-Jan-2021
        //To hold the contract for viewing Subject
        List<Subject> ViewSubjectRepository(string searchKey);

        //To hold the contract for updating Subject
        string UpdateSubjectRepository(Subject subject);
    }
}
