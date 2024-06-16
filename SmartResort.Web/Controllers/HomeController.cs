using Microsoft.AspNetCore.Mvc;

namespace SmartResort.Web.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult PaginaNaoEncontrada()
    {
        return View();
    }
}
