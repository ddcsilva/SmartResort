namespace SmartResort.Domain.Entities;

public class Chale
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public int MetrosQuadrados { get; set; }
    public int Ocupacao { get; set; }
    public string? UrlImagem { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAtualizacao { get; set; }
}
