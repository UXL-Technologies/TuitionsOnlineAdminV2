//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the entity for subject

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public SubjectRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }
        //To create a single record for Subject
        public void CreateSubjectRepository(Subject subject)
        {
            instanceOfDbContext.Subject.Add(subject);
            instanceOfDbContext.SaveChanges();

        }
    }
}
