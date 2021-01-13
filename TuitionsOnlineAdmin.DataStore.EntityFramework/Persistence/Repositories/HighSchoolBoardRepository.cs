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
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
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
