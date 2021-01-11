using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
   public class ClassRepository: IClassRepository
    {
        private readonly TuitionsOnlineAdminDbContext _database;
        public ClassRepository(TuitionsOnlineAdminDbContext _database)
        {

            this._database = _database;
        }

        //public void CreateClassRepository(Class class)
        //{
        //    _database.Class.Add(class);
        //    _database.SaveChanges();
        //}
    }
}
