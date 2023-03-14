using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Parcial1AP1.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false),
                    Emison = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Emison", "Precio", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateOnly(2000, 10, 1), 2000.0, "Berserk Vol.1" },
                    { 2, new DateOnly(2001, 10, 1), 3000.0, "Berserk Vol.2" },
                    { 3, new DateOnly(2002, 10, 1), 4000.0, "Berserk Vol.3" },
                    { 4, new DateOnly(2003, 10, 1), 5000.0, "Berserk Vol.4" },
                    { 5, new DateOnly(2004, 10, 1), 6000.0, "Berserk Vol.5" },
                    { 6, new DateOnly(2005, 10, 1), 7000.0, "Berserk Vol.6" },
                    { 7, new DateOnly(2006, 10, 1), 8000.0, "Berserk Vol.7" },
                    { 8, new DateOnly(2007, 10, 1), 9000.0, "Berserk Vol.8" },
                    { 9, new DateOnly(2008, 10, 1), 10000.0, "Berserk Vol.9" },
                    { 10, new DateOnly(2009, 10, 1), 11000.0, "Berserk Vol.10" },
                    { 11, new DateOnly(2022, 10, 1), 12000.0, "Berserk Vol.11" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
