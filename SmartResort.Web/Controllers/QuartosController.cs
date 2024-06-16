using Microsoft.AspNetCore.Mvc;
using SmartResort.Domain.Entities;
using SmartResort.Infrastructure.Data;

namespace SmartResort.Web.Controllers;

public class QuartosController(SmartResortContext context) : Controller
{
    private readonly SmartResortContext _context = context;

    [HttpGet]
    public IActionResult Index()
    {
        var quartos = _context.Quartos.ToList();
        return View(quartos);
    }

    [HttpGet]
    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(Quarto quarto)
    {
        if (quarto.Nome == quarto.Descricao)
        {
            ModelState.AddModelError("Nome", "O nome do quarto não pode ser igual à descrição.");
        }

        if (ModelState.IsValid)
        {
            _context.Quartos.Add(quarto);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Quarto cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public IActionResult Editar(int quartoId)
    {
        Quarto? quarto = _context.Quartos.FirstOrDefault(u => u.Id == quartoId);

        if (quarto is null)
        {
            return RedirectToAction("PaginaNaoEncontrada", "Home");
        }

        return View(quarto);
    }

    [HttpPost]
    public IActionResult Editar(Quarto quarto)
    {
        if (ModelState.IsValid && quarto.Id > 0)
        {
            _context.Quartos.Update(quarto);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Quarto atualizado com sucesso!";
            return RedirectToAction("Index");
        }

        return View();
    }

    [HttpGet]
    public IActionResult Excluir(int quartoId)
    {
        Quarto? quarto = _context.Quartos.FirstOrDefault(u => u.Id == quartoId);

        if (quarto is null)
        {
            return RedirectToAction("PaginaNaoEncontrada", "Home");
        }

        return View(quarto);
    }

    [HttpPost]
    public IActionResult Excluir(Quarto quarto)
    {
        Quarto? quartoEncontrado = _context.Quartos.FirstOrDefault(u => u.Id == quarto.Id);

        if (quartoEncontrado is not null)
        {
            _context.Quartos.Remove(quartoEncontrado);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Quarto excluído com sucesso!";
            return RedirectToAction("Index");
        }

        return View();
    }
}