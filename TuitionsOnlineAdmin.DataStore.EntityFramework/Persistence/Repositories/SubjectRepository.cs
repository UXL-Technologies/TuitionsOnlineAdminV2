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
        private readonly TuitionsOnlineAdminDbContext _database;
        public SubjectRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;

        }
        //To create a single record for Subject
        public void CreateSubjectRepository(Subject subject)
        {
            _database.Subject.Add(subject);
            _database.SaveChanges();

        }
    }
}
