using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColecciondeEntidadesClaseVideoJuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Desarrollador = table.Column<string>(type: "TEXT", nullable: true),
                    Plataforma = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    FechaDeLanzamiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImagenDePortada = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColecciondeEntidadesClaseVideoJuegos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColecciondeEntidadesClasePersonajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Rol = table.Column<string>(type: "TEXT", nullable: true),
                    Habilidad = table.Column<string>(type: "TEXT", nullable: true),
                    ArmaFavorita = table.Column<string>(type: "TEXT", nullable: true),
                    NivelDePoder = table.Column<int>(type: "INTEGER", nullable: false),
                    FotoDelPersonaje = table.Column<string>(type: "TEXT", nullable: true),
                    SeriePeliculaLibroId = table.Column<int>(type: "INTEGER", nullable: false),
                    constructor_videojuegosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColecciondeEntidadesClasePersonajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColecciondeEntidadesClasePersonajes_ColecciondeEntidadesClaseVideoJuegos_constructor_videojuegosId",
                        column: x => x.constructor_videojuegosId,
                        principalTable: "ColecciondeEntidadesClaseVideoJuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColecciondeEntidadesClasePersonajes_constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                column: "constructor_videojuegosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.DropTable(
                name: "ColecciondeEntidadesClaseVideoJuegos");
        }
    }
}
