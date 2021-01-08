using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class DoctorateCourseRepository : IDoctorateCourseRepository
    {
        private readonly TuitionsOnlineAdminDbContext _database;
        public DoctorateCourseRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;

        }
        public void CreateDoctorateCourseRepository(DoctorateCourse doctorateCourse )
        {
            _database.DoctorateCourse.Add(doctorateCourse);
            _database.SaveChanges();
        }
    }
}
