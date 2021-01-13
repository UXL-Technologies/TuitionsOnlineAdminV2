﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuitionsOnlineAdmin.DataStore.EntityFramework;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Migrations
{
    [DbContext(typeof(TuitionsOnlineAdminDbContext))]
    [Migration("20210113125336_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.CertificateCourse", b =>
                {
                    b.Property<Guid>("CertificateCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CertificateCourseName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("CertificateCourseId");

                    b.ToTable("CertificateCourse");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.Currency", b =>
                {
                    b.Property<Guid>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Default")
                        .HasColumnType("bit");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.DoctorateCourse", b =>
                {
                    b.Property<Guid>("DoctorateCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DoctorateCourseName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("DoctorateCourseId");

                    b.ToTable("DoctorateCourse");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.Grade", b =>
                {
                    b.Property<Guid>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GradeId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.GraduateCourse", b =>
                {
                    b.Property<Guid>("GraduateCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("GraduateCourseName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("GraduateCourseId");

                    b.ToTable("GraduateCourse");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.HighSchoolBoard", b =>
                {
                    b.Property<Guid>("HighSchoolBoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("HighSchoolBoardName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("HighSchoolBoardId");

                    b.ToTable("HighSchoolBoard");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.PostGraduateCourse", b =>
                {
                    b.Property<Guid>("PostGraduateCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("PostGraduateCourseName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("PostGraduateCourseId");

                    b.ToTable("PostGraduateCourse");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.TeacherBasicInformation", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AlternateLanguage")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ContactTeleNumber")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceInYears")
                        .HasColumnType("int");

                    b.Property<string>("PreferredLanguage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TeacherFullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TeacherPhotographUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("TeacherBasicInformation");
                });

            modelBuilder.Entity("TuitionsOnlineAdmin.CoreBusiness.TeacherVideo", b =>
                {
                    b.Property<Guid>("TeacherVideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherVideoId");

                    b.ToTable("TeacherVideo");
                });
#pragma warning restore 612, 618
        }
    }
}