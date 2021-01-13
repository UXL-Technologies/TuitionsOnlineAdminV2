﻿//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the pluginInterface  Repository  for TeacherBasicInformation;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
  public  interface ITeacherBasicInformationRepository
    {
        //To hold the contract for creating the TeacherBasicInformation and store it in a database
        void CreateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation);
    }
}
