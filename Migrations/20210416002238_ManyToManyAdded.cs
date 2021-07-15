using Microsoft.EntityFrameworkCore.Migrations;

namespace Foodcount.Migrations
{
    public partial class ManyToManyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tags",
                table: "Foods",
                newName: "Tags");

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    displayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Food_Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FoodId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_Dishes_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Food_Dishes_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_Dishes_DishId",
                table: "Food_Dishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_Dishes_FoodId",
                table: "Food_Dishes",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food_Dishes");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "Foods",
                newName: "tags");
        }
    }
}
