//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Repository for HighSchoolBoard

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
   public class HighSchoolBoardRepository : IHighSchoolBoardRepository
    {
        private readonly TuitionsOnlineAdminDbContext _database;
        public HighSchoolBoardRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;
        }

        //To create a single record for HighSchoolBoard
        public void CreateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard)
        {
            _database.HighSchoolBoard.Add(highSchoolBoard);
            _database.SaveChanges();
        }

    }
}
