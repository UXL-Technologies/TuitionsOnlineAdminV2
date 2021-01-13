//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Repository for Grade

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public GradeRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for Grade
        public void CreateGradeRepository(Grade grade)
        {
            instanceOfDbContext.Grade.Add(grade);
            instanceOfDbContext.SaveChanges();
        }
    }
}
