using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

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
        //Author: GJ, TP, VM, SN
        //Date: 16/02/2021
        //commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution
        public DbSet<TeacherBasicInformation> TeacherBasicInformation { get; set; }

        public DbSet<TeacherAuthenticationDetails> TeacherAuthenticationDetails { get; set; }

        public DbSet<TeacherGraduateCourse_Qualification> TeacherGraduateCourse_Qualification { get; set; }

        public DbSet<TeacherPostGraduateCourse_Qualification> TeacherPostGraduateCourse_Qualification { get; set; }

        public DbSet<TeacherDoctorateCourse_Qualification> TeacherDoctorateCourse_Qualification { get; set; }

        public DbSet<TeacherCertificateCourse_Qualification> TeacherCertificateCourse_Qualification { get; set; }

        public DbSet<TeacherHighSchoolBoard> TeacherHighSchoolBoard { get; set; }
    }
}
