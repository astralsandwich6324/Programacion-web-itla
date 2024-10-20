using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea4.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColecciondeEntidadesClasePlataforma",
                columns: table => new
                {
                    Id_Plataformas = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombredelaplataforma = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColecciondeEntidadesClasePlataforma", x => x.Id_Plataformas);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColecciondeEntidadesClasePlataforma");
        }
    }
}
