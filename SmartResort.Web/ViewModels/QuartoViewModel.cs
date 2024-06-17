using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartResort.Domain.Entities;

namespace SmartResort.Web.ViewModels;

public class QuartoViewModel
{
    public Quarto? Quarto { get; set; } = null!;

    [ValidateNever]
    public IEnumerable<SelectListItem>? ListaDeBangalos { get; set; }
}
