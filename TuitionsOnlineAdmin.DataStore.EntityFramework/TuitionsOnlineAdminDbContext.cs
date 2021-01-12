//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the Database context


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
        public DbSet<PostGraduateCourse> PostGraduateCourse { get; set; }
        public DbSet<DoctorateCourse> DoctorateCourse { get; set; }

        public DbSet<CertificateCourse> CertificateCourse { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Currency> Currency { get; set; }

        public DbSet<Subject> Subject { get; set; }
        public DbSet<Grade> Grade { get; set; }

        public DbSet<TeacherVideo> TeacherVideo { get; set; }

        public DbSet<HighSchoolBoard> HighSchoolBoard { get; set; }
    }
}
