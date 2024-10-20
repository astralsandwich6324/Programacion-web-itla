using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea4.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ColecciondeEntidadesClasePersonajes",
                newName: "Id_personaje");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_personaje",
                table: "ColecciondeEntidadesClasePersonajes",
                newName: "Id");
        }
    }
}
