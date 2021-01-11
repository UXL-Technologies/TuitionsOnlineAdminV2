//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for Graduate course

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

        //To create a single record for GraduateCourse
        public void CreateGraduateCourseRepository(GraduateCourse graduateCourse)
       {
           _database.GraduateCourse.Add(graduateCourse);
            _database.SaveChanges();
        }
    }
}
