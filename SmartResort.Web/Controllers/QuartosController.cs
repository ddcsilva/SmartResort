using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartResort.Domain.Entities;
using SmartResort.Infrastructure.Data;
using SmartResort.Web.ViewModels;
using System.Collections.Generic;

namespace SmartResort.Web.Controllers;

public class QuartosController(SmartResortContext context) : Controller
{
    private readonly SmartResortContext _context = context;

    public IActionResult Index()
    {
        var quartos = _context.Quartos.Include(q => q.Bangalo).ToList();
        return View(quartos);
    }

    [HttpGet]
    public IActionResult Criar()
    {
        QuartoViewModel quartoViewModel = new()
        {
            ListaDeBangalos = _context.Bangalos.ToList().Select(u => new SelectListItem
            {
                Text = u.Nome,
                Value = u.Id.ToString()
            })
        };

        return View(quartoViewModel);
    }

    [HttpPost]
    public IActionResult Criar(QuartoViewModel quartoViewModel)
    {
        bool numeroQuartoExistente = _context.Quartos.Any(q => q.Numero == quartoViewModel.Quarto.Numero);

        if (ModelState.IsValid && !numeroQuartoExistente)
        {
            _context.Quartos.Add(quartoViewModel.Quarto);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Quarto cadastrado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        if (numeroQuartoExistente)
        {
            TempData["MensagemDeErro"] = "Já existe um quarto com esse número.";
        }

        quartoViewModel.ListaDeBangalos = _context.Bangalos.ToList().Select(u => new SelectListItem
        {
            Text = u.Nome,
            Value = u.Id.ToString()
        });

        return View(quartoViewModel);
    }

    [HttpGet]
    public IActionResult Editar(int quartoId)
    {
        QuartoViewModel quartoViewModel = new()
        {
            ListaDeBangalos = _context.Bangalos.ToList().Select(u => new SelectListItem
            {
                Text = u.Nome,
                Value = u.Id.ToString()
            }),
            Quarto = _context.Quartos.FirstOrDefault(u => u.Numero == quartoId)
        };

        if (quartoViewModel.Quarto == null)
        {
            return RedirectToAction("PaginaNaoEncontrada", "Home");
        }

        return View(quartoViewModel);
    }

    [HttpPost]
    public IActionResult Editar(QuartoViewModel quartoViewModel)
    {

        if (ModelState.IsValid)
        {
            _context.Quartos.Update(quartoViewModel.Quarto);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Quarto atualizado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        quartoViewModel.ListaDeBangalos = _context.Bangalos.ToList().Select(u => new SelectListItem
        {
            Text = u.Nome,
            Value = u.Id.ToString()
        });

        return View(quartoViewModel);
    }

    [HttpGet]
    public IActionResult Excluir(int quartoId)
    {
        QuartoViewModel quartoViewModel = new()
        {
            ListaDeBangalos = _context.Bangalos.ToList().Select(u => new SelectListItem
            {
                Text = u.Nome,
                Value = u.Id.ToString()
            }),
            Quarto = _context.Quartos.FirstOrDefault(u => u.Numero == quartoId)
        };

        if (quartoViewModel.Quarto == null)
        {
            return RedirectToAction("PaginaNaoEncontrada", "Home");
        }

        return View(quartoViewModel);
    }

    [HttpPost]
    public IActionResult Excluir(QuartoViewModel quartoViewModel)
    {
        Quarto? quartoEncontrado = _context.Quartos.FirstOrDefault(u => u.Numero == quartoViewModel.Quarto.Numero);

        if (quartoEncontrado is not null)
        {
            _context.Quartos.Remove(quartoEncontrado);
            _context.SaveChanges();
            TempData["MensagemDeSucesso"] = "Quarto excluído com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        TempData["MensagemDeErro"] = "O quarto não pôde ser excluído.";
        return View();
    }
}