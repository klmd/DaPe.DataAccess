using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DaPe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class all : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayCategoryNr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfProduct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayTypeOfProductNr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfProduct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayProductNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    KindOfProductId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_TypeOfProducts_KindOfProductId",
                        column: x => x.KindOfProductId,
                        principalTable: "TypeOfProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayCategoryNr", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Plyn" },
                    { 2, 2, "Voda" },
                    { 3, 3, "Elektrika" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfProducts",
                columns: new[] { "Id", "DisplayTypeOfProductNr", "TypeOfProduct" },
                values: new object[,]
                {
                    { 1, 1, "Hlavní měřidlo" },
                    { 2, 2, "Podružné měřidlo" },
                    { 3, 3, "Dopočtené měřidlo" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "DisplayProductNr", "ImageUrl", "KindOfProductId", "NameOfProduct" },
                values: new object[,]
                {
                    { 1, 1, "Hlavní vodoměr venku za zámečkem", "Doplň číslo měřáku", "", 1, "Vodoměr hlavní" },
                    { 2, 1, "Rozvodna vody na středisku 320 - dveře č. - ???", "Doplň číslo měřáku", "", 1, "Vodoměr - budova 7" },
                    { 3, 1, "Umístění - dole v rozvodně budovy M24 dveře č. ???", "Doplň číslo měřáku", "", 1, "Vodoměr-M24-dole" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_KindOfProductId",
                table: "Products",
                column: "KindOfProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TypeOfProducts");
        }
    }
}
