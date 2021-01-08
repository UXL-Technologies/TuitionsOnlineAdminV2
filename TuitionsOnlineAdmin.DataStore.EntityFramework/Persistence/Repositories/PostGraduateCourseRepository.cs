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


        public void CreatePostGraduateRepository(PostGraduateCourse postGraduateCourse)
        {
            _database.PostGraduateCourse.Add(postGraduateCourse);
            _database.SaveChanges();
        }
    }
}
