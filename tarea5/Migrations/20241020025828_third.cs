using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea4.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColecciondeEntidadesClasePersonajes_ColecciondeEntidadesClaseVideoJuegos_constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.DropIndex(
                name: "IX_ColecciondeEntidadesClasePersonajes_constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.DropColumn(
                name: "SeriePeliculaLibroId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.DropColumn(
                name: "constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.AddColumn<int>(
                name: "ClaseVideoJuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ColecciondeEntidadesClasePersonajes_ClaseVideoJuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                column: "ClaseVideoJuegosId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColecciondeEntidadesClasePersonajes_ColecciondeEntidadesClaseVideoJuegos_ClaseVideoJuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                column: "ClaseVideoJuegosId",
                principalTable: "ColecciondeEntidadesClaseVideoJuegos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColecciondeEntidadesClasePersonajes_ColecciondeEntidadesClaseVideoJuegos_ClaseVideoJuegosId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.DropIndex(
                name: "IX_ColecciondeEntidadesClasePersonajes_ClaseVideoJuegosId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.DropColumn(
                name: "ClaseVideoJuegosId",
                table: "ColecciondeEntidadesClasePersonajes");

            migrationBuilder.AddColumn<int>(
                name: "SeriePeliculaLibroId",
                table: "ColecciondeEntidadesClasePersonajes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ColecciondeEntidadesClasePersonajes_constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                column: "constructor_videojuegosId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColecciondeEntidadesClasePersonajes_ColecciondeEntidadesClaseVideoJuegos_constructor_videojuegosId",
                table: "ColecciondeEntidadesClasePersonajes",
                column: "constructor_videojuegosId",
                principalTable: "ColecciondeEntidadesClaseVideoJuegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
