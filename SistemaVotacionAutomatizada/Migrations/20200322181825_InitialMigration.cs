using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVotacionAutomatizada.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudadanos",
                columns: table => new
                {
                    Id = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    apellido = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudadanos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elecciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elecciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    logo = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puesto_electivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    estado = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto_electivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    apellido = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    photo = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    estado = table.Column<bool>(nullable: true),
                    PartidoID = table.Column<int>(nullable: true),
                    Puesto_electivosID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Candidato__Parti__70DDC3D8",
                        column: x => x.PartidoID,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Candidato__Puest__71D1E811",
                        column: x => x.Puesto_electivosID,
                        principalTable: "Puesto_electivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VotosElecciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EleccionID = table.Column<int>(nullable: true),
                    CandidatoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotosElecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK__VotosElec__Candi__75A278F5",
                        column: x => x.CandidatoID,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__VotosElec__Elecc__74AE54BC",
                        column: x => x.EleccionID,
                        principalTable: "Elecciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_PartidoID",
                table: "Candidatos",
                column: "PartidoID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_Puesto_electivosID",
                table: "Candidatos",
                column: "Puesto_electivosID");

            migrationBuilder.CreateIndex(
                name: "IX_VotosElecciones_CandidatoID",
                table: "VotosElecciones",
                column: "CandidatoID");

            migrationBuilder.CreateIndex(
                name: "IX_VotosElecciones_EleccionID",
                table: "VotosElecciones",
                column: "EleccionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudadanos");

            migrationBuilder.DropTable(
                name: "VotosElecciones");

            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "Elecciones");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Puesto_electivos");
        }
    }
}
