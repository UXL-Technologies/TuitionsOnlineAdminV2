//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: implementing the inteface IHighSchoolBoardRepository

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class HighSchoolBoardRepository : IHighSchoolBoardRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public HighSchoolBoardRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for HighSchoolBoard
        public void CreateHighSchoolBoardRepository(HighSchoolBoard highSchoolBoard)
        {
            instanceOfDbContext.HighSchoolBoard.Add(highSchoolBoard);
            instanceOfDbContext.SaveChanges();
        }

    }
}
