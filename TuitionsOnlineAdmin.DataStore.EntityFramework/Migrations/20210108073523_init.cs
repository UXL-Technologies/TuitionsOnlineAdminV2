using Microsoft.EntityFrameworkCore.Migrations;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraduateCourse");
        }
    }
}
