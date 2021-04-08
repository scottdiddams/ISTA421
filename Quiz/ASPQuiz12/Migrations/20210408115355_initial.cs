using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPQuiz10.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    nameId = table.Column<string>(nullable: false),
                    spouseName = table.Column<string>(nullable: false),
                    dogName = table.Column<string>(nullable: false),
                    catName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.nameId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
