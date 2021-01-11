//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Repository for Certificate course

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class CertificateCourseRepository: ICertificateCourseRepository
    {
        private readonly TuitionsOnlineAdminDbContext _database;
        public CertificateCourseRepository(TuitionsOnlineAdminDbContext _database)
        {
            this._database = _database;
        }


        //To create a single record for CertificateCourse
        public void CreateCertificateCourseRepository(CertificateCourse certificateCourse)
        {
            _database.CertificateCourse.Add(certificateCourse);
            _database.SaveChanges();
        }

    }
}
