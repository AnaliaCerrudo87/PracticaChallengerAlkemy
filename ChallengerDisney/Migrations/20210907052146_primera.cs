using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengerDisney.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Historia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaSerie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSerie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeliculaSerie_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaSeriePersonaje",
                columns: table => new
                {
                    PeliculaSeriesId = table.Column<int>(type: "int", nullable: false),
                    PersonajesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSeriePersonaje", x => new { x.PeliculaSeriesId, x.PersonajesId });
                    table.ForeignKey(
                        name: "FK_PeliculaSeriePersonaje_PeliculaSerie_PeliculaSeriesId",
                        column: x => x.PeliculaSeriesId,
                        principalTable: "PeliculaSerie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaSeriePersonaje_Personaje_PersonajesId",
                        column: x => x.PersonajesId,
                        principalTable: "Personaje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSerie_GeneroId",
                table: "PeliculaSerie",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSeriePersonaje_PersonajesId",
                table: "PeliculaSeriePersonaje",
                column: "PersonajesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeliculaSeriePersonaje");

            migrationBuilder.DropTable(
                name: "PeliculaSerie");

            migrationBuilder.DropTable(
                name: "Personaje");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
