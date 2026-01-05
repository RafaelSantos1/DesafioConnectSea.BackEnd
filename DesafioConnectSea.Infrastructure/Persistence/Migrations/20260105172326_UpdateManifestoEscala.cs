using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioConnectSea.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateManifestoEscala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManifestoEscala_Escalas_IdEscala",
                table: "ManifestoEscala");

            migrationBuilder.DropForeignKey(
                name: "FK_ManifestoEscala_Manifestos_IdManifesto",
                table: "ManifestoEscala");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManifestoEscala",
                table: "ManifestoEscala");

            migrationBuilder.RenameTable(
                name: "ManifestoEscala",
                newName: "ManifestoEscalas");

            migrationBuilder.RenameIndex(
                name: "IX_ManifestoEscala_IdManifesto",
                table: "ManifestoEscalas",
                newName: "IX_ManifestoEscalas_IdManifesto");

            migrationBuilder.RenameIndex(
                name: "IX_ManifestoEscala_IdEscala",
                table: "ManifestoEscalas",
                newName: "IX_ManifestoEscalas_IdEscala");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManifestoEscalas",
                table: "ManifestoEscalas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ManifestoEscalas_Escalas_IdEscala",
                table: "ManifestoEscalas",
                column: "IdEscala",
                principalTable: "Escalas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManifestoEscalas_Manifestos_IdManifesto",
                table: "ManifestoEscalas",
                column: "IdManifesto",
                principalTable: "Manifestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManifestoEscalas_Escalas_IdEscala",
                table: "ManifestoEscalas");

            migrationBuilder.DropForeignKey(
                name: "FK_ManifestoEscalas_Manifestos_IdManifesto",
                table: "ManifestoEscalas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManifestoEscalas",
                table: "ManifestoEscalas");

            migrationBuilder.RenameTable(
                name: "ManifestoEscalas",
                newName: "ManifestoEscala");

            migrationBuilder.RenameIndex(
                name: "IX_ManifestoEscalas_IdManifesto",
                table: "ManifestoEscala",
                newName: "IX_ManifestoEscala_IdManifesto");

            migrationBuilder.RenameIndex(
                name: "IX_ManifestoEscalas_IdEscala",
                table: "ManifestoEscala",
                newName: "IX_ManifestoEscala_IdEscala");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManifestoEscala",
                table: "ManifestoEscala",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ManifestoEscala_Escalas_IdEscala",
                table: "ManifestoEscala",
                column: "IdEscala",
                principalTable: "Escalas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManifestoEscala_Manifestos_IdManifesto",
                table: "ManifestoEscala",
                column: "IdManifesto",
                principalTable: "Manifestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
