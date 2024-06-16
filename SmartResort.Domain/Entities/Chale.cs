using System.ComponentModel.DataAnnotations;

namespace SmartResort.Domain.Entities;

public class Chale
{
    public int Id { get; set; }

    [MaxLength(50)]
    public required string Nome { get; set; }

    [Display(Name = "Descrição")]
    public string? Descricao { get; set; }

    [Display(Name = "Preço por Diária")]
    [Range(10, 10000)]
    public decimal Preco { get; set; }

    [Display(Name = "Tamanho em m²")]
    public int MetrosQuadrados { get; set; }

    [Display(Name = "Ocupação")]
    [Range(1, 10)]
    public int Ocupacao { get; set; }

    [Display(Name = "URL da Imagem")]
    public string? UrlImagem { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAtualizacao { get; set; }
}
