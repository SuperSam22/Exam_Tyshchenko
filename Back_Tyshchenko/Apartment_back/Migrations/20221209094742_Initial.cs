using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Apartment_back.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id_apartment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Square = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "int", nullable: false),
                    Location = table.Column<DateTime>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id_apartment", "Category", "Location", "Square", "Price" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2022, 9, 9, 10, 47, 42, 160,), "Price", 245.5 },
                    { 2, 4, new DateTime(2022, 11, 27, 10, 47, 42, 160,), "Square", 320.75 },
                    { 3, 2, new DateTime(2022, 12, 8, 10, 47, 42, 160,), "Category ", 100.0 },
                    { 4, 3, new DateTime(2022, 12, 9, 10, 47, 42, 160,), " Id_apartment", 7500.75 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
