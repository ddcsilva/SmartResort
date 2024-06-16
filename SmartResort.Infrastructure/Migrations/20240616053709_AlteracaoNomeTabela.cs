﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartResort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chales");

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MetrosQuadrados = table.Column<int>(type: "int", nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quartos",
                columns: new[] { "Id", "Capacidade", "DataAtualizacao", "DataCriacao", "Descricao", "MetrosQuadrados", "Nome", "Preco", "UrlImagem" },
                values: new object[,]
                {
                    { 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quarto de luxo com vista para o mar", 55, "Quarto Real", 200m, "https://placehold.co/600x400" },
                    { 2, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quarto com piscina privativa e vista para o mar", 55, "Quarto com Piscina Premium", 300m, "https://placehold.co/600x401" },
                    { 3, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quarto com piscina privativa e vista para o mar", 75, "Quarto com Piscina de Luxo", 400m, "https://placehold.co/600x402" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.CreateTable(
                name: "Chales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetrosQuadrados = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocupacao = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chales", x => x.Id);
                });

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
    }
}
