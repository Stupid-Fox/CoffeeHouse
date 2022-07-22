using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class CoffeeHouseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Temperature = table.Column<int>(type: "int", nullable: false),
                    MakeTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CupEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CoffeeEntity",
                columns: new[] { "Id", "Cost", "MakeTime", "Name", "Temperature" },
                values: new object[,]
                {
                    { 1, 37, 12, "Tom", 14 },
                    { 2, 41, 12, "Bob", 14 },
                    { 3, 24, 12, "Sam", 14 }
                });

            migrationBuilder.InsertData(
                table: "CupEntity",
                columns: new[] { "Id", "Cost", "Material", "Name", "Volume" },
                values: new object[] { 1, 10, 123, "Food1", 22 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeeEntity");

            migrationBuilder.DropTable(
                name: "CupEntity");
        }
    }
}
