//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the pluginInterface  Repository  for TeacherVideo;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface ITeacherVideoRepository
    {
        void CreateTeacherVideoRepository(TeacherVideo teacherVideo);
    }
}
