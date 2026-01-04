using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DesafioConnectSea.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Escalas",
                columns: new[] { "Id", "Eta", "Navio", "Porto", "Status" },
                values: new object[,]
                {
                    { 201, new DateTime(2025, 8, 27, 5, 0, 0, 0, DateTimeKind.Unspecified), "MV Atlas", "BRRGD - RIO GRANDE", 1 },
                    { 202, new DateTime(2025, 8, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), "MV Atlas", "BRITJ - ITAJAI", 2 },
                    { 203, new DateTime(2025, 8, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), "MV Atlas", "BRPNG - PARANAGUA", 1 },
                    { 204, new DateTime(2025, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), "MV Atlas", "BRSSZ - SANTOS", 1 },
                    { 301, new DateTime(2025, 8, 22, 3, 0, 0, 0, DateTimeKind.Unspecified), "MV Poseidon", "BRRGD - RIO GRANDE", 4 },
                    { 302, new DateTime(2025, 8, 24, 6, 0, 0, 0, DateTimeKind.Unspecified), "MV Poseidon", "BRITJ - ITAJAI", 3 },
                    { 303, new DateTime(2025, 8, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "MV Poseidon", "BRSSZ - SANTOS", 1 }
                });

            migrationBuilder.InsertData(
                table: "Manifestos",
                columns: new[] { "Id", "Navio", "Numero", "PortoDestino", "PortoOrigem", "Tipo" },
                values: new object[,]
                {
                    { 1, "MV Atlas", "IMP-2025-0001", "BR SANTOS", "CN SHANGHAI", 1 },
                    { 2, "MV Poseidon", "EXP-2025-0042", "NL ROTTERDAM", "BR RIO GRANDE", 2 },
                    { 3, "MV Hermes", "IMP-2025-0099", "BR SANTOS", "US MIAMI", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Escalas",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Manifestos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manifestos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manifestos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
