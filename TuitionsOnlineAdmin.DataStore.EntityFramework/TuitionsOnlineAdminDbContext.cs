using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework
{
   public class TuitionsOnlineAdminDbContext:DbContext
    {
       public TuitionsOnlineAdminDbContext(DbContextOptions<TuitionsOnlineAdminDbContext> options)
           :base(options)
       {

      }
        public DbSet<GraduateCourse> GraduateCourse { get; set; }
    }
}
