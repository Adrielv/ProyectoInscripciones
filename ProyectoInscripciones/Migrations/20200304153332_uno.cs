using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoInscripciones.Migrations
{
    public partial class uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: false),
                    Codigo = table.Column<decimal>(nullable: false),
                    PreRequisito = table.Column<decimal>(nullable: false),
                    Creditos = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<decimal>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Inscripcions",
                columns: table => new
                {
                    InscripcionesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcions", x => x.InscripcionesId);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagosId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    EstudianteId = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagosId);
                });

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
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "InscripcionDetalles");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Inscripcions");
        }
    }
}
