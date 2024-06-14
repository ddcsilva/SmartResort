using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartResort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedChale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chales",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "Descricao", "MetrosQuadrados", "Nome", "Ocupacao", "Preco", "UrlImagem" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chalé de luxo com vista para o mar", 55, "Chalé Real", 4, 200m, "https://placehold.co/600x400" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chalé com piscina privativa e vista para o mar", 55, "Chalé com Piscina Premium", 4, 300m, "https://placehold.co/600x401" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chalé com piscina privativa e vista para o mar", 75, "Chalé com Piscina de Luxo", 4, 400m, "https://placehold.co/600x402" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chales",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
