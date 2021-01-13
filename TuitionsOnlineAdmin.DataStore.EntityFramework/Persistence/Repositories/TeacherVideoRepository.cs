//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Repository for TeacherVideo

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherVideoRepository : ITeacherVideoRepository
    {

        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public TeacherVideoRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }


        //To create a single record for TeacherVideo
        public void CreateTeacherVideoRepository(TeacherVideo teacherVideo)
        {
            instanceOfDbContext.TeacherVideo.Add(teacherVideo);
            instanceOfDbContext.SaveChanges();
        }



    }
}
