using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartResort.Domain.Entities;

public class Quarto
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display(Name = "Número")]
    public int Numero { get; set; }

    public string? DetalhesExtras { get; set; }

    [ForeignKey("Bangalo")]
    public int BangaloId { get; set; }

    [ValidateNever]
    public Bangalo Bangalo { get; set; } = null!;
}
