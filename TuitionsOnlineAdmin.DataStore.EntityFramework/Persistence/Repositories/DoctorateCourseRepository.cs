//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for Doctorate course



using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class DoctorateCourseRepository : IDoctorateCourseRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public DoctorateCourseRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }

        //To create a single record for DoctorateCourse
        public void CreateDoctorateCourseRepository(DoctorateCourse doctorateCourse )
        {
            instanceOfDbContext.DoctorateCourse.Add(doctorateCourse);
            instanceOfDbContext.SaveChanges();
        }
    }
}
