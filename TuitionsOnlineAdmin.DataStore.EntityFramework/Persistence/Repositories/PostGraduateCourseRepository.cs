//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for postGraduate course



using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class PostGraduateCourseRepository : IPostGraduateCourseRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;

        public PostGraduateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {

            this.instanceOfDbContext = instanceOfDbContext;

        }

        //To create a single record for PostGraduateCourse
        public void CreatePostGraduateRepository(PostGraduateCourse postGraduateCourse)
        {
            instanceOfDbContext.PostGraduateCourse.Add(postGraduateCourse);
            instanceOfDbContext.SaveChanges();
        }
    }
}
