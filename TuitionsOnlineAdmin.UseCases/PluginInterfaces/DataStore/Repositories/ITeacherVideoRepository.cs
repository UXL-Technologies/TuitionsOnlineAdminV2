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
        //To hold the contract for creating the TeacherVideo and store it in a database
        string CreateTeacherVideoRepository(TeacherVideo teacherVideo);
        //Authors: SA, BM, SM
        //Date:15-Jan-2021
        //To hold the contract for viewing TeacherVideo
        List<TeacherVideo> ViewTeacherVideoRepository(string searchKey);
        //To hold the contract for updating TeacherVideo
        string UpdateTeacherVideoRepository(TeacherVideo teacherVideo);
    }
}
