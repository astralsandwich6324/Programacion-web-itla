using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea4.Migrations
{
    /// <inheritdoc />
    public partial class primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeriePeliculasLibros",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Pais = table.Column<string>(type: "TEXT", nullable: false),
                    Idioma = table.Column<string>(type: "TEXT", nullable: false),
                    FotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Resumen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriePeliculasLibros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apodo = table.Column<string>(type: "TEXT", nullable: true),
                    Raza = table.Column<string>(type: "TEXT", nullable: true),
                    FotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    PoderCaracteristico = table.Column<string>(type: "TEXT", nullable: true),
                    SeriePeliculaLibroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personajes_SeriePeliculasLibros_SeriePeliculaLibroId",
                        column: x => x.SeriePeliculaLibroId,
                        principalTable: "SeriePeliculasLibros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_SeriePeliculaLibroId",
                table: "Personajes",
                column: "SeriePeliculaLibroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "SeriePeliculasLibros");
        }
    }
}
