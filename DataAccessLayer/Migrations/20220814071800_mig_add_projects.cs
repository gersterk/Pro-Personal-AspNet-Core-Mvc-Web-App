using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_projects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectContenct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectImage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectImage4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveProject = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
