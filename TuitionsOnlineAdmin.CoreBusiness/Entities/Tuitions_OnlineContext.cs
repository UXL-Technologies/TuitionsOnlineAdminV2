using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class Tuitions_OnlineContext : DbContext
    {
        public Tuitions_OnlineContext()
        {
        }

        public Tuitions_OnlineContext(DbContextOptions<Tuitions_OnlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CertificateCourse> CertificateCourses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<DoctorateCourse> DoctorateCourses { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<GraduateCourse> GraduateCourses { get; set; }
        public virtual DbSet<HighSchoolBoard> HighSchoolBoards { get; set; }
        public virtual DbSet<PostGraduateCourse> PostGraduateCourses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<TeacherAuthenticationDetail> TeacherAuthenticationDetails { get; set; }
        public virtual DbSet<TeacherBasicInformation> TeacherBasicInformations { get; set; }
        public virtual DbSet<TeacherCertificateCourseQualification> TeacherCertificateCourseQualifications { get; set; }
        public virtual DbSet<TeacherCertificateCourseQualificationSubject> TeacherCertificateCourseQualificationSubjects { get; set; }
        public virtual DbSet<TeacherDoctorateCourseQualification> TeacherDoctorateCourseQualifications { get; set; }
        public virtual DbSet<TeacherDoctorateCourseQualificationSubject> TeacherDoctorateCourseQualificationSubjects { get; set; }
        public virtual DbSet<TeacherGraduateCourseQualification> TeacherGraduateCourseQualifications { get; set; }
        public virtual DbSet<TeacherGraduateCourseQualificationSubject> TeacherGraduateCourseQualificationSubjects { get; set; }
        public virtual DbSet<TeacherHelpdesk> TeacherHelpdesks { get; set; }
        public virtual DbSet<TeacherPhotograph> TeacherPhotographs { get; set; }
        public virtual DbSet<TeacherPostGraduateCourseQualification> TeacherPostGraduateCourseQualifications { get; set; }
        public virtual DbSet<TeacherPostGraduateCourseQualificationSubject> TeacherPostGraduateCourseQualificationSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8USICBL\\SQLEXPRESS;Database=Tuitions_Online;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CertificateCourse>(entity =>
            {
                entity.ToTable("CertificateCourse");

                entity.Property(e => e.CertificateCourseName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyId).ValueGeneratedNever();

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<DoctorateCourse>(entity =>
            {
                entity.ToTable("DoctorateCourse");

                entity.Property(e => e.DoctorateCourseName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade");

                entity.Property(e => e.GradeId).ValueGeneratedNever();

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GraduateCourse>(entity =>
            {
                entity.ToTable("GraduateCourse");

                entity.Property(e => e.GraduateCourseName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HighSchoolBoard>(entity =>
            {
                entity.ToTable("HighSchoolBoard");

                entity.Property(e => e.HighSchoolBoardId).ValueGeneratedNever();

                entity.Property(e => e.HighSchoolBoardName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PostGraduateCourse>(entity =>
            {
                entity.ToTable("PostGraduateCourse");

                entity.Property(e => e.PostGraduateCourseName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId).ValueGeneratedNever();

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TeacherAuthenticationDetail>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.Property(e => e.TeacherEmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherObjectId)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeacherBasicInformation>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("TeacherBasicInformation");

                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.AlternativeLanguage)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTelephoneNumber).HasColumnName("Contact_Telephone_Number");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.PreferredLanguage)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PricingStructure)
                    .IsRequired()
                    .HasColumnName("Pricing_Structure");

                entity.Property(e => e.Qualifications).IsRequired();

                entity.Property(e => e.Schedule).IsRequired();

                entity.Property(e => e.SellingPoint)
                    .IsRequired()
                    .HasColumnName("Selling_Point");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Teacher_Name");

                entity.Property(e => e.TeachingExperience)
                    .IsRequired()
                    .HasColumnName("Teaching_Experience");

                entity.Property(e => e.TeachingInterests)
                    .IsRequired()
                    .HasColumnName("Teaching_Interests");

                //entity.HasOne(d => d.TeacherName)
                //    .WithOne(p => p.TeacherBasicInformation)
                //    .HasForeignKey<TeacherBasicInformation>(d => d.TeacherId);
            });

            modelBuilder.Entity<TeacherCertificateCourseQualification>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.CertificateCourseId })
                    .HasName("PK_TeacherCertificateCourse_Qualification_1");

                entity.ToTable("TeacherCertificateCourse_Qualification");

                entity.Property(e => e.TeacherCertificateCourseQualificationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TeacherCertificateCourse_QualificationId");

                entity.HasOne(d => d.CertificateCourse)
                    .WithMany(p => p.TeacherCertificateCourseQualifications)
                    .HasForeignKey(d => d.CertificateCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCertificateCourse_Qualification_CertificateCourse");

                //entity.HasOne(d => d.Teacher)
                //    .WithMany(p => p.TeacherCertificateCourseQualifications)
                //    .HasForeignKey(d => d.TeacherId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TeacherCertificateCourse_Qualification_TeacherBasicInformation");
            });

            modelBuilder.Entity<TeacherCertificateCourseQualificationSubject>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.CertificateCourseId, e.SubjectId });

                entity.ToTable("TeacherCertificateCourse_Qualification_Subject");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherCertificateCourseQualificationSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCertificateCourse_Qualification_Subject_Subject");

                entity.HasOne(d => d.TeacherCertificateCourseQualification)
                    .WithMany(p => p.TeacherCertificateCourseQualificationSubjects)
                    .HasForeignKey(d => new { d.TeacherId, d.CertificateCourseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCertificateCourse_Qualification_Subject_TeacherCertificateCourse_Qualification");
            });

            modelBuilder.Entity<TeacherDoctorateCourseQualification>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.DoctorateCourseId });

                entity.ToTable("TeacherDoctorateCourse_Qualification");

                entity.Property(e => e.TeacherDoctorateCourseQualificationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TeacherDoctorateCourse_QualificationId");

                entity.HasOne(d => d.DoctorateCourse)
                    .WithMany(p => p.TeacherDoctorateCourseQualifications)
                    .HasForeignKey(d => d.DoctorateCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherDoctorateGraduateCourse_Qualification_DoctorateCourse");

                //entity.HasOne(d => d.Teacher)
                //    .WithMany(p => p.TeacherDoctorateCourseQualifications)
                //    .HasForeignKey(d => d.TeacherId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TeacherDoctorateGraduateCourse_Qualification_TeacherBasicInformation");
            });

            modelBuilder.Entity<TeacherDoctorateCourseQualificationSubject>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.DoctorateCourseId, e.SubjectId });

                entity.ToTable("TeacherDoctorateCourse_Qualification_Subject");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherDoctorateCourseQualificationSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherDoctorateCourse_Qualification_Subject_Subject");

                entity.HasOne(d => d.TeacherDoctorateCourseQualification)
                    .WithMany(p => p.TeacherDoctorateCourseQualificationSubjects)
                    .HasForeignKey(d => new { d.TeacherId, d.DoctorateCourseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherDoctorateCourse_Qualification_Subject_TeacherDoctorateCourse_Qualification");
            });

            modelBuilder.Entity<TeacherGraduateCourseQualification>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.GraduateCourseId });

                entity.ToTable("TeacherGraduateCourse_Qualification");

                entity.Property(e => e.TeacherGraduateCourseQualificationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TeacherGraduateCourse_QualificationId");

                entity.HasOne(d => d.GraduateCourse)
                    .WithMany(p => p.TeacherGraduateCourseQualifications)
                    .HasForeignKey(d => d.GraduateCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherGraduateCourse_Qualification_GraduateCourse");

                //entity.HasOne(d => d.Teacher)
                //    .WithMany(p => p.TeacherGraduateCourseQualifications)
                //    .HasForeignKey(d => d.TeacherId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TeacherGraduateCourse_Qualification_TeacherBasicInformation");
            });

            modelBuilder.Entity<TeacherGraduateCourseQualificationSubject>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.GraduateCourseId, e.SubjectId });

                entity.ToTable("TeacherGraduateCourse_Qualification_Subject");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherGraduateCourseQualificationSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherGraduateCourse_Qualification_Subject_Subject");

                entity.HasOne(d => d.TeacherGraduateCourseQualification)
                    .WithMany(p => p.TeacherGraduateCourseQualificationSubjects)
                    .HasForeignKey(d => new { d.TeacherId, d.GraduateCourseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherGraduateCourse_Qualification_Subject_TeacherGraduateCourse_Qualification");
            });

            modelBuilder.Entity<TeacherHelpdesk>(entity =>
            {
                entity.ToTable("TeacherHelpdesk");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.RequestDetails)
                    .IsRequired()
                    .HasColumnName("Request_Details");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Teacher_Name");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherHelpdesks)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherHelpdesk_TeacherHelpdesk");
            });

            modelBuilder.Entity<TeacherPhotograph>(entity =>
            {
                entity.ToTable("TeacherPhotograph");

                entity.Property(e => e.PhotographUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PhotographURL");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherPhotographs)
                    .HasForeignKey(d => d.TeacherId);
            });

            modelBuilder.Entity<TeacherPostGraduateCourseQualification>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.PostGraduateId })
                    .HasName("PK_TeacherPostGraduateCourse_Qualification_1");

                entity.ToTable("TeacherPostGraduateCourse_Qualification");

                entity.Property(e => e.TeacherPostGraduateCourseQualificationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TeacherPostGraduateCourse_QualificationId");

                entity.HasOne(d => d.PostGraduate)
                    .WithMany(p => p.TeacherPostGraduateCourseQualifications)
                    .HasForeignKey(d => d.PostGraduateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherPostGraduateCourse_Qualification_PostGraduateCourse");

                //entity.HasOne(d => d.Teacher)
                //    .WithMany(p => p.TeacherPostGraduateCourseQualifications)
                //    .HasForeignKey(d => d.TeacherId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TeacherPostGraduateCourse_Qualification_TeacherBasicInformation");
            });

            modelBuilder.Entity<TeacherPostGraduateCourseQualificationSubject>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.PostGraduateId, e.SubjectId });

                entity.ToTable("TeacherPostGraduateCourse_Qualification_Subject");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherPostGraduateCourseQualificationSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherPostGraduateCourse_Qualification_Subject_Subject");

                entity.HasOne(d => d.TeacherPostGraduateCourseQualification)
                    .WithMany(p => p.TeacherPostGraduateCourseQualificationSubjects)
                    .HasForeignKey(d => new { d.TeacherId, d.PostGraduateId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherPostGraduateCourse_Qualification_Subject_TeacherPostGraduateCourse_Qualification");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
