using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Migrations
{
    public partial class shravan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificateCourse",
                columns: table => new
                {
                    CertificateCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificateCourseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateCourse", x => x.CertificateCourseId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    PinCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    CurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "DoctorateCourse",
                columns: table => new
                {
                    DoctorateCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorateCourseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorateCourse", x => x.DoctorateCourseId);
                });

            migrationBuilder.CreateTable(
                name: "GraduateCourse",
                columns: table => new
                {
                    GraduateCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GraduateCourseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduateCourse", x => x.GraduateCourseId);
                });

            migrationBuilder.CreateTable(
                name: "PostGraduateCourse",
                columns: table => new
                {
                    PostGraduateCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostGraduateCourseName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateCourse", x => x.PostGraduateCourseId);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateCourse");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "DoctorateCourse");

            migrationBuilder.DropTable(
                name: "GraduateCourse");

            migrationBuilder.DropTable(
                name: "PostGraduateCourse");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
