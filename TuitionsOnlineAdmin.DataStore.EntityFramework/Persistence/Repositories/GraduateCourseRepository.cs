using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class GraduateCourseRepository : IGraduateCourseRepository
    {
       private readonly TuitionsOnlineAdminDbContext _database;


        public GraduateCourseRepository(TuitionsOnlineAdminDbContext _database)
       {
            this._database = _database;
        }
       public void CreateGraduateCourseRepository(GraduateCourse graduateCourse)
       {
           _database.GraduateCourse.Add(graduateCourse);
            _database.SaveChanges();
        }
    }
}
