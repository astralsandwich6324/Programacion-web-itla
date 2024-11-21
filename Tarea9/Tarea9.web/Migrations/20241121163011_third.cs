using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea9.web.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColeccionDateTimeLV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColeccionDateTimeLV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColeccionDateTimeRV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColeccionDateTimeRV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coleccionvivivencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaVivencia = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coleccionvivivencias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColeccionDateTimeLV");

            migrationBuilder.DropTable(
                name: "ColeccionDateTimeRV");

            migrationBuilder.DropTable(
                name: "Coleccionvivivencias");
        }
    }
}
