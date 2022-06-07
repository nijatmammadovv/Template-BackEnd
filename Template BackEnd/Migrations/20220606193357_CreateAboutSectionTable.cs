using Microsoft.EntityFrameworkCore.Migrations;

namespace Template_BackEnd.Migrations
{
    public partial class CreateAboutSectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aboutSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NumbervsAdress = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aboutSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true),
                    AverageScore = table.Column<string>(nullable: true),
                    PresentationHistory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialtyName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PresentationHistory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillsSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: true),
                    WorkNames = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsSections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aboutSections");

            migrationBuilder.DropTable(
                name: "EducationSections");

            migrationBuilder.DropTable(
                name: "ExperienceSections");

            migrationBuilder.DropTable(
                name: "SkillsSections");
        }
    }
}
