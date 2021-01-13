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
        private readonly TuitionsOnlineAdminDbContext _database;
        public GradeRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;
        }

        //To create a single record for Grade
        public void CreateGradeRepository(Grade grade)
        {
            _database.Grade.Add(grade);
            _database.SaveChanges();
        }
    }
}
