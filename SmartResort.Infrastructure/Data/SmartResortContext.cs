using Microsoft.EntityFrameworkCore;
using SmartResort.Domain.Entities;

namespace SmartResort.Infrastructure.Data;

public class SmartResortContext(DbContextOptions<SmartResortContext> options) : DbContext(options)
{
    public DbSet<Quarto> Quartos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quarto>().HasData(
            new Quarto
            {
                Id = 1,
                Nome = "Quarto Real",
                Descricao = "Quarto de luxo com vista para o mar",
                UrlImagem = "https://placehold.co/600x400",
                Capacidade = 4,
                Preco = 200,
                MetrosQuadrados = 55
            },
            new Quarto
            {
                Id = 2,
                Nome = "Quarto com Piscina Premium",
                Descricao = "Quarto com piscina privativa e vista para o mar",
                UrlImagem = "https://placehold.co/600x401",
                Capacidade = 4,
                Preco = 300,
                MetrosQuadrados = 55
            },
            new Quarto
            {
                Id = 3,
                Nome = "Quarto com Piscina de Luxo",
                Descricao = "Quarto com piscina privativa e vista para o mar",
                UrlImagem = "https://placehold.co/600x402",
                Capacidade = 4,
                Preco = 400,
                MetrosQuadrados = 75
            }
        );
    }
}