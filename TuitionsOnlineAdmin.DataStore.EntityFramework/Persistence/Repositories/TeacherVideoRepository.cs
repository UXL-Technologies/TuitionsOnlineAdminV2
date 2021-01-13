//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Repository for TeacherVideo

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherVideoRepository : ITeacherVideoRepository
    {

        private readonly TuitionsOnlineAdminDbContext _database;
        public TeacherVideoRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;
        }


        //To create a single record for TeacherVideo
        public void CreateTeacherVideoRepository(TeacherVideo teacherVideo)
        {
            _database.TeacherVideo.Add(teacherVideo);
            _database.SaveChanges();
        }



    }
}
