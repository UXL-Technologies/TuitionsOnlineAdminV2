//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Repository for TeacherBasicInformation

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherBasicInformationRepository : ITeacherBasicInformationRepository
    {
        private readonly TuitionsOnlineAdminDbContext _database;

        public TeacherBasicInformationRepository(TuitionsOnlineAdminDbContext _database)
        {

            this._database = _database;
        }

        //To create a single record for TeacherBasicInformation

        public void CreateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation)
        {
            _database.TeacherBasicInformation.Add(teacherBasicInformation);
            _database.SaveChanges();
        }
    }
}
