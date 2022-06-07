using Microsoft.EntityFrameworkCore.Migrations;

namespace Template_BackEnd.Migrations
{
    public partial class CreateAwardsSectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AwardsSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardName = table.Column<string>(nullable: true),
                    RowNumbers = table.Column<string>(nullable: true),
                    AwardDegree = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardsSections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwardsSections");
        }
    }
}
