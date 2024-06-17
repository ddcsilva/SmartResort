using Microsoft.AspNetCore.Mvc;
using SmartResort.Domain.Entities;
using SmartResort.Infrastructure.Data;

namespace SmartResort.Web.Controllers;

public class BangalosController(SmartResortContext context) : Controller
{
    private readonly SmartResortContext _context = context;

    [HttpGet]
    public IActionResult Index()
    {
        var bangalos = _context.Bangalos.ToList();
        return View(bangalos);
    }

    [HttpGet]
    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(Bangalo bangalo)
    {
        if (bangalo.Nome == bangalo.Descricao)
        {
            ModelState.AddModelError("Nome", "O nome do bangalô não pode ser igual à descrição.");
        }

        if (ModelState.IsValid)
        {
            _context.Bangalos.Add(bangalo);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Bangalô cadastrado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public IActionResult Editar(int bangaloId)
    {
        Bangalo? bangalo = _context.Bangalos.FirstOrDefault(u => u.Id == bangaloId);

        if (bangalo is null)
        {
            return RedirectToAction("PaginaNaoEncontrada", "Home");
        }

        return View(bangalo);
    }

    [HttpPost]
    public IActionResult Editar(Bangalo bangalo)
    {
        if (ModelState.IsValid && bangalo.Id > 0)
        {
            _context.Bangalos.Update(bangalo);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Bangalô atualizado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public IActionResult Excluir(int bangaloId)
    {
        Bangalo? bangalo = _context.Bangalos.FirstOrDefault(u => u.Id == bangaloId);

        if (bangalo is null)
        {
            return RedirectToAction("PaginaNaoEncontrada", "Home");
        }

        return View(bangalo);
    }

    [HttpPost]
    public IActionResult Excluir(Bangalo bangalo)
    {
        Bangalo? bangaloEncontrado = _context.Bangalos.FirstOrDefault(u => u.Id == bangalo.Id);

        if (bangaloEncontrado is not null)
        {
            _context.Bangalos.Remove(bangaloEncontrado);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Bangalô excluído com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        return View();
    }
}