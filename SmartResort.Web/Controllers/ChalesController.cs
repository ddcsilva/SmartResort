using Microsoft.AspNetCore.Mvc;
using SmartResort.Domain.Entities;
using SmartResort.Infrastructure.Data;

namespace SmartResort.Web.Controllers;

public class ChalesController(SmartResortContext context) : Controller
{
    private readonly SmartResortContext _context = context;

    public IActionResult Index()
    {
        var chales = _context.Chales.ToList();
        return View(chales);
    }

    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(Chale chale)
    {
        if (chale.Nome == chale.Descricao)
        {
            ModelState.AddModelError("Nome", "O nome do chalé não pode ser igual à descrição.");
        }
        if (ModelState.IsValid)
        {
            _context.Chales.Add(chale);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
}