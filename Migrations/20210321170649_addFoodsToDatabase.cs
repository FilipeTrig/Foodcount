using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodcount.Migrations
{
    public partial class addFoodsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    displayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oneUnitWeight = table.Column<int>(type: "int", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Carbs = table.Column<int>(type: "int", nullable: false),
                    Sugars = table.Column<int>(type: "int", nullable: false),
                    Proteins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
