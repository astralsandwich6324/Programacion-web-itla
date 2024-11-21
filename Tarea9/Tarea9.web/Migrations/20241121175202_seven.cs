using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea9.web.Migrations
{
    /// <inheritdoc />
    public partial class seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextoImagen",
                table: "Coleccionvivivencias");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Coleccionvivivencias");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextoImagen",
                table: "Coleccionvivivencias",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Coleccionvivivencias",
                type: "TEXT",
                nullable: true);
        }
    }
}
