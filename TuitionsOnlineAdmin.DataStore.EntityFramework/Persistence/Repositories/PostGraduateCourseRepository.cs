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
        private readonly TuitionsOnlineAdminDbContext _database;

        public PostGraduateCourseRepository(TuitionsOnlineAdminDbContext _database)
        {

            this._database = _database;

        }

        //To create a single record for PostGraduateCourse
        public void CreatePostGraduateRepository(PostGraduateCourse postGraduateCourse)
        {
            _database.PostGraduateCourse.Add(postGraduateCourse);
            _database.SaveChanges();
        }
    }
}
