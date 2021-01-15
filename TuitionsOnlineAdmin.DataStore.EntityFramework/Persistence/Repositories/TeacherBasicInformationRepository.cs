//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: implementing the inteface ITeacherBasicInformationRepository

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherBasicInformationRepository : ITeacherBasicInformationRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public TeacherBasicInformationRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {

            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for TeacherBasicInformation

        public void CreateTeacherBasicInformationRepository(TeacherBasicInformation teacherBasicInformation)
        {
            instanceOfDbContext.TeacherBasicInformation.Add(teacherBasicInformation);
            instanceOfDbContext.SaveChanges();
        }
    }
}
