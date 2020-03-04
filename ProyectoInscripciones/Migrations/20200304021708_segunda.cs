using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoInscripciones.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InscripcionDetalles",
                columns: table => new
                {
                    InscripcionDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InscripcionesId = table.Column<int>(nullable: false),
                    AsignaturaId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Creditos = table.Column<int>(nullable: false),
                    Subtotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscripcionDetalles", x => x.InscripcionDetalleId);
                    table.ForeignKey(
                        name: "FK_InscripcionDetalles_Inscripcions_InscripcionesId",
                        column: x => x.InscripcionesId,
                        principalTable: "Inscripcions",
                        principalColumn: "InscripcionesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InscripcionDetalles_InscripcionesId",
                table: "InscripcionDetalles",
                column: "InscripcionesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InscripcionDetalles");
        }
    }
}
