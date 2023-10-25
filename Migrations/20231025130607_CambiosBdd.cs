using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JorgeMoncayo_Examen1P.Migrations
{
    public partial class CambiosBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JorgeMoncayo_tabla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreJuego = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Ps4 = table.Column<bool>(type: "bit", nullable: false),
                    Ps5 = table.Column<bool>(type: "bit", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JorgeMoncayo_tabla", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JorgeMoncayo_tabla");
        }
    }
}
