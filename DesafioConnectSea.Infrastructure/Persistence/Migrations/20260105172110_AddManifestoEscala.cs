using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioConnectSea.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddManifestoEscala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManifestoEscala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdManifesto = table.Column<int>(type: "int", nullable: false),
                    IdEscala = table.Column<int>(type: "int", nullable: false),
                    DataVinculacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManifestoEscala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManifestoEscala_Escalas_IdEscala",
                        column: x => x.IdEscala,
                        principalTable: "Escalas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManifestoEscala_Manifestos_IdManifesto",
                        column: x => x.IdManifesto,
                        principalTable: "Manifestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManifestoEscala_IdEscala",
                table: "ManifestoEscala",
                column: "IdEscala",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ManifestoEscala_IdManifesto",
                table: "ManifestoEscala",
                column: "IdManifesto",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManifestoEscala");
        }
    }
}
