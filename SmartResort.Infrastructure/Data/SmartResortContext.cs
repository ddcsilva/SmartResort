using Microsoft.EntityFrameworkCore;
using SmartResort.Domain.Entities;

namespace SmartResort.Infrastructure.Data;

public class SmartResortContext(DbContextOptions<SmartResortContext> options) : DbContext(options)
{
    public DbSet<Bangalo> Bangalos { get; set; } = null!;
    public DbSet<Quarto> Quartos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bangalo>().HasData(
            new Bangalo
            {
                Id = 1,
                Nome = "Bangalo Real",
                Descricao = "Bangalo de luxo com vista para o mar",
                UrlImagem = "https://placehold.co/600x400",
                Capacidade = 4,
                Preco = 200,
                MetrosQuadrados = 55
            },
            new Bangalo
            {
                Id = 2,
                Nome = "Bangalo com Piscina Premium",
                Descricao = "Bangalo com piscina privativa e vista para o mar",
                UrlImagem = "https://placehold.co/600x401",
                Capacidade = 4,
                Preco = 300,
                MetrosQuadrados = 55
            },
            new Bangalo
            {
                Id = 3,
                Nome = "Bangalo com Piscina de Luxo",
                Descricao = "Bangalo com piscina privativa e vista para o mar",
                UrlImagem = "https://placehold.co/600x402",
                Capacidade = 4,
                Preco = 400,
                MetrosQuadrados = 75
            }
        );

        modelBuilder.Entity<Quarto>().HasData(
            new Quarto
            {
                Numero = 101,
                BangaloId = 1,
            },
            new Quarto
            {
                Numero = 102,
                BangaloId = 1,
            },
            new Quarto
            {
                Numero = 103,
                BangaloId = 1,
            },
            new Quarto
            {
                Numero = 104,
                BangaloId = 1,
            },
            new Quarto
            {
                Numero = 201,
                BangaloId = 2,
            },
            new Quarto
            {
                Numero = 202,
                BangaloId = 2,
            },
            new Quarto
            {
                Numero = 203,
                BangaloId = 2,
            },
            new Quarto
            {
                Numero = 301,
                BangaloId = 3,
            },
            new Quarto
            {
                Numero = 302,
                BangaloId = 3,
            }
        );
    }
}