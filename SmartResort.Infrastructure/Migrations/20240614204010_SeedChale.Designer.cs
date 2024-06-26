﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartResort.Infrastructure.Data;

#nullable disable

namespace SmartResort.Infrastructure.Migrations
{
    [DbContext(typeof(SmartResortContext))]
    [Migration("20240614204010_SeedChale")]
    partial class SeedChale
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartResort.Domain.Entities.Chale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosQuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupacao")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Chalé de luxo com vista para o mar",
                            MetrosQuadrados = 55,
                            Nome = "Chalé Real",
                            Ocupacao = 4,
                            Preco = 200m,
                            UrlImagem = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = 2,
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Chalé com piscina privativa e vista para o mar",
                            MetrosQuadrados = 55,
                            Nome = "Chalé com Piscina Premium",
                            Ocupacao = 4,
                            Preco = 300m,
                            UrlImagem = "https://placehold.co/600x401"
                        },
                        new
                        {
                            Id = 3,
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Chalé com piscina privativa e vista para o mar",
                            MetrosQuadrados = 75,
                            Nome = "Chalé com Piscina de Luxo",
                            Ocupacao = 4,
                            Preco = 400m,
                            UrlImagem = "https://placehold.co/600x402"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
