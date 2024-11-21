using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea9.web.Migrations
{
    /// <inheritdoc />
    public partial class elev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaModificacion",
                table: "Coleccionvivivencias",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UltimaModificacion",
                table: "Coleccionvivivencias");
        }
    }
}
