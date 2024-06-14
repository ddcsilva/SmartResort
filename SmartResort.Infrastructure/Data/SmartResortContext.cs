using Microsoft.EntityFrameworkCore;
using SmartResort.Domain.Entities;

namespace SmartResort.Infrastructure.Data;

public class SmartResortContext(DbContextOptions<SmartResortContext> options) : DbContext(options)
{
    public DbSet<Chale> Chales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chale>().HasData(
            new Chale
            {
                Id = 1,
                Nome = "Chalé Real",
                Descricao = "Chalé de luxo com vista para o mar",
                UrlImagem = "https://placehold.co/600x400",
                Ocupacao = 4,
                Preco = 200,
                MetrosQuadrados = 55
            },
            new Chale
            {
                Id = 2,
                Nome = "Chalé com Piscina Premium",
                Descricao = "Chalé com piscina privativa e vista para o mar",
                UrlImagem = "https://placehold.co/600x401",
                Ocupacao = 4,
                Preco = 300,
                MetrosQuadrados = 55
            },
            new Chale
            {
                Id = 3,
                Nome = "Chalé com Piscina de Luxo",
                Descricao = "Chalé com piscina privativa e vista para o mar",
                UrlImagem = "https://placehold.co/600x402",
                Ocupacao = 4,
                Preco = 400,
                MetrosQuadrados = 75
            }
        );
    }
}