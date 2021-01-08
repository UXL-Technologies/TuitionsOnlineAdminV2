using Microsoft.EntityFrameworkCore.Migrations;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificateCourse",
                columns: table => new
                {
                    CertificateCourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CertificateCourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateCourse", x => x.CertificateCourseId);
                });

            migrationBuilder.CreateTable(
                name: "DoctorateCourse",
                columns: table => new
                {
                    DoctorateCourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorateCourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    GraduateCourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GraduateCourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    PostGraduateCourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostGraduateCourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGraduateCourse", x => x.PostGraduateCourseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateCourse");

            migrationBuilder.DropTable(
                name: "DoctorateCourse");

            migrationBuilder.DropTable(
                name: "GraduateCourse");

            migrationBuilder.DropTable(
                name: "PostGraduateCourse");
        }
    }
}
